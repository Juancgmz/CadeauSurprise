using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Toalla : Cosas
    {
        static string path = FormaCosas.label75.Text;
        public static void ToallaPick()
        {
            FormaCosas.ObjectError();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
