using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Devil_3
{
    public partial class SettingScreen : Form
    {
        Thread Form1;
        Thread Controlsa;
        public SettingScreen()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 = new Thread(Form1Form);
            Form1.SetApartmentState(ApartmentState.STA);
            Form1.Start();
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Controlsa = new Thread(ControlsForm);
            Controlsa.SetApartmentState(ApartmentState.STA);
            Controlsa.Start();
        }
        private void Form1Form()
        {
            Application.Run(new Form1());
        }
        private void ControlsForm()
        {
            Application.Run(new Controls());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Volume1 = textBox1.Text;
            int anbd = Convert.ToInt32(Volume1);
            if (anbd < 100 && anbd >= 0) 
            {
                using (StreamWriter Volume = File.AppendText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Volume.txt"))
                {
                    System.IO.File.WriteAllText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Volume.txt", "");
                    Volume.WriteLine(anbd);
                    Volume.Close();
                }
            }
        }
    }
}
