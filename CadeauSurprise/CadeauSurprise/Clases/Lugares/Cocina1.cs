using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadeauSurprise.Clases;

namespace CadeauSurprise.Clases
{
    class Cocina1 : Cuartos
    {
        static string path = FormaCuartos.label11.Text;
        public static void CocinaCorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.Stage2.Hide();
            FormaCuartos.CocinaPanel1.Show();
            EscribirArchivo.PlayerPath(path);
        }
        public static void CocinaIncorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.CuartoEquivocado();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
