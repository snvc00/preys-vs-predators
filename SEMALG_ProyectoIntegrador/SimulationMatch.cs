using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Threading;

namespace SEMALG_ProyectoIntegrador
{
    public class SimulationMatch
    {
        Point IPanelMiddle;
        bool IFirstBloodOcurred;
        Bitmap ITemporalFrame;
        Prey Survivor;
        Dictionary<string, Image> IStateImages;
        MainWindow Instance;
        string ILastStatus;

        public SimulationMatch(MainWindow mainWindowInstance)
        {
            this.Instance = mainWindowInstance;

            IStateImages = new Dictionary<string, Image>
            {
                ["Running"] = Image.FromFile("../../../resources/mainwindow/states/run.png"),
                ["End"] = Image.FromFile("../../../resources/mainwindow/states/end.png"),
                ["Target"] = Image.FromFile("../../../resources/mainwindow/states/target.png"),
                ["Initial"] = Image.FromFile("../../../resources/mainwindow/states/pause.png"),
                ["Death"] = Image.FromFile("../../../resources/mainwindow/states/death.png")
            };
        }

        public void SetInitialStatus(Point panelMiddle)
        {
            this.IPanelMiddle = panelMiddle;
            Instance.ComboBox_Target.DataSource = Instance.Graph.VertexList;
            SimulationInitialStatus();
        }

