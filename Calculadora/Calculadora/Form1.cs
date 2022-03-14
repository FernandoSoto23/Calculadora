using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        Clases.Procedimiento proc1 = new Clases.Procedimiento();
        public Form1()
        {
            InitializeComponent();
            
        }
        string valor;
        private void btn_1_Click(object sender, EventArgs e)
        {
            valor += "1";
            txb_pantalla.Text = valor;
        }
        #region numeros
        private void btn_2_Click(object sender, EventArgs e)
        {
            valor += "2";
            txb_pantalla.Text = valor;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            valor += "3";
            txb_pantalla.Text = valor;
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            valor += "4";
            txb_pantalla.Text = valor;
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            valor += "5";
            txb_pantalla.Text = valor;
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            valor += "6";
            txb_pantalla.Text = valor;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            valor += "7";
            txb_pantalla.Text = valor;
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            valor += "8";
            txb_pantalla.Text = valor;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            valor += "9";
            txb_pantalla.Text = valor;
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            valor += "0";
            txb_pantalla.Text = valor;
        }
        private void btn_point_Click(object sender, EventArgs e)
        {
            valor += ".";
            txb_pantalla.Text = valor;
        }
        #endregion
        #region operadores numericos
        private void btn_mas_Click(object sender, EventArgs e)
        {
            proc1.Valor1 = double.Parse(valor);
            proc1.Operacion = '+';
            txb_pantalla.Text = "+";
            valor = null;
        }
        private void btn_menos_Click(object sender, EventArgs e)
        {
            proc1.Valor1 = double.Parse(valor);
            proc1.Operacion = '-';
            txb_pantalla.Text = "-";
            valor = null;
        }
        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            proc1.Valor1 = double.Parse(valor);
            proc1.Operacion = '*';
            txb_pantalla.Text = "*";
            valor = null;
        }
        private void btn_division_Click(object sender, EventArgs e)
        {
            proc1.Valor1 = double.Parse(valor);
            proc1.Operacion = '/';
            txb_pantalla.Text = "/";
            valor = null;
        }
        #endregion
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            proc1.Valor1 = 0;
            proc1.Valor2 = 0;
            txb_pantalla.Text = null;
            valor = null;
        }
        private void btn_enter_Click(object sender, EventArgs e)
        {
            proc1.Valor2 = double.Parse(valor);
            txb_pantalla.Clear();
            proc1.SOperacion();
            txb_pantalla.Text = proc1.Resultado.ToString();
        }

        
    }
}
