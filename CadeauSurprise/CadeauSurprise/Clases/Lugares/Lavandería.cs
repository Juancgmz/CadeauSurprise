using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeauSurprise.Clases
{
    class Lavandería : Cuartos
    {
        static string path = FormaCuartos.label13.Text;
        public static void LavanderíaCorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.Stage3.Hide();
            FormaCuartos.Lavandería.Show();
            EscribirArchivo.PlayerPath(path);
        }
        public static void LavanderíaIncorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.CuartoEquivocado();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
