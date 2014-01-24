using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSOFULL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Witamy w Systemie Projekt SO FULL \n";
            textBox4.Text += "Próba Podjęcia zlecenia\n";
            if (textBox1.Text.Length==0)
            {
                textBox4.Text += "Karta zlecenia jest pusta, wstrzymanie działania\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Witamy w Systemie Projekt SO FULL \n";
            textBox4.Text += "Próba Podjęcia zlecenia\n";
            if (textBox2.Text.Length == 0)
            {
                textBox4.Text += "Karta zlecenia jest pusta, wstrzymanie działania\n";
                return;
            }

        }
    }
}
