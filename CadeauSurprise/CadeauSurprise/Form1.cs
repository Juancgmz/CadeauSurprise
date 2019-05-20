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
using CadeauSurprise.Cosas;


namespace CadeauSurprise
{
    public partial class Form1 : Form
    {
        int RoomCounter = 10;
        int BookCounter = 0;
        int MoneyCounter = 0;
        string PlayerName;

        public Form1()
        {
            InitializeComponent();
            var labels = new List<Label> { RoomsN0, RoomsN1, RoomsN2, RoomsN4, RoomsN5, RoomsN6, RoomsN7, RoomsN8, RoomsN9, RoomsN10, RoomsN11 };
            foreach (var label in labels)
            {
                label.Text = RoomCounter.ToString();
            }
            var labelsD = new List<Label> { Dinero0, Dinero1, Dinero2, Dinero4, Dinero5, Dinero6, Dinero7, Dinero8, Dinero9, Dinero10, Dinero11 };
            foreach (var labelD in labelsD)
            {
                labelD.Text = MoneyCounter.ToString();
            }
            var labelsB = new List<Label> { Libro0, Libros1, Libros2, Libros4, Libros5, Libros6, Libros7, Libros8, Libros9, Libros10, Libros11 };
            foreach (var labelB in labelsB)
            {
                labelB.Text = BookCounter.ToString();
            }
            
        }

        public void LoseRoomeLife()
        {
            if(RoomCounter == 0)
            {
                GameOver.Show();
            }
            else
            {
                RoomCounter -= 1;
                var labels = new List<Label> { RoomsN0, RoomsN1, RoomsN2, RoomsN4, RoomsN5, RoomsN6, RoomsN7, RoomsN8, RoomsN9, RoomsN10, RoomsN11 };
                foreach (var label in labels)
                {
                    label.Text = RoomCounter.ToString();
                }
            }
        }

        public void AdquireMoney(int gift)
        {
            MoneyCounter += gift;
            var labelsD = new List<Label> { Dinero0, Dinero1, Dinero2, Dinero4, Dinero5, Dinero6, Dinero7, Dinero8, Dinero9, Dinero10, Dinero11 };
            foreach (var labelD in labelsD)
            {
                labelD.Text = MoneyCounter.ToString();
            }
        }

