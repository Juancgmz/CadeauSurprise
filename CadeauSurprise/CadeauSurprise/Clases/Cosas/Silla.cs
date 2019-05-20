using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Silla : Cosas
    {
        static string path = FormaCosas.label17.Text;
        public static void SillaPick()
        {
            FormaCosas.label20.Show();
            FormaCosas.label21.Show();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
