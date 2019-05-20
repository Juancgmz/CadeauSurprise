
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeauSurprise.Clases
{
    class Dormitorio : Cuartos
    {
        public static void CocinaCorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
          //  FormaCuartos.Stage5.Hide();
          //  FormaCuartos.DormitorioPanel.Show();
        }
        public static void CocinaIncorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.CuartoEquivocado();
        }
    }
}
