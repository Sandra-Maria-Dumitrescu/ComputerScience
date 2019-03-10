using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class AddComand : Command
    {
        
        Contact addedContact;
           
        public AddComand(Contact cmd)
        {
            addedContact = cmd;
        }

        public override void execute()
        {
            SQL.Add(addedContact.id,
                    addedContact.name,
                    addedContact.fname,
                    addedContact.phone,
                    addedContact.email);
        }

        public override void undo()
        {
            SQL.Del(addedContact.id);
        }
    }
}
