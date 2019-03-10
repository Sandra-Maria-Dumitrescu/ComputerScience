using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contact
    {
        #region Variabile
        public int id;
        public string name, fname, phone, email;
        #endregion

        public Contact(int id, string name, string fname, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.fname = fname;
            this.phone = phone;
            this.email = email;
        }
    }
}
