using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Almohada : Cosas
    {
        static string path = FormaCosas.label66.Text;
        public static void AlmohadaPick()
        {
            FormaCosas.label68.Show();
            FormaCosas.label69.Show();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
