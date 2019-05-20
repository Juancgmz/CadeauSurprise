using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Interfaces;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Shampoo : Cosas, Burbujas
    {
        static string path = FormaCosas.label77.Text;
        public bool Bubbles()
        {
            throw new NotImplementedException();
        }

        public static void ShampooPick()
        {
            FormaCosas.label80.Show();
            FormaCosas.label81.Show();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
