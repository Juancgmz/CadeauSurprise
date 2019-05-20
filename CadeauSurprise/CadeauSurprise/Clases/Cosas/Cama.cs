using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Cama : Cosas
    {
        static string path = FormaCosas.label64.Text;
        public static void CamaPick()
        {
            FormaCosas.ObjectError();
            EscribirArchivo.PlayerPath(path);
        }
    }
}