
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeauSurprise.Clases
{
    class Dormitorio : Cuartos
    {
        static string path = FormaCuartos.label70.Text;
        public static void DormitorioCorrecta()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.Stage5.Hide();
            FormaCuartos.DormitorioPanel.Show();
            EscribirArchivo.PlayerPath(path);
        }
        public static void DormitorioIncorrecto()
        {
            FormaCuartos.LoseRoomeLife();
            FormaCuartos.CuartoEquivocado();
            EscribirArchivo.PlayerPath(path);
        }
    }
}
