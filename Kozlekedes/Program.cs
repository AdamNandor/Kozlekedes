using Kozlekedes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozlekedes
{
    internal class Program
    {
        static List<Utazas> napiUtazasok = new List<Utazas>();
        static void Main(string[] args)
        {
            // 2. Feladat: Tömegközlekedési utazási díjak kiszámítása
            napiUtazasok.Add(new Vonalbusz(450, 10));
            napiUtazasok.Add(new MeteoVonat(450, 25));
            napiUtazasok.Add(new ElektromosRoller(0, 4));

            int osszesBevetel = 0;

            foreach (var utazas in napiUtazasok)
            {
                osszesBevetel += utazas.ArSzamitas();
            }

            Console.WriteLine($"A nap teljes bevétele: {osszesBevetel} Ft");
        }
    }
}
