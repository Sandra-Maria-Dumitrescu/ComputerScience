using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOO_Proiect1
{
    class GraphicTool
    {
        public static List<Graphic> graphics = new List<Graphic>();

        static public void Draw(Graphic g)
        {
            g.Draw();
        }

    }
}
