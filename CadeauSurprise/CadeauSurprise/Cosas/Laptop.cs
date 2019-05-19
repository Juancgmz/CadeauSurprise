using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Interfaces;

namespace CadeauSurprise.Cosas
{
    class Laptop : Cosas, Encendido
    {
        public bool OnOff()
        {
            throw new NotImplementedException();
        }

        public static void LaptopPick()
        {
            FormaCosas.ObjectError();
        }
    }
}
