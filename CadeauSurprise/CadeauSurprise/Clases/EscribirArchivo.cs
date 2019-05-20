using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeauSurprise.Clases
{
    class EscribirArchivo
    {
        public static void PlayerPath(string text)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\JC\Desktop\Cadeau Surprise\PlayerPath.txt", true))
            {
                file.WriteLine(text);
            }
        }
    }
}
