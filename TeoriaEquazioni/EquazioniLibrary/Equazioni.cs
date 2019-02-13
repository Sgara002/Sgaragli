using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool ris = true;
            if (a == 0)
            {
                ris = false;
            }
            return ris;

        }

        public static bool IsInconsisted(double a, double b)
        {
            bool ris = true;
            if (a != 0 || b != 0)
            {
                ris = false;
            }
            return ris;

        }

        public static bool IsDegree2(double a)
        {
            bool ris = true;
            if (a == 0)
            {
                ris = false;
            }
            return ris;

        }
    }
}
