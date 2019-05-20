using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeauSurprise.Clases
{
    class Sala : Cuartos
    {
        static string path = FormaCuartos.label12.Text;
        public static void SalaCorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.Stage4.Hide();
            FormaCuartos.SalaPanel.Show();
            EscribirArchivo.PlayerPath(path);
        }
        public static void SalaIncorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.CuartoEquivocado();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
