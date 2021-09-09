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

namespace Devil_3
{
    public partial class CharacterLoadScreen : Form
    {
        Thread th;
        public CharacterLoadScreen()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void back(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform()
        {
            Application.Run(new Form1());
        }

       
    }
}
