using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public abstract class Command
    {
        public abstract void execute();
        public abstract void undo();
        public virtual void redo()
        {
            execute();
        }
    }
}
