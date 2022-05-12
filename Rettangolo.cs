using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace csharp_geometria
{
    internal class Rettangolo
    {
        private double iBaseRettangolo;
        private double iAltezzaRettangolo;
        public Rettangolo(double baseRet, double altezzaRet)
        {
            iBaseRettangolo = baseRet;
            iAltezzaRettangolo = altezzaRet;
        }
        public double CalcolaPerimetro()
        {
            return (iBaseRettangolo + iAltezzaRettangolo) * 2;
        }
        public double CalcolaArea()
        {
            return iBaseRettangolo * iAltezzaRettangolo;
        }
    }
}
