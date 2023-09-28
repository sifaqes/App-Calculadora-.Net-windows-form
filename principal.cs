using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entornos_escritorio_practica1
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();

        }
        private string lang = "es";
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (lang == "es")
                
            {
                 lang = "en";
                label1.Text = "Hello world!";
            }
            else {
                 lang = "es";
                label1.Text = "Hello mundo!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcoladora Calculadora = new calcoladora();
            Calculadora.Visible = true;

            if (Calculadora.Visible){

                this.Hide();

            }

            

        }

        private void principal_Load(object sender, EventArgs e)
        {

        }
    }
}
