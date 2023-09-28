using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entornos_escritorio_practica1
{
    public partial class calcoladora : Form
    {
        public calcoladora()
        {



            InitializeComponent();
            initializacion_calcoladora();

            // Inicializa las variables a cero
            operando1 = 0;
            operando2 = 0;
            resultado = 0;
            operacion = Operaciones.Suma; 
        }

        private void initializacion_calcoladora() 
        {

            // Establecer la alineación del elemento "Ayuda" a la derecha




            btn0.Text = "0";
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";                
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";

            btnSuma.Text = "+";
            btnResta.Text = "-";
            btnMultiplica.Text = "X";
            btnDivide.Text = "/";

            btnCalcula.Text = "=";
            btn_coma.Text = ".";
            btnBorra.Text = "B";
            btn_signo.Text = "+/-";
            lbl_status.Text = "";
            btn_potencia.Text = "^";
            btn_raiz.Text = "√";
            
            lblDisplay.AutoSize = true;
            panel_desplay.Controls.Add(lblDisplay);
            this.Controls.Add(panel_desplay);


        }

        private void calcoladora_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Está seguro?'", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal Principal = new principal();

            Principal.Visible = true;

            if(Principal.Visible) {
                this.Hide();
            }

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_num_desplay("5");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void button0_Click(object sender, EventArgs e)
        {
            add_num_desplay("0");
        }





        private void add_num_desplay(string num)
        {
            if (lblDisplay.Text == "0") {
                lblDisplay.Text = "";
            }

            string text = lblDisplay.Text + num;

            double numero = 0;

            try
            {
                lblDisplay.RightToLeft = RightToLeft.Yes;
                numero = Convert.ToInt64(text);
                lblDisplay.Text = numero.ToString();
            }
            catch { }
            
            
        }




        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Autor: Sifaqes Zerrouki, Version: 0.0.1",
                "Acerca de: Calcoladora", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
                );
        }

        private void button16(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            add_num_desplay("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            add_num_desplay("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            add_num_desplay("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            add_num_desplay("4");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            add_num_desplay("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            add_num_desplay("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            add_num_desplay("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            add_num_desplay("9");
        }

        private void btn_coma_Click(object sender, EventArgs e)
        {
            add_num_desplay(".");
        }

        enum Operaciones
        {
            Suma, Resta, Producto,
            Division,Potencia, raiz
        };
        private double operando1, operando2, resultado;

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            operando2 = Convert.ToInt64(lblDisplay.Text);
            try 
            {
                switch (operacion)
                {
                    case Operaciones.Suma:
                        resultado = operando1 + operando2;
                        break;

                    case Operaciones.Resta:
                        resultado = operando1 - operando2;
                        break;
                    case Operaciones.Producto:
                        resultado = operando1 * operando2;
                        break;

                    case Operaciones.Division:
                        if (operando2 != 0)
                        {
                            resultado = operando1 / operando2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir por cero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case Operaciones.Potencia:
                        resultado = Math.Pow(operando1 , operando2);
                        break;

                }

                lblDisplay.Text = resultado.ToString();
                lbl_status.Text = "";
                operando1 = 0;
                operando2 = 0;
            } catch 
            {
                MessageBox.Show("La operacion se ha causado un desbordamiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBorra_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            lbl_status.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt64(lblDisplay.Text);
            operacion = Operaciones.Resta;
            lblDisplay.Text = "0";
            lbl_status.Text = "Resta(" + operando1 + ")";
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt64(lblDisplay.Text);
            operacion = Operaciones.Producto;
            lblDisplay.Text = "0";
            lbl_status.Text = "Producto(" + operando1 + ")";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt64(lblDisplay.Text);
            operacion = Operaciones.Division;
            lblDisplay.Text = "0";
            lbl_status.Text = "Division(" + operando1 + ")";
        }

        private void btn_signo_Click(object sender, EventArgs e)
        {
            double num = Convert.ToInt64(lblDisplay.Text);

            double result = num * -1;

            lblDisplay.Text = result.ToString();

        }



        private void lbl_status_Click(object sender, EventArgs e)
        {

        }

        private void btn_potencia_Click_1(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt64(lblDisplay.Text);
            operacion = Operaciones.Potencia;
            lblDisplay.Text = "0";
            lbl_status.Text = "Potencia(" + operando1 + ")";
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt64(lblDisplay.Text);
            operacion = Operaciones.raiz;
            lblDisplay.Text = "0";
            lbl_status.Text = "Raíz(" + operando1 + ")";
            try 
            {
                switch (operacion)
                {
                case Operaciones.raiz:

                        resultado = Math.Sqrt(operando1);
                        break;
                }
                }catch 
            {
                MessageBox.Show("La operacion se ha causado un desbordamiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblDisplay.Text = resultado.ToString();
            operando1 = 0;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt64(lblDisplay.Text);
            operacion = Operaciones.Suma;
            lblDisplay.Text = "0";
            lbl_status.Text = "Suma(" + operando1 +  ")" ;
        }

        private Operaciones operacion;
    }
}
