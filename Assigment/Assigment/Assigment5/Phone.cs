using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment5
{
    abstract class Phone
    {
       public abstract void isertPhone(string name, string phone);
        public abstract void removePhone(string name);
        public abstract void updatePhone(string name, string newphone);
        public abstract void searchPhone(string name);
    }
}
