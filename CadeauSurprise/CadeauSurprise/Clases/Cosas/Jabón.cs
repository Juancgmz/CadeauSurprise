using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Interfaces;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Jabón : Cosas, Burbujas
    {
        static string path = FormaCosas.label36.Text;
        public bool Bubbles()
        {
            throw new NotImplementedException();
        }

        public static void JabónPick()
        {
            FormaCosas.ObjectError();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
