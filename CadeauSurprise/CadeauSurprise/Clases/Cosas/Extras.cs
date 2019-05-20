using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadeauSurprise.Clases
{
    public abstract class Extras
    {
        public static Form1 FormaExtras = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public void AdquireMoney()
        {

        }

        public void AdquireBook()
        {

        }

    }
}