        public void AdquireBook()
        {
            BookCounter += 1;
            var labelsB = new List<Label> { Libro0, Libros1, Libros2, Libros4, Libros5, Libros6, Libros7, Libros8, Libros9, Libros10, Libros11 };
            foreach (var labelB in labelsB)
            {
                labelB.Text = BookCounter.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainMenu.Hide();
            Stage1.Show();
            System.IO.File.WriteAllText(@"C:\Users\JC\Desktop\Cadeau Surprise\PlayerPath.txt", string.Empty);
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
            Cosas.Silla.SillaPick();
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
                    label4.Text = "La mamá de " + PlayerName + " le tiene un regalo sorpresa por su cumpleaños.";
                    label6.Text = "Tu misión es ayudar a " + PlayerName + " a encontrar su regalo ya que sólo puedes ir a 10 cuartos, si no, su mamá no le dará su regalo.";
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
            Clases.Sala.SalaIncorrecta1();
        }

        public void CuartoEquivocado()
        {
            MessageBox.Show("¡Oops! Cuarto equivocado...");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Clases.Lavandería.LavanderíaIncorrecta1();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Cosas.Estufa.EstufaPick();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Cosas.Microondas.MicroondasPick();
        }

        private void Stage2Timer_Tick(object sender, EventArgs e)
        {
            Acertijo.Hide();
            Stage3.Show();
            Stage2Timer.Enabled = false;
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label24.Font = new Font(label24.Font.Name, label24.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label24.Font = new Font(label24.Font.Name, label24.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label24_Click(object sender, EventArgs e)
        {
            Clases.Cocina1.CocinaIncorrecta1();
        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label23.Font = new Font(label23.Font.Name, label23.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label23.Font = new Font(label23.Font.Name, label23.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Clases.Sala.SalaIncorrecta1();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Clases.Lavandería.LavanderíaCorrecta1();
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label14.Font = new Font(label13.Font.Name, label14.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label14.Font = new Font(label14.Font.Name, label14.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label36_Click(object sender, EventArgs e)
        {
            Cosas.Jabón.JabónPick();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            Cosas.Lavadora.LavadoraPick();
        }

        public void ObjectError()
        {
            MessageBox.Show("¡Oops! Te equivocaste de objeto :( Intenta de nuevo.");
        }

        private void label34_Click(object sender, EventArgs e)
        {
            Cosas.Secadora.SecadoraPick();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            Lavandería.Hide();
            Evento1.Show();
        }

        private void label31_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label31.Font = new Font(label31.Font.Name, label31.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label31_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label31.Font = new Font(label31.Font.Name, label31.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label34_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label34.Font = new Font(label34.Font.Name, label34.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label34_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label34.Font = new Font(label34.Font.Name, label34.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label35_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label35.Font = new Font(label35.Font.Name, label35.Font.SizeInPoints, FontStyle.Underline);

        }

        private void label35_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label35.Font = new Font(label35.Font.Name, label35.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label36_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label36.Font = new Font(label36.Font.Name, label36.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label36_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label36.Font = new Font(label36.Font.Name, label36.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label29_Click(object sender, EventArgs e)
        {
            label29.Enabled = false;
            label37.Enabled = false;
            label38.Show();
            label40.Show();
            AdquireMoney(500);
            string path = label29.Text;
            EscribirArchivo.PlayerPath(path);
        }

        private void label37_Click(object sender, EventArgs e)
        {
            label29.Enabled = false;
            label37.Enabled = false;
            label39.Show();
            label40.Show();
            AdquireBook();
            string path = label37.Text;
            EscribirArchivo.PlayerPath(path);
        }

        private void label29_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label29.Font = new Font(label29.Font.Name, label29.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label29_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label29.Font = new Font(label29.Font.Name, label29.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label37_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label37.Font = new Font(label37.Font.Name, label37.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label37_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label37.Font = new Font(label37.Font.Name, label37.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label40_Click(object sender, EventArgs e)
        {
            Evento1.Hide();
            Acertijo.Show();
            LeerArchivo.LecturaAcertijos(3);
            Stage3Timer.Enabled = true;
        }

        private void label40_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label40.Font = new Font(label40.Font.Name, label40.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label40_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label40.Font = new Font(label40.Font.Name, label40.Font.SizeInPoints, FontStyle.Regular);
        }

        private void Stage3Timer_Tick(object sender, EventArgs e)
        {
            Acertijo.Hide();
            Stage4.Show();
            Stage3Timer.Enabled = false;
        }

        private void label46_Click(object sender, EventArgs e)
        {
            Clases.Lavandería.LavanderíaIncorrecta1();
        }

        private void label47_Click(object sender, EventArgs e)
        {
            Clases.Dormitorio.DormitorioIncorrecto();
        }

        private void label48_Click(object sender, EventArgs e)
        {
            Clases.Sala.SalaCorrecta1();
        }

        private void label48_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label48.Font = new Font(label48.Font.Name, label48.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label48_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label48.Font = new Font(label48.Font.Name, label48.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label47_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label47.Font = new Font(label47.Font.Name, label47.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label47_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label47.Font = new Font(label47.Font.Name, label47.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label46_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label46.Font = new Font(label46.Font.Name, label46.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label46_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label46.Font = new Font(label46.Font.Name, label46.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label58_Click(object sender, EventArgs e)
        {
            Cosas.Sillón.SillonPick();
        }

        private void label57_Click(object sender, EventArgs e)
        {
            Cosas.TV.TVPick();
        }

        private void label56_Click(object sender, EventArgs e)
        {
            Cosas.Mesa.MesaPick();
        }

        private void label56_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label56.Font = new Font(label56.Font.Name, label56.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label56_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label56.Font = new Font(label56.Font.Name, label56.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label57_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label57.Font = new Font(label57.Font.Name, label57.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label57_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label57.Font = new Font(label57.Font.Name, label57.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label58_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label58.Font = new Font(label58.Font.Name, label58.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label58_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label58.Font = new Font(label58.Font.Name, label58.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label53_Click(object sender, EventArgs e)
        {
            SalaPanel.Hide();
            Acertijo.Show();
            LeerArchivo.LecturaAcertijos(4);
            Stage4Timer.Enabled = true;
        }

        private void label53_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label53.Font = new Font(label53.Font.Name, label53.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label53_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label53.Font = new Font(label53.Font.Name, label53.Font.SizeInPoints, FontStyle.Regular);
        }

        private void Stage4Timer_Tick(object sender, EventArgs e)
        {
            Acertijo.Hide();
            Stage5.Show();
            Stage4Timer.Enabled = false;
        }

        private void label42_Click(object sender, EventArgs e)
        {
            Clases.Sala.SalaIncorrecta1();
        }

        private void label43_Click(object sender, EventArgs e)
        {
            Clases.Dormitorio.DormitorioCorrecta();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            Clases.Lavandería.LavanderíaIncorrecta1();
        }

        private void label44_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label44.Font = new Font(label44.Font.Name, label44.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label44_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label44.Font = new Font(label44.Font.Name, label44.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label43_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label43.Font = new Font(label43.Font.Name, label43.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label43_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label43.Font = new Font(label43.Font.Name, label43.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label42_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label42.Font = new Font(label42.Font.Name, label42.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label42_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label42.Font = new Font(label42.Font.Name, label42.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label51_Click(object sender, EventArgs e)
        {
            label61.Show();
            label63.Show();
            AdquireBook();
            label51.Enabled = false;
            label59.Enabled = false;
            string path = label51.Text;
            EscribirArchivo.PlayerPath(path);
        }

        private void label59_Click(object sender, EventArgs e)
        {
            label62.Show();
            label63.Show();
            AdquireMoney(100);
            label51.Enabled = false;
            label59.Enabled = false;
            string path = label59.Text;
            EscribirArchivo.PlayerPath(path);
        }

        private void label63_Click(object sender, EventArgs e)
        {
            Evento2.Hide();
            Acertijo.Show();
            Clases.LeerArchivo.LecturaAcertijos(5);
            Stage5Timer.Enabled = true;
        }

        private void label51_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label51.Font = new Font(label51.Font.Name, label51.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label51_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label51.Font = new Font(label51.Font.Name, label51.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label59_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label59.Font = new Font(label59.Font.Name, label59.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label59_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label59.Font = new Font(label59.Font.Name, label59.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label63_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label63.Font = new Font(label63.Font.Name, label63.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label63_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label63.Font = new Font(label63.Font.Name, label63.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label68_Click(object sender, EventArgs e)
        {
            DormitorioPanel.Hide();
            Evento2.Show();
        }

        private void label70_Click(object sender, EventArgs e)
        {
            Clases.Dormitorio.DormitorioIncorrecto();
        }

        private void label72_Click(object sender, EventArgs e)
        {
            Clases.Lavandería.LavanderíaIncorrecta1();
        }

        private void label73_Click(object sender, EventArgs e)
        {
            Clases.Baño.BañoCorrecto();
        }

        private void label73_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label73.Font = new Font(label73.Font.Name, label73.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label73_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label73.Font = new Font(label73.Font.Name, label73.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label72_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label72.Font = new Font(label72.Font.Name, label72.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label72_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label72.Font = new Font(label72.Font.Name, label72.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label70_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label70.Font = new Font(label70.Font.Name, label70.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label70_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label70.Font = new Font(label70.Font.Name, label70.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label75_Click(object sender, EventArgs e)
        {
            Cosas.Toalla.ToallaPick();
        }

        private void label76_Click(object sender, EventArgs e)
        {
            Cosas.Regadera.RegaderaPick();
        }

        private void label77_Click(object sender, EventArgs e)
        {
            Cosas.Shampoo.ShampooPick();
        }

        private void label80_Click(object sender, EventArgs e)
        {
            BañoPanel.Hide();
            Victory.Show();
        }

        private void label75_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label75.Font = new Font(label75.Font.Name, label75.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label75_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label75.Font = new Font(label75.Font.Name, label75.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label76_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label76.Font = new Font(label76.Font.Name, label76.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label76_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label76.Font = new Font(label76.Font.Name, label76.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label77_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label77.Font = new Font(label77.Font.Name, label77.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label77_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label77.Font = new Font(label77.Font.Name, label77.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label80_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label80.Font = new Font(label80.Font.Name, label80.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label80_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label80.Font = new Font(label80.Font.Name, label80.Font.SizeInPoints, FontStyle.Regular);
        }

        private void Stage5Timer_Tick(object sender, EventArgs e)
        {
            Acertijo.Hide();
            Stage6.Show();
            Stage5Timer.Enabled = false;
        }

        private void label64_Click(object sender, EventArgs e)
        {
            Cosas.Cama.CamaPick();
        }

        private void label65_Click(object sender, EventArgs e)
        {
            Cosas.Laptop.LaptopPick();
        }

        private void label66_Click(object sender, EventArgs e)
        {
            Cosas.Almohada.AlmohadaPick();
        }

        private void label64_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label64.Font = new Font(label64.Font.Name, label64.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label64_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label64.Font = new Font(label64.Font.Name, label64.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label65_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label65.Font = new Font(label65.Font.Name, label65.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label65_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label65.Font = new Font(label65.Font.Name, label65.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label66_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label66.Font = new Font(label66.Font.Name, label66.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label66_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label66.Font = new Font(label66.Font.Name, label66.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label68_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label68.Font = new Font(label68.Font.Name, label68.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label68_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label68.Font = new Font(label68.Font.Name, label68.Font.SizeInPoints, FontStyle.Regular);
        }
    }
}
