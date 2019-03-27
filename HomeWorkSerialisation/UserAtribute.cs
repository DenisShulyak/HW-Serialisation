using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSerialisation
{
    public class UserAtribute : Attribute
    {
        public string Name { get; set; }

        public UserAtribute()
        {
        }
        public UserAtribute(string name)
        {
            Name = name;
        }
    }
}
