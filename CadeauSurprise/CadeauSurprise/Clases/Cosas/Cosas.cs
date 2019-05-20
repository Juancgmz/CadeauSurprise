using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CadeauSurprise.Cosas
{
    abstract class Cosas
    {
        public static Form1 FormaCosas = Application.OpenForms.OfType<Form1>().FirstOrDefault();
    }
}
