using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace APOO_Proiect1
{
    class Circle : Graphic
    {
        PointF a, b;
        PictureBox pb;
        RectangleF r;

        //constructor
        public Circle(PointF a, PointF b, PictureBox pb)
        {
            this.pb = pb;
            this.a = a;
            this.b = b;
        }

        public override void Draw()
        {
            InitiateRectangle();

            Pen myPen;
            myPen = new Pen(Color.Red);
            myPen.Width = 5;

            Graphics formGraphics = pb.CreateGraphics();
            formGraphics.DrawEllipse(myPen, r);

            myPen.Dispose();
            formGraphics.Dispose();
        }

        public override void Move(PointF p)
        {
            float newX = Math.Abs((a.X + b.X) / 2 - p.X);
            float newY = Math.Abs((a.Y + b.Y) / 2 - p.Y);

            if (a.X > p.X && a.Y > p.Y)
            {
                a.X -= newX;
                a.Y -= newY;
                b.X -= newX;
                b.Y -= newY;
            }
            else if (a.X < p.X && a.Y > p.Y)
            {
                a.X += newX;
                a.Y -= newY;
                b.X += newX;
                b.Y -= newY;
            }
            else if (a.X > p.X && a.Y < p.Y)
            {
                a.X -= newX;
                a.Y += newY;
                b.X -= newX;
                b.Y += newY;
            }
            else
            {
                a.X += newX;
                a.Y += newY;
                b.X += newX;
                b.Y += newY;
            }

            Draw();
            throw new NotImplementedException();
        }

        public void InitiateRectangle()
        {
            if (b.X < a.X && b.Y > a.Y) r = new RectangleF(b.X, a.Y, a.X - b.X, b.Y - a.Y);
            else if (b.X > a.X && b.Y < a.Y) r = new RectangleF(a.X, b.Y, b.X - a.X, a.Y - b.Y);
            else if (b.X < a.X && b.Y < a.Y) r = new RectangleF(b.X, b.Y, a.X - b.X, a.Y - b.Y);
            else r = new RectangleF(a.X, a.Y, b.X - a.X, b.Y - a.Y);
        }
    }
}
