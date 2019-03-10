using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    static class Program
    {
        public static Form1 f1 = new Form1();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(f1);
        }
    }
}
