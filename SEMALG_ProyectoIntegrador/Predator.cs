using System.Collections.Generic;
using System.Drawing;
namespace SEMALG_ProyectoIntegrador
{
    public class Predator
    {
        Bitmap IPicture;
        Prey IPrey;
        bool IHunting;
        string IName;
        Vertex ICurrentVertex;
        int ISpeed;
        int ICollitionRange;
        int IHuntingPerimeter;
        byte ICharacterClass;
        Color IColor;
        byte IHuntedPreys;
        Point ILocation;
        int IIteration;
        List<Edge> IVisitedEdges;

        public Predator(Bitmap picture, string name, Vertex start, byte character)
        {
            this.IName = name;
            this.ICurrentVertex = start;
            this.ICharacterClass = character;
            this.IPicture = FormatPicture(picture);
            this.IHuntedPreys = 0;
            this.ISpeed = 15;
            this.CollitionRange = 80;
            this.IHuntingPerimeter = 150;
            this.IHunting = false;
            this.IVisitedEdges = new List<Edge>();
            this.Location = ICurrentVertex.GetCirclePoint();
        }

        private Bitmap FormatPicture(Bitmap picture)
        {
            Bitmap bmp = new Bitmap(300, 300);

            if (ICharacterClass == 0)
            {
                this.IColor = Color.FromArgb(100, 255, 150, 0);
                Graphics.FromImage(bmp).FillEllipse(new SolidBrush(IColor), 0, 0, 300, 300);
            }
            else if (ICharacterClass == 1)
            {
                this.IColor = Color.FromArgb(100, 150, 0, 255);
                Graphics.FromImage(bmp).FillEllipse(new SolidBrush(IColor), 0, 0, 300, 300);
            }
            else if (ICharacterClass == 2)
            {
                this.IColor = Color.FromArgb(100, 190, 0, 30);
                Graphics.FromImage(bmp).FillEllipse(new SolidBrush(IColor), 0, 0, 300, 300);
            }
            else if (ICharacterClass == 3)
            {
                this.IColor = Color.FromArgb(100, 0, 160, 230);
                Graphics.FromImage(bmp).FillEllipse(new SolidBrush(IColor), 0, 0, 300, 300);
            }

            return bmp;
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

        public Prey Prey
        {
            get { return this.IPrey; }
            set { this.IPrey = value; }
        }

        public bool Hunting
        {
            get { return this.IHunting; }
            set { this.IHunting = value; }
        }

        public int Speed
        {
            get { return this.ISpeed; }
        }

        public int CollitionRange
        {
            get { return this.ICollitionRange; }
            set
            {
                this.ICollitionRange = value;
                Bitmap bmp = new Bitmap("../../../resources/mainwindow/predator/predator-" + this.CharacterClass + ".png");
                Graphics.FromImage(this.IPicture).DrawImage(bmp, (Picture.Width / 2) - ICollitionRange / 2, (Picture.Height / 2) - ICollitionRange / 2, ICollitionRange, ICollitionRange);
            }
        }

        public int HuntingPerimeter
        {
            get { return this.IHuntingPerimeter; }
        }

        public Color Color
        {
            get { return this.IColor; }
        }

        public byte HuntedPreys
        {
            get { return this.IHuntedPreys; }
            set { this.IHuntedPreys = value; }
        }

        public List<Edge> VisitedEdges
        {
            get { return this.IVisitedEdges; }
            set { this.IVisitedEdges = value; }
        }

        public void GiveKillPerk()
        {
            if (ICharacterClass == 0)
            {
                IHuntingPerimeter += 50;

                Bitmap bmp = new Bitmap(IPicture.Width + 50, IPicture.Height + 50);
                Graphics.FromImage(bmp).FillEllipse(new SolidBrush(IColor), 0, 0, bmp.Width, bmp.Height);
                Graphics.FromImage(bmp).DrawImage(IPicture, 25, 25);

                this.IPicture = bmp;

            }
            else if (ICharacterClass == 1)
            {
                IHuntingPerimeter += 30;
                ISpeed += 5;
                CollitionRange += 10;

                Bitmap bmp = new Bitmap(IPicture.Width + 30, IPicture.Height + 30);
                Graphics.FromImage(bmp).FillEllipse(new SolidBrush(IColor), 0, 0, bmp.Width, bmp.Height);
                Graphics.FromImage(bmp).DrawImage(IPicture, 15, 15);

                this.IPicture = bmp;
            }
            else if (ICharacterClass == 2)
            {
                ISpeed *= 2;
            }
            if (ICharacterClass == 3)
            {
                CollitionRange += 30;
            }
        }

        public byte CharacterClass
        {
            get { return this.ICharacterClass; }
        }

        public Point Location
        {
            get { return this.ILocation; }
            set { this.ILocation = value; }
        }

        public int Iteration
        {
            get { return this.IIteration; }
            set { this.IIteration = value; }
        }
    }
}
