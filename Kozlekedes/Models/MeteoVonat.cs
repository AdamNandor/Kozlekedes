using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozlekedes.Models
{
    internal class MeteoVonat : Utazas
    {
        public MeteoVonat(int alapDij, int tavolsag) : base(alapDij, tavolsag)
        {
        }

        public override int ArSzamitas()
        {
            return (2 * AlapDij) + (int)(Tavolsag * 50);
        }
    }
}
