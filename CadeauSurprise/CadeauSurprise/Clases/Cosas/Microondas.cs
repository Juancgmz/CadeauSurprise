using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeauSurprise.Cosas
{
    class Microondas : Cosas
    {
        public static void MicroondasPick()
        {
            FormaCosas.ObjectError();
        }

        internal static void CuchilloPick()
        {
            throw new NotImplementedException();
        }
    }
}
