using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace SEMALG_ProyectoIntegrador
{
    public partial class MainWindow : Form
    {
        Bitmap IGraphBitmap, TemporalPicture;
        Graph IGraph;
        string ImagePath, ConfigurePhase;
        bool ImageLoaded, GraphCreated, ItemsConfigurated;
        List<Vertex> AvailableVertices;
        List<Prey> IPreys;
        List<Predator> IPredators;
        byte TemporalCharacter;
        SimulationMatch SimulationMatch;
        public SoundPlayer SoundPlayer;
        public Dictionary<string, string> SoundtrackPath;

        public MainWindow()
        {
            InitializeComponent();
            PictureBox_Graph.AllowDrop = true;
            this.ConfigurePhase = "Prey";

            SoundtrackPath = new Dictionary<string, string>
            {
                ["Running"] = "../../../resources/mainwindow/soundtrack/soundtrack-running.wav",
                ["End-Win"] = "../../../resources/mainwindow/soundtrack/soundtrack-end-win.wav",
                ["End-Lose"] = "../../../resources/mainwindow/soundtrack/soundtrack-end-lose.wav"
            };
        }

        public Graph Graph
        {
            get { return this.IGraph; }
        }

        public Bitmap GraphBitmap
        {
            get { return this.IGraphBitmap; }
        }

        public List<Predator> Predators
        {
            get { return this.IPredators; }
            set { this.IPredators = value; }
        }

        public List<Prey> Preys
        {
            get { return this.IPreys; }
            set { this.IPreys = value; }
        }

        private void SetInitialStatus()
        {
            this.ImageLoaded = false;
            this.GraphCreated = false;
            this.ItemsConfigurated = false;
            this.IPreys = new List<Prey>();
            this.IPredators = new List<Predator>();
        }

        private void Button_Load_Click(object sender, EventArgs e)
        {
            try
            {
                Button_Reset_Click(sender, e);

                OpenExplorer.ShowDialog();
                this.ImagePath = OpenExplorer.FileName;
                PictureBox_Graph.Image = new Bitmap(ImagePath);
                PictureBox_Graph.Refresh();
                this.ImageLoaded = true;
            }
            catch
            {
                Notification message = new Notification("Error al intentar abrir archivo.");
                message.ShowDialog();
            }
        }

        private void Button_Graph_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ImageLoaded)
                {
                    Notification message = new Notification("Es necesario cargar una imagen primero.");
                    message.ShowDialog();
                    return;
                }

                ImageProcessing processing = new ImageProcessing(ImagePath);
                processing.ProcessImage();

                if (processing.Status)
                {
                    this.IGraphBitmap = new Bitmap(processing.GraphImage);
                    this.IGraph = processing.Graph;

                    PictureBox_Graph.Image = this.IGraphBitmap;
                    PictureBox_Graph.Refresh();

                    Notification message = new Notification(processing.Message);
                    message.ShowDialog();

                    this.GraphCreated = true;
                    this.AvailableVertices = this.IGraph.VertexList.ToList();
                }
                else
                {
                    Notification message = new Notification(processing.Message);
                    message.ShowDialog();
                }
            }
            catch
            {
                Notification message = new Notification("Error al intentar procesar la imagen.");
                message.ShowDialog();
            }
        }

        private void Button_Configure_Click(object sender, EventArgs e)
        {
            Notification msg;

            if (GraphCreated)
            {
                msg = new Notification("Arrastra una imagen al mapa para añadir.");
                msg.ShowDialog();

                ComboBox_Start.DataSource = this.AvailableVertices;
                Panel_Configuration.Show();
                Panel_Configuration.BringToFront();
            }
            else
            {
                msg = new Notification("Es necesario crear un grafo primero.");
                msg.ShowDialog();
            }
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            Notification msg;

            try
            {
                if (!ItemsConfigurated)
                {
                    msg = new Notification("Las presas y depredadores aún no se definen.");
                    msg.ShowDialog();
                    return;
                }

                SimulationMatch = new SimulationMatch(this);
                SimulationMatch.SetInitialStatus(new Point(Panel_Simulation.Width / 2, 0));
                Panel_Simulation.Show();
                Panel_Simulation.BringToFront();
            }
            catch
            {
                msg = new Notification("Error al intentar recrear la simulación.");
                msg.ShowDialog();
            }
        }

        private void ModifyPanelForPrey()
        {
            Label_PhaseTitle.Text = "Configuración de presas";
            Label_PhaseTitle.Location = new Point((Panel_Configuration.Width / 2) - Label_PhaseTitle.Width / 2, Label_PhaseTitle.Location.Y);

            PictureBox_Item0.Image = new Bitmap("../../../resources/mainwindow/prey/prey-0.png");
            PictureBox_Item1.Image = new Bitmap("../../../resources/mainwindow/prey/prey-1.png");
            PictureBox_Item2.Image = new Bitmap("../../../resources/mainwindow/prey/prey-2.png");
            PictureBox_Item3.Image = new Bitmap("../../../resources/mainwindow/prey/prey-3.png");

            Button_Next.Text = "Siguiente";
        }

        private void ModifyPanelForPredator()
        {
            Label_PhaseTitle.Text = "Configuración de depredadores";
            Label_PhaseTitle.Location = new Point((Panel_Configuration.Width / 2) - Label_PhaseTitle.Width / 2, Label_PhaseTitle.Location.Y);

            PictureBox_Item0.Image = new Bitmap("../../../resources/mainwindow/predator/predator-0.png");
            PictureBox_Item1.Image = new Bitmap("../../../resources/mainwindow/predator/predator-1.png");
            PictureBox_Item2.Image = new Bitmap("../../../resources/mainwindow/predator/predator-2.png");
            PictureBox_Item3.Image = new Bitmap("../../../resources/mainwindow/predator/predator-3.png");

            Button_Next.Text = "Terminar";
        }

        private void ShowItemDetailComponents()
        {
            Label_Start.Show();
            Label_Name.Show();
            TextBox_Name.Show();
            ComboBox_Start.Show();
            Button_Save.Show();
        }

        private void HideItemDetailComponents()
        {
            Label_Start.Hide();
            Label_Name.Hide();
            TextBox_Name.Hide();
            ComboBox_Start.Hide();
            Button_Save.Hide();
        }

        private void Button_About_Click(object sender, EventArgs e)
        {
            try
            {
                Notification message = new Notification("Para obtener información del uso de la aplicación:", true);
                message.ShowDialog();
            }
            catch
            {
                Notification message = new Notification("Error al intentar abrir la documentación.");
                message.ShowDialog();
            }
        }

        private void PictureBox_Graph_DragDrop(object sender, DragEventArgs e)
        {
            this.TemporalPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            ShowItemDetailComponents();
        }

        private void PictureBox_Graph_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }
        private void CreatePrey()
        {
            Notification msg;

            if (TextBox_Name.Text != "")
            {
                string name = TextBox_Name.Text;

                foreach (Prey p in IPreys)
                {
                    if (p.Name == name)
                    {
                        msg = new Notification("Nombre ocupado.");
                        msg.ShowDialog();
                        return;
                    }
                }

                foreach (Predator p in IPredators)
                {
                    if (p.Name == name)
                    {
                        msg = new Notification("Nombre ocupado.");
                        msg.ShowDialog();
                        return;
                    }
                }

                IPreys.Add(new Prey(TemporalPicture, name, (Vertex)ComboBox_Start.SelectedItem, TemporalCharacter)); ;
                AvailableVertices.RemoveAt(ComboBox_Start.SelectedIndex);
                msg = new Notification("Presa creada exitosamente.");
                msg.ShowDialog();
                TextBox_Name.ResetText();
                HideItemDetailComponents();
            }
            else
            {
                msg = new Notification("El campo Nombre es obligatorio.");
                msg.ShowDialog();
            }
        }

        private void CreatePredator()
        {
            Notification msg;

            if (TextBox_Name.Text != "")
            {
                string name = TextBox_Name.Text;

                foreach (Predator p in IPredators)
                {
                    if (p.Name == name)
                    {
                        msg = new Notification("Nombre ocupado.");
                        msg.ShowDialog();
                        return;
                    }
                }

                foreach (Prey p in IPreys)
                {
                    if (p.Name == name)
                    {
                        msg = new Notification("Nombre ocupado.");
                        msg.ShowDialog();
                        return;
                    }
                }

                IPredators.Add(new Predator(TemporalPicture, name, (Vertex)ComboBox_Start.SelectedItem, TemporalCharacter));
                AvailableVertices.RemoveAt(ComboBox_Start.SelectedIndex);

                msg = new Notification("Depredador creado exitosamente.");
                msg.ShowDialog();
                TextBox_Name.ResetText();
                HideItemDetailComponents();
            }
            else
            {
                msg = new Notification("El campo Nombre es obligatorio.");
                msg.ShowDialog();
            }
        }

        private void Button_StartSimulation_Click(object sender, EventArgs e)
        {
            Prey survivor;
            SoundPlayer = new SoundPlayer();

            if (IPreys.Count > 0)
            {
                survivor = SimulationMatch.ExecuteSimulation();
                SimulationMatch.SimulationEndStatus(survivor);
            }
            else
            {
                Notification msg = new Notification("No existen suficientes presas.");
                msg.ShowDialog();
            }

            AvailableVertices = new List<Vertex>(IGraph.VertexList);

            for (int i = 0; i < IPreys.Count; i++)
                AvailableVertices.Remove(IPreys[i].CurrentVertex);
            for (int i = 0; i < IPredators.Count; i++)
                AvailableVertices.Remove(IPredators[i].CurrentVertex);
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (ConfigurePhase == "Prey")
            {
                this.ConfigurePhase = "Predator";
                ModifyPanelForPredator();
            }
            else if (ConfigurePhase == "Predator")
            {
                this.ConfigurePhase = "Prey";
                ModifyPanelForPrey();

                HideItemDetailComponents();
                Panel_Configuration.Hide();
                Panel_Simulation.Hide();

                Notification msg = new Notification("Presas y depredadores definidos correctamente.");
                msg.ShowDialog();

                this.ItemsConfigurated = true;
            }
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            Panel_Configuration.Hide();
            Panel_Simulation.Hide();
            ModifyPanelForPrey();
            HideItemDetailComponents();
            SetInitialStatus();
            PictureBox_Graph.Image = new Bitmap(1300, 1000);
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (ConfigurePhase == "Prey")
                CreatePrey();
            else if (ConfigurePhase == "Predator")
                CreatePredator();

            ComboBox_Start.DataSource = new List<Vertex>();
            ComboBox_Start.DataSource = this.AvailableVertices;

            if (AvailableVertices.Count > 0)
                ComboBox_Start.SelectedIndex = 0;

            if (Button_Next.Visible == false)
                Button_Next.Show();
        }

        private void PictureBox_Item0_Click(object sender, EventArgs e) 
        {
            this.TemporalCharacter = 0;
            this.TemporalPicture = new Bitmap(PictureBox_Item0.Image);
            ShowItemDetailComponents();
        }

        private void PictureBox_Item1_Click(object sender, EventArgs e)
        {
            this.TemporalCharacter = 1;
            this.TemporalPicture = new Bitmap(PictureBox_Item1.Image);
            ShowItemDetailComponents();
        }

        private void PictureBox_Item2_Click(object sender, EventArgs e)
        {
            this.TemporalCharacter = 2;
            this.TemporalPicture = new Bitmap(PictureBox_Item2.Image);
            ShowItemDetailComponents();
        }

        private void PictureBox_Item3_Click(object sender, EventArgs e)
        {
            this.TemporalCharacter = 3;
            this.TemporalPicture = new Bitmap(PictureBox_Item3.Image);
            ShowItemDetailComponents();
        }

        private void PictureBox_Item1_MouseHover(object sender, EventArgs e)
        {
            if (ConfigurePhase == "Predator")
            {
                ToolTip toolTip = new ToolTip { IsBalloon = true };
                toolTip.SetToolTip(this.PictureBox_Item1, "John Wick: Aumenta un poco todas sus estadísticas \nbase al matar a su presa.");
            }
        }

        private void PictureBox_Item0_MouseHover(object sender, EventArgs e)
        {
            if (ConfigurePhase == "Predator")
            {
                ToolTip toolTip = new ToolTip { IsBalloon = true };
                toolTip.SetToolTip(this.PictureBox_Item0, "Geralt de Rivia: Incrementa su perímetro de caza al acumular \nuna presa en su marcador.");
            }
        }

        private void PictureBox_Item2_MouseHover(object sender, EventArgs e)
        {
            if (ConfigurePhase == "Predator")
            {
                ToolTip toolTip = new ToolTip { IsBalloon = true };
                toolTip.SetToolTip(this.PictureBox_Item2, "Sekiro: Duplica su velocidad \nactual al cazar a una presa.");
            }
        }

        private void PictureBox_Item3_MouseHover(object sender, EventArgs e)
        {
            if (ConfigurePhase == "Predator")
            {
                ToolTip toolTip = new ToolTip { IsBalloon = true };
                toolTip.SetToolTip(this.PictureBox_Item3, "Eivor: Aumenta su rango de \ncolisión al acabar con una presa.");
            }
        }

        private void CheckBox_Music_CheckedChanged(object sender, EventArgs e)
        {
            if (!CheckBox_Music.Checked)
                SoundPlayer.Stop();
        }

        private void PictureBox_Item0_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox_Item0.DoDragDrop(PictureBox_Item0.Image, DragDropEffects.Copy);
                TemporalCharacter = 0;
            }
        }

        private void PictureBox_Item3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox_Item3.DoDragDrop(PictureBox_Item3.Image, DragDropEffects.Copy);
                TemporalCharacter = 3;
            }
        }

        private void PictureBox_Item2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox_Item2.DoDragDrop(PictureBox_Item2.Image, DragDropEffects.Copy);
                TemporalCharacter = 2;
            }
        }

        private void PictureBox_Item1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox_Item1.DoDragDrop(PictureBox_Item1.Image, DragDropEffects.Copy);
                TemporalCharacter = 1;
            }
        }
    }
}
