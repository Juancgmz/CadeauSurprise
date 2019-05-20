using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeauSurprise.Clases
{
    class Baño : Cuartos
    {
        static string path = FormaCuartos.label73.Text;
        public static void BañoCorrecto()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.Stage6.Hide();
            FormaCuartos.BañoPanel.Show();
            EscribirArchivo.PlayerPath(path);
        }
        public static void BañoInCorrecto()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.CuartoEquivocado();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
