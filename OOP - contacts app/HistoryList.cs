using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class HistoryList
    {
        #region Variabile
        public Command[] cmds = new Command[n];
        public const int n = 20;
        public int count = -1;
        public int cursor = -1;
        #endregion

        public  void Forward()
        {
            if (cursor < n - 1)
                cursor++;
        }

        public  void Back()
        {
            if (cursor != -1)
                cursor--;
        }

        public  bool isLast()
        {
            return cursor == count && count < n;
        }

        public  bool Before()
        {
            return cursor == -1;
        }

        public  void Add(Command cmd)
        {
            if (cursor != count)
            {
                count = cursor;
                AllRight();
                Program.f1.Test();
            }

            cmds[++cursor] = cmd;
            count++;
            
        }

        public void AllRight()
        {
            if(cmds[cursor+1] != null)
                cmds[cursor + 1] = null;   
        }
    }
}
