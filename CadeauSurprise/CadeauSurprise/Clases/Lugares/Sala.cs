using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeauSurprise.Clases
{
    class Sala : Cuartos
    {
        public static void SalaCorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.Stage4.Hide();
            FormaCuartos.SalaPanel.Show();
        }
        public static void SalaIncorrecta1()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.CuartoEquivocado();
        }
    }
}
