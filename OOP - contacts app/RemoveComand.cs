using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class RemoveComand : Command
    {
        Contact deletedComand;

        public RemoveComand(Contact cmd)
        {
            deletedComand = cmd;
        }
        public override void execute()
        {
            SQL.Del(deletedComand.id);
        }

        public override void undo()
        {
            SQL.Add(deletedComand.id,
                    deletedComand.name,
                    deletedComand.fname,
                    deletedComand.phone,
                    deletedComand.email);
        }
    }
}
