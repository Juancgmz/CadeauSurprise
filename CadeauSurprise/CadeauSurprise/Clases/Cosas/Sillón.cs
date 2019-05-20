using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Sillón : Cosas
    {
        static string path = FormaCosas.label58.Text;
        public static void SillonPick()
        {
            FormaCosas.ObjectError();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
