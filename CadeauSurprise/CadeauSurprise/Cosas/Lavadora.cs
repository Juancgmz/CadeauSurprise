using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadeauSurprise.Interfaces;

namespace CadeauSurprise.Cosas
{
    class Lavadora : Cosas, Encendido
    {
        public bool OnOff()
        {
            throw new NotImplementedException();
        }

        public static void LavadoraPick()
        {
            FormaCosas.label31.Show();
            FormaCosas.label32.Show();
        }
    }
}
