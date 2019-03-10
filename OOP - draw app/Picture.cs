using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOO_Proiect1
{
    class Picture : Graphic
    {
        List<Graphic> children;

        //Constructor
        public Picture()
        {
            children = new List<Graphic>();
        }

        public override void Draw()
        {
            foreach (Graphic g in children)
            {
                g.Draw();
            }
            throw new NotImplementedException();
        }

        public override void Move(PointF point)
        {
            throw new NotImplementedException();
        }

        public void Add(Graphic g)
        {
            children.Add(g);
        }

        public void Remove(Graphic g)
        {
            children.Remove(g);
        }
    }
}
