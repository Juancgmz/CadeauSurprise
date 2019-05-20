using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Interfaces;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Estufa : Cosas, Encendido
    {
        static string path = FormaCosas.label16.Text;
        public bool OnOff()
        {
            throw new NotImplementedException();
        }

        public static void EstufaPick()
        {
            FormaCosas.ObjectError();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
