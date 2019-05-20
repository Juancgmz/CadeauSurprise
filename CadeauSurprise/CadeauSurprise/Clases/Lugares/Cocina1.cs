using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadeauSurprise.Clases
{
    class Cocina1 : Cuartos
    {

        public static void CocinaCorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.Stage2.Hide();
            FormaCuartos.CocinaPanel1.Show();
        }
        public static void CocinaIncorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.CuartoEquivocado();
        }
    }
}
