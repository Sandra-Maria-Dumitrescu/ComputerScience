using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class EditComand : Command
    {
        
        Contact oldContact;
        Contact newContact;

        public EditComand(Contact cmd_old, Contact cmd_new)
        {
            oldContact = cmd_old;
            newContact = cmd_new;
        }
        public override void execute()
        {
            SQL.Edit(newContact.id,
                     newContact.name,
                     newContact.fname,
                     newContact.phone,
                     newContact.email);
        }

        public override void undo()
        {
            SQL.Edit(oldContact.id,
                     oldContact.name,
                     oldContact.fname,
                     oldContact.phone,
                     oldContact.email);
        }
    }
}
