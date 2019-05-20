using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Interfaces;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Laptop : Cosas, Encendido
    {
        static string path = FormaCosas.label65.Text;
        public bool OnOff()
        {
            throw new NotImplementedException();
        }

        public static void LaptopPick()
        {
            FormaCosas.ObjectError();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
