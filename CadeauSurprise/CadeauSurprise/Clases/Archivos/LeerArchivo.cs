using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CadeauSurprise.Clases
{
    class LeerArchivo
    {

        static Form1 Forma = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        static string[] LineasAcertijo = File.ReadAllLines(@"C:\Users\JC\Desktop\Cadeau Surprise\Riddle.txt");
        static string[] NumerosAcertijo = File.ReadAllLines(@"C:\Users\JC\Desktop\Cadeau Surprise\Acertijo#.txt");

        public static void LecturaAcertijos(int i)
        {
            Forma.NumeroAcertijo.Text = NumerosAcertijo[i-1];
            Forma.ContenidoAcertijo.Text = LineasAcertijo[i-1];
        }

    }
}
