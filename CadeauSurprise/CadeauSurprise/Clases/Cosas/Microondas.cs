using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Cosas
{
    class Microondas : Cosas
    {
        static string path = FormaCosas.label18.Text;
        public static void MicroondasPick()
        {
            FormaCosas.ObjectError();
            EscribirArchivo.PlayerPath(path);
        }

        internal static void CuchilloPick()
        {
            throw new NotImplementedException();
        }
    }
}
