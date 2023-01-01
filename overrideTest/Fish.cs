using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideTest
{
    internal class Fish : Animal
    {
        public Fish(string kind)
        { 
            this.kind = kind;
        }
        public override string MakeSound(string sound)
        {
            return "魚不會叫";
        }
    }
}
