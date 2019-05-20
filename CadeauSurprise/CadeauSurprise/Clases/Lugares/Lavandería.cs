using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeauSurprise.Clases
{
    class Lavandería : Cuartos
    {
        public static void LavanderíaCorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.Stage3.Hide();
            FormaCuartos.Lavandería.Show();
        }
        public static void LavanderíaIncorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.CuartoEquivocado();
        }
    }
}
