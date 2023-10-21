using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_sistemi_subnetting
{
    public partial class Form1 : Form
    {
        public string classe;
        public Form1()
        {
            InitializeComponent();
        }

        private void Host_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcola_Click(object sender, EventArgs e)
        {
            int bitrete;
            if (Math.Log(int.Parse(Sottoreti.Text), 2) + Math.Log(int.Parse(Host.Text) + 2, 2) <= 8)
            {
                classe = "C";
            }
            else if (Math.Log(int.Parse(Sottoreti.Text), 2) + Math.Log(int.Parse(Host.Text) + 2, 2) <= 16) 
            { 
                classe = "B";
            }
            else if (Math.Log(int.Parse(Sottoreti.Text), 2) + Math.Log(int.Parse(Host.Text) + 2, 2) <= 24)
            {
                classe = "A";
            }
            else
            {
                MessageBox.Show("Esagera mia");
            }
            Class.Text = classe;
            if (Class.Text=="A")
            {
                Indirizzoprivato.Text = "10.0.0.0";
                bitrete = 8;
            }
            if (Class.Text == "B")
            {
                Indirizzoprivato.Text = "172.16.0.0";
                bitrete = 16;
            }
            if (Class.Text == "C")
            {
                Indirizzoprivato.Text = "192.168.0.0";
                bitrete = 24;
            }
        }
    }
}
