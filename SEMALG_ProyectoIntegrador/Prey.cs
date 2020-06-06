using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SEMALG_ProyectoIntegrador
{
    public class Prey
    {
        Bitmap IPicture;
        Bitmap IPictureBackUp;
        Stack<Edge> IPath;
        Predator IPredator;
        bool IUnderPredation;
        string IName;
        Vertex ICurrentVertex;
        int ISpeed;
        byte ICharacterClass;
        Point ILocation;
        Point IMaxLocation;
        int IIteration;
        bool IInSafePosition;

        public Prey(Bitmap picture, string name, Vertex start, byte characterClass)
        {
            this.IPicture = FormatPicture(picture);
            this.IName = name;
            this.ICurrentVertex = start;
            this.ISpeed = 10;
            this.IUnderPredation = false;
            this.ICharacterClass = characterClass;
            this.IInSafePosition = true;
            this.ILocation = start.GetCirclePoint();
        }

        private Bitmap FormatPicture(Bitmap picture)
        {
            Bitmap bmp = new Bitmap(100, 100);
            Graphics.FromImage(bmp).DrawImage(picture, 0, 0, 100, 100);

            this.IPictureBackUp = new Bitmap(bmp);

            return bmp;
        }

        public void UpdatePredator(Predator predator = null)
        {
            if (predator == null)
            {
                this.IPredator = null;
                this.IUnderPredation = false;

                this.IPicture = IPictureBackUp;
            }
            else
            {
                this.IPredator = predator;
                this.IUnderPredation = true;

                Bitmap bmp = new Bitmap(150, 150);
                Graphics.FromImage(bmp).FillEllipse(new SolidBrush(predator.Color), 0, 0, 150, 150);
                Graphics.FromImage(bmp).DrawImage(IPicture, 25, 25);

                this.IPicture = bmp;
            }
        }

        public void WeakAgainstPredator()
        {
            ISpeed -= 5;
        }

        public void GiveSurvivancePerk()
        {
            if (ISpeed < 15)
                ISpeed = 10;

            ISpeed += 10;
        }

        public Point GetMaxPoint(Edge edge)
        {
            return edge.Path.Last();
        }

        public string Name
        {
            get { return this.IName; }
        }

        public Bitmap Picture
        {
            get { return this.IPicture; }
        }

        public Vertex CurrentVertex
        {
            get { return this.ICurrentVertex; }
            set { this.ICurrentVertex = value; }
        }

        public Predator Predator
        {
            get { return this.IPredator; }
        }

        public byte CharacterClass
        {
            get { return this.ICharacterClass; }
        }

        public bool UnderPredation
        {
            get { return this.IUnderPredation; }
            set { this.IUnderPredation = value; }
        }

        public Stack<Edge> Path
        {
            get { return this.IPath; }
            set { this.IPath = value; }
        }

        public int Speed
        {
            get { return this.ISpeed; }
            set { this.ISpeed = value; }
        }

        public Point Location
        {
            get { return this.ILocation; }
            set { this.ILocation = value; }
        }

        public Point MaxLocation
        {
            get { return this.IMaxLocation; }
            set { this.IMaxLocation = value; }
        }

        public int Iteration
        {
            get { return this.IIteration; }
            set { this.IIteration = value; }
        }

        public bool InSafePosition
        {
            get { return this.IInSafePosition; }
            set { this.IInSafePosition = value; }
        }

        public override string ToString()
        {
            return this.IName;
        }
    }
}
