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
    public partial class CharacterCreationScreen : Form
    {
        Thread th;
        Thread Start;

        public CharacterCreationScreen()
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

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void StartGame(object sender, EventArgs e)
        {
            string Character_Name = toolStripTextBox1.Text;
            string Character_Class = toolStripComboBox1.Text;
            string Save_Slot = toolStripComboBox2.Text;
            if (Save_Slot == "Slot 1")
            {
                using (StreamWriter SaveSlot = File.AppendText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 1.txt"))
                {
                    System.IO.File.WriteAllText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 1.txt", "");
                    SaveSlot.WriteLine(Character_Name);
                    SaveSlot.WriteLine(Character_Class);
                    SaveSlot.Close();
                }
            }
            else if (Save_Slot == "Slot 2")
            {
                using (StreamWriter SaveSlot = File.AppendText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 2.txt"))
                {
                    System.IO.File.WriteAllText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 2.txt", "");
                    SaveSlot.WriteLine(Character_Name);
                    SaveSlot.WriteLine(Character_Class);
                    SaveSlot.Close();
                }
            }
            else if (Save_Slot == "Slot 3")
            {
                using (StreamWriter SaveSlot = File.AppendText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 3.txt"))
                {
                    System.IO.File.WriteAllText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 3.txt", "");
                    SaveSlot.WriteLine(Character_Name);
                    SaveSlot.WriteLine(Character_Class);
                    SaveSlot.Close();
                }
            }
            else if (Save_Slot == "Slot 4")
            {
                using (StreamWriter SaveSlot = File.AppendText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 4.txt"))
                {
                    System.IO.File.WriteAllText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 4.txt", "");
                    SaveSlot.WriteLine(Character_Name);
                    SaveSlot.WriteLine(Character_Class);
                    SaveSlot.Close();
                }
            }
            else if (Save_Slot == "Slot 5")
            {
                using (StreamWriter SaveSlot = File.AppendText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 5.txt"))
                {
                    System.IO.File.WriteAllText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 5.txt", "");
                    SaveSlot.WriteLine(Character_Name);
                    SaveSlot.WriteLine(Character_Class);
                    SaveSlot.Close();
                }
            }
            else if (Save_Slot == "Slot 6")
            {
                using (StreamWriter SaveSlot = File.AppendText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 6.txt"))
                {
                    System.IO.File.WriteAllText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 6.txt", "");
                    SaveSlot.WriteLine(Character_Name);
                    SaveSlot.WriteLine(Character_Class);
                    SaveSlot.Close();
                }
            }
            else if (Save_Slot == "Slot 7")
            {
                using (StreamWriter SaveSlot = File.AppendText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 7.txt"))
                {
                    System.IO.File.WriteAllText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 7.txt", "");
                    SaveSlot.WriteLine(Character_Name);
                    SaveSlot.WriteLine(Character_Class);
                    SaveSlot.Close();
                }
            }
            else if (Save_Slot == "Slot 8")
            {
                using (StreamWriter SaveSlot = File.AppendText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 8.txt"))
                {
                    System.IO.File.WriteAllText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 8.txt", "");
                    SaveSlot.WriteLine(Character_Name);
                    SaveSlot.WriteLine(Character_Class);
                    SaveSlot.Close();
                }
            }
            else if (Save_Slot == "Slot 9")
            {
                using (StreamWriter SaveSlot = File.AppendText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 9.txt"))
                {
                    System.IO.File.WriteAllText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 9.txt", "");
                    SaveSlot.WriteLine(Character_Name);
                    SaveSlot.WriteLine(Character_Class);
                    SaveSlot.Close();
                }
            }
            else if (Save_Slot == "Slot 10")
            {
                using (StreamWriter SaveSlot = File.AppendText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 10.txt"))
                {
                    System.IO.File.WriteAllText("C:\\Users\\Dom\\source\\repos\\Devil 3\\Save slot 10.txt", "");
                    SaveSlot.WriteLine(Character_Name);
                    SaveSlot.WriteLine(Character_Class);
                    SaveSlot.Close();
                }
            }
            this.Close();
            Start = new Thread(start);
            Start.SetApartmentState(ApartmentState.STA);
            Start.Start();
            
        }
        private void start()
        {
            Application.Run(new GameScreen());
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
