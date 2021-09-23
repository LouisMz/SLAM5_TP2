using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opticien
{
    static class  controlleur
    {
        private static modele vModele;

        public static modele VModele { get => vModele; set => vModele = value; }

        public static void init()
        {
            VModele = new modele();
        }
    }
}
