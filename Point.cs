using System;
using System.Collections.Generic;
using System.Text;

namespace geometrie
{
    class Point
    {
        private double x, y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public Point(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }
        

        public int distance(Point origin)
        {
           double x1= origin.x;
            double y1 = origin.y;
            double distance = Math.Sqrt(Math.Pow(x-x1,2)-Math.Pow(y-y1,2));
            return (int) distance;
        }

        public int alignement(Point origin)
        {
            double x1 = origin.x ,x2=origin.x;
            double y1 = origin.y , y2=origin.y;

            double resultat =( (x1 - x) * (y2 - y) - (y1 - y) * (x2 - x));
            if (resultat == 0)
            {
                return 1;
            }
            else
            {

            return 1;
            }
        }



    }

    class droite
    {
        private Point A,B;
        public Point A_
        {
            get { return A_; }
            set { A_ = value; }
        }

        public Point B_
        {
            get { return B_; }
            set { B_ = value; }
        }
        public droite(Point A,Point B)
        {
            this.A_ = A;
            this.B_ = B;
        }
       

        public int distance(Point origin)
        {
            double distance = Math.Sqrt(Math.Pow(A.X-B.X,2) - Math.Pow(A.Y-B.Y,2));
            return (int) distance;
        }

        public int intersection(Point origin)
        {
            double x1 = origin.X, x2 = origin.X;
            double y1 = origin.Y, y2 = origin.Y;
            double pente1 = (B.Y - A.Y) / (B.X - A.X);
            double pente2 = (y2 - y1) / (x2 - x1);
            if (pente1!=pente2)
            {
                return 1;

            }
            else
            {
                return 0;
            }

            

        }
        public int appartenance(Point origin)
        {
            double x1 = origin.X;
            double y1 = origin.Y;
            double resultat = (B.X - A.X) * (y1-A.Y) - (B.Y-A.Y) * (x1-A.X);
            if (resultat == 0)
            {
                return 1;
            }
            else {
                return 0;
            }


           
        }

        public int perpendicularité(Point origin)
        {
            double x1 = origin.X ,x2=origin.X;
            double y1 = origin.Y, y2 = origin.Y;
            double pente1 = (B.Y - A.Y) / (B.X - A.X);
            double pente2 = (y2 - y1) / (x2 - x1);
            if (pente1*pente2==-1)        //le produit du coefficient directeurs a*a1
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }

        public int parallelisme(Point origin)
        {
            double x1 = origin.X, x2 = origin.X;
            double y1 = origin.Y, y2 = origin.Y;
            double pente1 = (B.Y - A.Y) / (B.X - A.X);
            double pente2 = (y2 - y1) / (x2 - x1);
            if (pente1 == pente2)        //les deux pentes sont paralléles
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

    class Circle
    {
        class Cercle
        {
            private Point centre;
            private double rayon;

            public double Rayon
            {
                get { return rayon; }
                set { rayon = value; }
            }

            public Point Centre
            {
                get { return centre; }
                set { centre = value; }
            }

            public Cercle(Point centre, double rayon = 0)
            {
                this.centre = centre;
                this.rayon = rayon;
            }

           

            public double Perimetre()
            {
                return 2 * Math.PI * rayon;
            }
            public double Surface()
            {
                return Math.PI * rayon * rayon;
            }

            public int appartenance(Point origin)
            {
                double x1 = origin.X;
                double y1 = origin.Y;
                double distance = Math.Sqrt(Math.Pow(centre.X-x1,2) - Math.Pow(centre.Y-y1,2));
                if (distance <= rayon)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }


        }
    }
}
