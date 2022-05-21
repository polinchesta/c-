using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job2
{
    internal class Accountant
    { 
        public bool AskForBonus(positions pos, int hours)
        {
            if (hours > (int)pos) return true;
            else return false;
        }
    }
}

