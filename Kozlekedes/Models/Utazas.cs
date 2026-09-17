using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozlekedes.Models
{
    internal abstract class Utazas
    {
        protected Utazas(int alapDij, int tavolsag)
        {
            AlapDij = alapDij;
            Tavolsag = tavolsag;
        }

        public int AlapDij { get; set; }
        public int Tavolsag { get; set; }


        public abstract int ArSzamitas();
    }
}