        public Prey ExecuteSimulation()
        {
            Dijkstra dijkstra;
            Random random = new Random();
            Dictionary<string, Edge> preyPath = new Dictionary<string, Edge>();
            Dictionary<string, Edge> predatorPath = new Dictionary<string, Edge>();
            Survivor = null;
            Instance.SoundPlayer.SoundLocation = Instance.SoundtrackPath["Running"];

            if (Instance.CheckBox_Music.Checked)
                Instance.SoundPlayer.PlayLooping();

            Thread.Sleep(1000);

            foreach (Prey p in Instance.Preys)
            {
                dijkstra = new Dijkstra(Instance.Graph, p.CurrentVertex);
                dijkstra.DijkstraAlgorithm();
                p.Path = ToolFunction.ConvertToEdgeStack(dijkstra.BuildPath((Vertex)Instance.ComboBox_Target.SelectedItem), Instance.Graph);
            }

            SimulationRunningStatus();

            foreach (Predator p in Instance.Predators)
            {
                p.VisitedEdges.Clear();
                p.Location = p.CurrentVertex.GetCirclePoint();
                predatorPath[p.Name] = p.CurrentVertex.GetEdges()[random.Next(p.CurrentVertex.GetEdgesListCount() - 1)];
                p.Iteration = 1;
                p.VisitedEdges.Add(predatorPath[p.Name]);
            }

            while (!CompletedSimulation())
            {
                foreach (Prey p in Instance.Preys)
                {
                    if (p.Path.Count > 0)
                    {
                        preyPath[p.Name] = p.Path.Pop();
                        p.Iteration = 1;
                    }
                    else
                    {
                        return null;
                    }
                }

                while (!AllPreysFinish())
                {
                    for (int i = 0; i < Instance.Preys.Count; ++i)
                    {
                        if (Instance.Preys[i].UnderPredation)
                        {
                            double distance = ToolFunction.Distance(Instance.Preys[i].Location, Instance.Preys[i].Predator.Location);

                            if (distance > Instance.Preys[i].Predator.HuntingPerimeter)
                            {
                                Instance.Preys[i].Predator.Hunting = false;
                                Instance.Preys[i].Predator.Prey = null;
                                Instance.Preys[i].UnderPredation = false;
                                Instance.Preys[i].UpdatePredator();

                                if (Instance.Preys[i].Speed < 10)
                                    Instance.Preys[i].Speed = 10;
                            }
                        }

                        bool returnToOrigin = false;

                        if (Instance.Preys[i].UnderPredation)
                        {
                            double distancePrey = ToolFunction.Distance(preyPath[Instance.Preys[i].Name].Destination.GetCirclePoint(), Instance.Preys[i].Location);
                            double distancePredator = ToolFunction.Distance(preyPath[Instance.Preys[i].Name].Destination.GetCirclePoint(), Instance.Preys[i].Predator.Location);

                            if (distancePrey > distancePredator)
                                returnToOrigin = true;
                        }

                        if (returnToOrigin)
                        {
                            if ((Instance.Preys[i].Iteration - Instance.Preys[i].Speed) > 0)
                            {
                                Instance.Preys[i].Iteration -= Instance.Preys[i].Speed;
                                Instance.Preys[i].Location = preyPath[Instance.Preys[i].Name].Path[Instance.Preys[i].Iteration];
                            }
                            else
                            {
                                Instance.Preys[i].Iteration = 0;
                                Instance.Preys[i].Location = Instance.Preys[i].CurrentVertex.GetCirclePoint();
                            }
                        }
                        else
                        {
                            if ((Instance.Preys[i].Iteration + Instance.Preys[i].Speed) < preyPath[Instance.Preys[i].Name].Path.Count)
                            {
                                if (Instance.Preys[i].Iteration != 0)
                                {
                                    Instance.Preys[i].Iteration += Instance.Preys[i].Speed;
                                    Instance.Preys[i].Location = preyPath[Instance.Preys[i].Name].Path[Instance.Preys[i].Iteration];
                                }
                                else
                                {
                                    if (Instance.Preys[i].Location != preyPath[Instance.Preys[i].Name].Destination.GetCirclePoint())
                                    {
                                        Instance.Preys[i].Iteration += Instance.Preys[i].Speed;
                                        Instance.Preys[i].Location = preyPath[Instance.Preys[i].Name].Path[Instance.Preys[i].Iteration];
                                    }
                                }
                            }
                            else
                            {
                                Instance.Preys[i].Iteration = 0;
                                Instance.Preys[i].CurrentVertex = preyPath[Instance.Preys[i].Name].Destination;
                                Instance.Preys[i].Location = Instance.Preys[i].CurrentVertex.GetCirclePoint();
                            }
                        }
                    }

                    for (int i = 0; i < Instance.Predators.Count; ++i)
                    {
                        Instance.Predators[i].VisitedEdges.Clear();

                        if ((Instance.Predators[i].Iteration + Instance.Predators[i].Speed) < predatorPath[Instance.Predators[i].Name].Path.Count)
                        {
                            Instance.Predators[i].Iteration += Instance.Predators[i].Speed;
                            Instance.Predators[i].Location = predatorPath[Instance.Predators[i].Name].Path[Instance.Predators[i].Iteration];
                        }
                        else
                        {
                            Instance.Predators[i].Iteration = 1;
                            Instance.Predators[i].CurrentVertex = predatorPath[Instance.Predators[i].Name].Destination;
                            Instance.Predators[i].Location = Instance.Predators[i].CurrentVertex.GetCirclePoint();

                            Edge nextEdge = null;

                            if (!Instance.Predators[i].Hunting)
                            {
                                for (int j = 0; j < Instance.Predators[i].CurrentVertex.GetEdgesListCount(); ++j)
                                {
                                    nextEdge = Instance.Predators[i].CurrentVertex.GetEdges()[random.Next(Instance.Predators[i].CurrentVertex.GetEdgesListCount())];

                                    if (!Instance.Predators[i].VisitedEdges.Contains(nextEdge))
                                        predatorPath[Instance.Predators[i].Name] = nextEdge;
                                }
                            }
                            else
                            {
                                foreach (Edge edge in predatorPath[Instance.Predators[i].Name].Destination.GetEdges())
                                {
                                    if (edge.Destination.ID == preyPath[Instance.Predators[i].Prey.Name].Destination.ID)
                                        nextEdge = edge;
                                    else if (edge.Destination.ID == Instance.Predators[i].Prey.CurrentVertex.ID && nextEdge == null)
                                        nextEdge = edge;
                                }
                            }

                            if (nextEdge == null)
                                predatorPath[Instance.Predators[i].Name] = Instance.Predators[i].CurrentVertex.GetEdges()[0];
                        }

                        for (int j = 0; j < Instance.Preys.Count; ++j)
                        {
                            double distance = ToolFunction.Distance(Instance.Predators[i].Location, Instance.Preys[j].Location);

                            if (distance <= Instance.Predators[i].HuntingPerimeter)
                            {
                                if (distance <= Instance.Predators[i].CollitionRange)
                                {
                                    if (!PreyIsInSafePosition(Instance.Preys[j]))
                                        if (Instance.Preys[j].UnderPredation)
                                            if (Instance.Preys[j].Predator.Name == Instance.Predators[i].Name)
                                                SimulationPreySlayedStatus(Instance.Predators[i], Instance.Preys[j]);
                                }
                                else
                                {
                                    if (!PreyIsInSafePosition(Instance.Preys[j]))
                                        if(!Instance.Preys[j].UnderPredation)
                                            SimulationPredatorFoundPrey(Instance.Predators[i], Instance.Preys[j]);
                                }
                            }
                        }

                    }

                    RepaintScenario();
                }
            }

            Instance.SoundPlayer.Stop();

            return Survivor;
        }

        private bool PreyIsInSafePosition(Prey prey)
        {
            double distance = ToolFunction.Distance(prey.Location, prey.CurrentVertex.GetCirclePoint());

            // Multiplied by three for the incresed size of the shield
            if (distance <= (prey.CurrentVertex.Circle.Radius * 3))
                return true;

            return false;
        }
        private bool AllPreysFinish()
        {
            foreach (Prey p in Instance.Preys)
                if (p.Iteration != 0)
                    return false;

            return true;
        }

