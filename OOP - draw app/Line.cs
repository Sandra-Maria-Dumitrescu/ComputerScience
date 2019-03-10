using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOO_Proiect1
{
    class Line : Graphic
    {
        /// <summary>
        /// declarning variable for start and end point of the line
        /// declaring variable for pictureBox
        /// </summary>
        PointF pointA, pointB;
        PictureBox picBox;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="pointA">Start point of the line</param>
        /// <param name="pointB">End point of the line</param>
        /// <param name="picBox">PictureBox name</param>
        public Line(PointF pointA, PointF pointB, PictureBox picBox)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.picBox = picBox;
        }

        public override void Draw()
        {
            Pen myPen;
            myPen = new Pen(Color.Blue);
            myPen.Width = 3;

            Graphics formGraphics = picBox.CreateGraphics();
            formGraphics.DrawLine(myPen, pointA, pointB);

            myPen.Dispose();
            formGraphics.Dispose();
        }

        public override void Move(PointF point)
        {
        }
    }
}
