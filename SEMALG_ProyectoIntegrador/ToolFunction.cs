using System;
using System.Collections.Generic;
using System.Drawing;

namespace SEMALG_ProyectoIntegrador
{
    public static class ToolFunction
    {
        readonly public static double INFINITE = Double.MaxValue;

        public static double Distance(Point A, Point B)
        {
            return Math.Abs(Math.Sqrt((double)(Math.Pow((double)(B.X - A.X), 2) + Math.Pow((double)(B.Y - A.Y), 2))));
        }

        public static Stack<Edge> ConvertToEdgeStack(List<Vertex> list, Graph graph)
        {
            List<Edge> newList = new List<Edge>();

            for (int i = 0; i < list.Count - 1; ++i)
            {
                foreach (Vertex v in graph.VertexList)
                {
                    if (v.ID == list[i].ID)
                    {
                        foreach (Edge e in v.GetEdges())
                        {
                            if (e.Destination.ID == list[i + 1].ID)
                            {
                                newList.Add(e);
                                break;
                            }
                        }

                        break;
                    }
                }
            }

            newList.Reverse();

            return new Stack<Edge>(newList);
        }
    }
}
