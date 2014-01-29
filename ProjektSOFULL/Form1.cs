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
        public delegate void GetTextDelegate(String text);
        private Thread system;
        String[] czytnik1_string = new String[100];
        String[] czytnik2_string = new String[100];
        String pomocniczy;
        String[] pomoc = new String[100];

        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Application.ApplicationExit += new System.EventHandler(ApplicationExitHandler);
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
            pomocniczy = czytnik1.Text;
            czytnik1_string = pomocniczy.Split('\n');
        }

        private void zaladuj2_Click(object sender, EventArgs e)
        {
            pomocniczy = czytnik2.Text;
            czytnik2_string = pomocniczy.Split('\n');
        }

        /*pobranie wartosci czytnikow*/
        public string[] get_czytnik1()
        {
            //pomocniczy = "21\n22\n23\n24";
pomocniczy = "11\n12\n13\n14\n15\n16";
            czytnik1_string = pomocniczy.Split('\n');
            return czytnik1_string;
        }

        public string[] get_czytnik2()
        {
             
            //pomocniczy = "11\n12\n13\n14\n15\n16";
            pomocniczy = "21\n22\n23\n24";
            czytnik2_string = pomocniczy.Split('\n');
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
            system = new Thread(new ThreadStart(Program.system_up));
            system.Start();
        }

        private void InitSO()
        {
            SetText("Nastepuje uruchomienie systemu");
        }

        /*czysc1*/
        private void button1_Click(object sender, EventArgs e)
        {
            drukarka1.Clear();
        }
        /*czysc2*/
        private void button2_Click(object sender, EventArgs e)
        {
            drukarka2.Clear();
        }

        private void ApplicationExitHandler(Object sender, EventArgs e)
        {
            system.Abort();
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("Wylaczanie systemu");
            MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event"); 
        }
    }
}
