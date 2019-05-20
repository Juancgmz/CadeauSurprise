using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Interfaces;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Secadora : Cosas, Encendido
    {
        static string path = FormaCosas.label34.Text;
        public bool OnOff()
        {
            throw new NotImplementedException();
        }

        public static void SecadoraPick()
        {
            FormaCosas.ObjectError();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
