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
        String[] czytnik1_string = new String[100];
        String[] czytnik2_string = new String[100];
        String pomocniczy;

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
        //zaladuj 1
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(czytnik_1.Text);
            pomocniczy = czytnik_1.Text;
            czytnik1_string = pomocniczy.Split('\n');

        }

        public string[] get_czynik1()
        {
            return czytnik1_string;
        }
        //zaladuj 2
        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(czytnik_2.Text);
            pomocniczy = czytnik_2.Text;
            czytnik2_string = pomocniczy.Split('\n');
        }
        public string[] get_czynik2()
        {
            return czytnik2_string;
        }
        //czytnik 1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //czytnik 2
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //drukarka 1
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //drukarka 2
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        //logger
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
