using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Mesa : Cosas
    {
        static string path = FormaCosas.label56.Text;
        public static void MesaPick()
        {
            FormaCosas.ObjectError();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
