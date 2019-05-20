using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeauSurprise.Clases
{
    class Baño : Cuartos
    {
        public static void CocinaCorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
          //  FormaCuartos.Stage6.Hide();
          //  FormaCuartos.BañoPanel.Show();
        }
        public static void CocinaIncorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.CuartoEquivocado();
        }
    }
}
