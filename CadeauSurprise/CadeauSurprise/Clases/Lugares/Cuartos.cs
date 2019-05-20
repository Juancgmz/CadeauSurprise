using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadeauSurprise.Clases
{
    abstract class Cuartos
    {
        public static Form1 FormaCuartos = Application.OpenForms.OfType<Form1>().FirstOrDefault();

    }
}