        private bool CompletedSimulation()
        {
            if (Instance.Preys.Count == 0)
            {
                Survivor = null;
                return true;
            }

            foreach (Prey p in Instance.Preys)
            {
                if (p.CurrentVertex.ID == ((Vertex)Instance.ComboBox_Target.SelectedItem).ID)
                {
                    Survivor = p;
                    return true;
                }
            }
               
            return false;
        }

        private void SimulationRunningStatus()
        {
            ILastStatus = "Running";

            Instance.PictureBox_State.Image = IStateImages["Running"];

            Instance.Label_StateMessage.Text = "La cacería comenzo, ¿quién lograra salir vivo?";
            Instance.Label_StateMessage.Location = new Point(IPanelMiddle.X - Instance.Label_StateMessage.Width / 2, Instance.Label_StateMessage.Location.Y);

            Instance.Refresh();
        }

        public void SimulationEndStatus(Prey prey)
        {
            if (prey != null)
            {
                if (Instance.CheckBox_Music.Checked)
                {
                    Instance.SoundPlayer.SoundLocation = Instance.SoundtrackPath["End-Win"];
                    Instance.SoundPlayer.Play();
                }

                Instance.PictureBox_State.Image = IStateImages["End"];

                Instance.Label_StateMessage.Text = prey.Name + " logro escapar en una pieza";
                Instance.Label_StateMessage.Location = new Point(IPanelMiddle.X - Instance.Label_StateMessage.Width / 2, Instance.Label_StateMessage.Location.Y);

                Instance.Label_TotalPredators.Text = "Total de depredadores: " + Instance.Predators.Count;

                if (GetBestPredator() != null)
                    Instance.Label_BestPredator.Text = "Mejor Cazador: " + GetBestPredator().Name;

                foreach (Predator p in Instance.Predators)
                {
                    if (p.Prey != null)
                    {
                        if (p.Prey.Name == prey.Name)
                        {
                            p.Prey = null;
                            p.Hunting = false;
                        }
                    }
                }

                int survivorPosition = 0;

                for (int i = 0; i < Instance.Preys.Count; ++i)
                {
                    if (Instance.Preys[i].Name == prey.Name)
                        survivorPosition = i;
                    else
                        Instance.Preys[i].GiveSurvivancePerk();
                }

                Instance.Preys.RemoveAt(survivorPosition);

                Instance.Label_TotalPreys.Text = "Total de presas: " + Instance.Preys.Count;
            }
            else
            {
                if (Instance.CheckBox_Music.Checked)
                {
                    Instance.SoundPlayer.SoundLocation = Instance.SoundtrackPath["End-Lose"];
                    Instance.SoundPlayer.Play();
                }

                Instance.PictureBox_State.Image = IStateImages["End"];

                Instance.Label_StateMessage.Text = "No queda presa viva, los depredadores ganan";
                Instance.Label_StateMessage.Location = new Point(IPanelMiddle.X - Instance.Label_StateMessage.Width / 2, Instance.Label_StateMessage.Location.Y);

                Instance.Label_TotalPredators.Text = "Total de depredadores: " + Instance.Predators.Count;
                Instance.Label_TotalPreys.Text = "Total de presas: " + Instance.Preys.Count;

                if (GetBestPredator() != null)
                    Instance.Label_BestPredator.Text = "Mejor Cazador: " + GetBestPredator().Name;
            }

            ILastStatus = "End";
            RepaintScenario();
        }

        private void SimulationPredatorFoundPrey(Predator predator, Prey prey)
        {
            predator.Prey = prey;
            prey.UpdatePredator(predator);

            if (prey.CharacterClass == predator.CharacterClass)
                prey.WeakAgainstPredator();

            Instance.PictureBox_State.Image = IStateImages["Target"];

            Instance.Label_StateMessage.Text = "¡" + prey.Name + " se encuentra bajo la mira de " + predator.Name + "!";
            Instance.Label_StateMessage.Location = new Point(IPanelMiddle.X - Instance.Label_StateMessage.Width / 2, Instance.Label_StateMessage.Location.Y);

            Instance.Refresh();
            
            if (ILastStatus != "PreyFound")
                Thread.Sleep(2000);

            RepaintScenario();
            ILastStatus = "PreyFound";
        }

