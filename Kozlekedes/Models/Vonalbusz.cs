using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozlekedes.Models
{
    internal class Vonalbusz : Utazas
    {
        public Vonalbusz(int alapDij, int tavolsag) : base(alapDij, tavolsag)
        {
        }

        public override int ArSzamitas()
        {
            return AlapDij + (int)(Tavolsag * 30);
        }
    }
}
