using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjektSOFULL
{
    public partial class Form1 : Form
    {
        public delegate void SetTextDelegate(String text);
        String[] czytnik1_string = new String[100];
        String[] czytnik2_string = new String[100];
        String pomocniczy;
        String[] pomoc = new String[100];

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


        /*logger*/
        public void SetText(string text)
        {
            if (logger.InvokeRequired)
            {
                SetTextDelegate d = new SetTextDelegate(SetText);
                this.Invoke(d, new object[] { text });

            }
            else
                this.logger.AppendText("[" + DateTime.Now.ToString("HH:mm:ss tt") + "] " + text + "\n");
        }

        /*wczytywanie do bufora z czytnikow*/
        private void zaladuj1_Click(object sender, EventArgs e)
        {
            //pomocniczy = czytnik1_string.Text;
            //czytnik1_string = pomocniczy.Split('\n');
            //foreach (string x in czytnik1_string)
             //   drukarka.Text += x + "\n";
        }

        private void zaladuj2_Click(object sender, EventArgs e)
        {
            //pomocniczy = czytnik2_string.Text;
            //czytnik2_string = pomocniczy.Split('\n');
            //foreach (string x in czytnik1_string)
            //   drukarka.Text += x + "\n";
        }

        /*pobranie wartosci czytnikow*/
        public string[] get_czytnik1()
        {
            return czytnik1_string;
        }

        public string[] get_czytnik2()
        {
            return czytnik2_string;
        }


        /*drukowanie na ekran*/
        public void set_drukarka1(string text)
        {
            if (drukarka1.InvokeRequired)
            {
                SetTextDelegate d = new SetTextDelegate(set_drukarka1);
                this.Invoke(d, new object[] { text });

            }
            else
                this.drukarka1.AppendText(text + "\n");

        }

        public void set_drukarka2(string text)
        {
            if (drukarka2.InvokeRequired)
            {
                SetTextDelegate d = new SetTextDelegate(set_drukarka2);
                this.Invoke(d, new object[] { text });

            }
            else
                this.drukarka2.AppendText(text + "\n");
        }

        private void start_Click(object sender, EventArgs e)
        {
            InitSO();
            Thread system = new Thread(new ThreadStart(Program.system_up));
            system.Start();
        }

        private void InitSO()
        {
            SetText("Nastepuje uruchomienie systemu");
        }
    }
}
