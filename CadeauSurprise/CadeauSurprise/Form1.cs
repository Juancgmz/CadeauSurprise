using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadeauSurprise.Clases;

namespace CadeauSurprise
{
    public partial class Form1 : Form
    {
        int RoomCounter = 15;
        int BookCounter = 0;
        int MoneyCounter = 0;
        string PlayerName;

        public Form1()
        {
            InitializeComponent();
            var labels = new List<Label> { RoomsN0, RoomsN1, RoomsN2 };
            foreach (var label in labels)
            {
                label.Text = RoomCounter.ToString();
            }
            var labelsD = new List<Label> { Dinero0, Dinero1, Dinero2 };
            foreach (var labelD in labelsD)
            {
                labelD.Text = MoneyCounter.ToString();
            }
            var labelsB = new List<Label> { Libro0, Libros1, Libros2 };
            foreach (var labelB in labelsB)
            {
                labelB.Text = BookCounter.ToString();
            }
        }

        public void LoseRoomeLife()
        {
            RoomCounter -= 1;
            var labels = new List<Label> { RoomsN0, RoomsN1, RoomsN2 };
            foreach (var label in labels)
            {
                label.Text = RoomCounter.ToString();
            }
        }

        public void AdquireMoney(int gift)
        {
            MoneyCounter += gift;
            var labelsD = new List<Label> { Dinero0, Dinero1, Dinero2 };
            foreach (var labelD in labelsD)
            {
                labelD.Text = MoneyCounter.ToString();
            }
        }

        public void AdquireBook()
        {
            BookCounter += 1;
            var labelsB = new List<Label> { Libro0, Libros1, Libros2 };
            foreach (var labelB in labelsB)
            {
                labelB.Text = BookCounter.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainMenu.Hide();
            Stage1.Show();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Stage1.Hide();
            Acertijo.Show();
            LeerArchivo.LecturaAcertijos(1);
            Stage1Timer.Enabled = true;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label2.Font = new Font(label2.Font.Name, label2.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label2.Font = new Font(label2.Font.Name, label2.Font.SizeInPoints, FontStyle.Regular);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Acertijo.Hide();
            Stage2.Show();
            Stage1Timer.Enabled = false;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            CocinaPanel1.Hide();
            Acertijo.Show();
            LeerArchivo.LecturaAcertijos(2);
            Stage2Timer.Enabled = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label20.Show();
            label21.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;
            try
            {
                edad = Convert.ToInt32(textBox2.Text);
                if (edad < 12)
                {
                    MessageBox.Show("Necesitas ser mayor a 12 años para jugar.");
                }
                else
                {
                    label1.Show();
                    PlayerName = textBox1.Text;
                    button1.Hide();
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                }
                    
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, reintroduce tu edad y asegúrate que sean sólo números");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Edad muy grande, intenta de nuevo");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Cocina1.CocinaCorrecta1();
            Stage2.Hide();
            CocinaPanel1.Show();
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label11.Font = new Font(label11.Font.Name, label11.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label11.Font = new Font(label11.Font.Name, label11.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label17.Font = new Font(label17.Font.Name, label17.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label17.Font = new Font(label17.Font.Name, label17.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label16.Font = new Font(label16.Font.Name, label16.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label16.Font = new Font(label16.Font.Name, label16.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label18.Font = new Font(label18.Font.Name, label18.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label18.Font = new Font(label18.Font.Name, label18.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label21.Font = new Font(label21.Font.Name, label21.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label21.Font = new Font(label21.Font.Name, label21.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label12.Font = new Font(label12.Font.Name, label12.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label12.Font = new Font(label12.Font.Name, label12.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label13.Font = new Font(label13.Font.Name, label13.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label13.Font = new Font(label13.Font.Name, label13.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            CuartoEquivocado();
            LoseRoomeLife();
        }

        public static void CuartoEquivocado()
        {
            MessageBox.Show("¡Oops! Cuarto equivocado...");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            CuartoEquivocado();
            LoseRoomeLife();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Oops! Te equivocaste de objeto :( Intenta de nuevo.");
        }

        private void label18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Oops! Te equivocaste de objeto :( Intenta de nuevo.");
        }

        private void Stage2Timer_Tick(object sender, EventArgs e)
        {
            Acertijo.Hide();
            Stage3.Show();
            Stage2Timer.Enabled = false;
        }
    }
}