        private void SimulationPreySlayedStatus(Predator predator, Prey prey)
        {
            if (Instance.CheckBox_Music.Checked)
            {
                Instance.SoundPlayer.SoundLocation = Instance.SoundtrackPath["PreySlain"];
                Instance.SoundPlayer.Play();
                Instance.SoundPlayer.SoundLocation = Instance.SoundtrackPath["Running"];
                Instance.SoundPlayer.PlayLooping();
            }

            Instance.PictureBox_State.Image = IStateImages["Death"];

            Instance.Label_StateMessage.Text = GetPreySlayedMessage(predator);
            Instance.Label_StateMessage.Location = new Point(IPanelMiddle.X - Instance.Label_StateMessage.Width / 2, Instance.Label_StateMessage.Location.Y);

            Instance.Label_TotalPredators.Text = "Total de depredadores: " + Instance.Predators.Count;
            Instance.Label_TotalPreys.Text = "Total de presas: " + Instance.Preys.Count;

            if (GetBestPredator() != null)
                Instance.Label_BestPredator.Text = "Mejor Cazador: " + GetBestPredator().Name;

            if (!IFirstBloodOcurred)
            {
                Instance.Label_FirstBlood.Text = "Primera sangre: " + predator.Name;
                IFirstBloodOcurred = true;
            }

            Graphics.FromImage(ITemporalFrame).FillEllipse(new SolidBrush(predator.Color), prey.Location.X - 50, prey.Location.Y - 50, 100, 100);
            Instance.PictureBox_Graph.Image = ITemporalFrame;

            Instance.Refresh();
            Thread.Sleep(4000);
            Instance.Refresh();

            RepaintScenario();

            for (int i = 0; i < Instance.Preys.Count; ++i)
            {
                if (Instance.Preys[i].Name == prey.Name)
                {
                    Instance.Preys.RemoveAt(i);
                    break;
                }
            }

            predator.Prey = null;
            predator.Hunting = false;
            ++predator.HuntedPreys;
            predator.GiveKillPerk();
        }

        private Predator GetBestPredator()
        {
            if (Instance.Predators.Count > 0)
            {
                List<Predator> tempPredators = Instance.Predators.ToList();
                tempPredators.OrderBy(predator => predator.HuntedPreys);

                if (tempPredators.Last().HuntedPreys > 0)
                    return tempPredators.Last();
                else
                    return null;
            }

            return null;
        }

        private string GetPreySlayedMessage(Predator predator)
        {
            if (!IFirstBloodOcurred)
                return "¡" + predator.Name + " se apunto la primera sangre!";
            else if (predator.HuntedPreys > 0)
                return predator.Name + " esta en racha ¡Esta imparable!";
            else
                return "¡Anotenle uno a la cuenta de " + predator.Name + "!";
        }

        private void SimulationInitialStatus()
        {
            ILastStatus = "Initial";

            Instance.PictureBox_State.Image = IStateImages["Initial"];

            Instance.Label_StateMessage.Text = "Simulación en espera ...";
            Instance.Label_StateMessage.Location = new Point(IPanelMiddle.X - Instance.Label_StateMessage.Width / 2, Instance.Label_StateMessage.Location.Y);

            Instance.Label_TotalPredators.Text = "Total de depredadores: " + Instance.Predators.Count;
            Instance.Label_TotalPreys.Text = "Total de presas: " + Instance.Preys.Count;
            Instance.Label_BestPredator.Text = "Mejor Cazador: ";
            Instance.Label_FirstBlood.Text = "Primera sangre: ";

            Bitmap temporalGraphImage = new Bitmap(Instance.GraphBitmap);

            foreach (Prey p in Instance.Preys)
                Graphics.FromImage(temporalGraphImage).DrawImage(p.Picture, p.Location.X - p.Picture.Width / 2, p.Location.Y - p.Picture.Height / 2);

            foreach (Predator p in Instance.Predators)
                Graphics.FromImage(temporalGraphImage).DrawImage(p.Picture, p.Location.X - p.Picture.Width / 2, p.Location.Y - p.Picture.Height / 2);

            Instance.PictureBox_Graph.Image = temporalGraphImage;

            Instance.Refresh();
        }

        private void RepaintScenario()
        {
            ITemporalFrame = new Bitmap(Instance.GraphBitmap);

            foreach (Prey p in Instance.Preys)
            {
                Graphics.FromImage(ITemporalFrame).DrawImage(p.Picture, p.Location.X - (p.Picture.Width / 2), p.Location.Y - (p.Picture.Height / 2));

                if (p.UnderPredation)
                    Graphics.FromImage(ITemporalFrame).DrawLine(new Pen(Color.Firebrick, 6), p.Location, p.Predator.Location);
            }

            foreach (Predator p in Instance.Predators)
                Graphics.FromImage(ITemporalFrame).DrawImage(p.Picture, p.Location.X - (p.Picture.Width / 2), p.Location.Y - (p.Picture.Height / 2));

            Instance.PictureBox_Graph.Image = ITemporalFrame;

            Instance.Refresh();
        }

    }
}
