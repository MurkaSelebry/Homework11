using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipographWPF
{
    class Person
    {
        public string SecondName { get { return "Ivanov"; } }
        public override string ToString()
        {
            return "User Person";
        }
    }
}
