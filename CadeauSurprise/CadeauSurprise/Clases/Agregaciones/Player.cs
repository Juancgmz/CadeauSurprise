using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadeauSurprise.Clases.Agregaciones
{
    class Player
    {
        static Form1 Forma = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        static public string SetPlayerName()
        {
            string PlayerName;
            Forma.label1.Show();
            PlayerName = Forma.textBox1.Text;
            Forma.label4.Text = "La mamá de " + PlayerName + " le tiene un regalo sorpresa por su cumpleaños.";
            Forma.label6.Text = "Tu misión es ayudar a " + PlayerName + " a encontrar su regalo ya que sólo puedes ir a 10 cuartos, si no, su mamá no le dará su regalo.";
            Forma.button1.Hide();
            Forma.textBox1.Enabled = false;
            Forma.textBox2.Enabled = false;
            return PlayerName;
        }
    }
}
