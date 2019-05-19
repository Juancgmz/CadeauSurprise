using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Interfaces;

namespace CadeauSurprise.Cosas
{
    class Jabón : Cosas, Burbujas
    {
        public bool Bubbles()
        {
            throw new NotImplementedException();
        }

        public static void JabónPick()
        {
            FormaCosas.ObjectError();
        }
    }
}
