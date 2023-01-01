using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideTest
{
    public class Dog : Animal
    {
        public Dog(string kind)
        { 
            this.kind = kind;
        }
    }
}
