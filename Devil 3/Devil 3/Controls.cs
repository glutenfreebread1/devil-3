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
    public partial class Controls : Form
    {
        Thread back;
        public Controls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            back = new Thread(opennewform);
            back.SetApartmentState(ApartmentState.STA);
            back.Start();
        }

        private void opennewform()
        {
            Application.Run(new SettingScreen());
        }
    }
}
