using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozlekedes.Models
{
    internal class ElektromosRoller : Utazas
    {
        public ElektromosRoller(int alapDij, int tavolsag) : base(alapDij, tavolsag)
        {
            alapDij = 0;
        }

        public override int ArSzamitas()
        {
            return (int)(Tavolsag * 120);
        }
    }
}
