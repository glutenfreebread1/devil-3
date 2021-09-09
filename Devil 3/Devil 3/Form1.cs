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
    public partial class Form1 : Form
    {
        Thread CharacterCreate;
        Thread CharacterLoad;
        Thread Settings;
        Thread Help;
        
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void createcharacter(object sender, EventArgs e)
        {
            this.Close();
            CharacterCreate = new Thread(CharacterCreateForm);
            CharacterCreate.SetApartmentState(ApartmentState.STA);
            CharacterCreate.Start();
        }

        private void loadscreen(object sender, EventArgs e)
        {
            this.Close();
            CharacterLoad = new Thread(CharacterLoadForm);
            CharacterLoad.SetApartmentState(ApartmentState.STA);
            CharacterLoad.Start();
        }

        private void settingsscreen(object sender, EventArgs e)
        {
            this.Close();
            Settings = new Thread(SettingsScreenForm);
            Settings.SetApartmentState(ApartmentState.STA);
            Settings.Start();
        }

        private void Helpscreen(object sender, EventArgs e)
        {
            this.Close();
            Help = new Thread(HelpScreenForm);
            Help.SetApartmentState(ApartmentState.STA);
            Help.Start();
        }

        private void CharacterCreateForm()
        {
              Application.Run(new CharacterCreationScreen());  
        }
        private void CharacterLoadForm()
        {
            Application.Run(new CharacterLoadScreen());
        }
        private void SettingsScreenForm()
        {
            Application.Run(new SettingScreen());
        }
        private void HelpScreenForm()
        {
            Application.Run(new HelpScreen());
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
