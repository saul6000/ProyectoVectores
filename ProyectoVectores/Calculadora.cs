using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVectores
{
    public partial class Calculadora : Form
    {
        double value;
        string operador1;
        bool chaqueta;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
        private void PNumber (object sender , EventArgs e)
        {
            if ((operador1 == "+") || (operador1 == "-") || (operador1 == "*") || (operador1 == "/"))
            {
                if (chaqueta)
                {
                    chaqueta = false;
                    txtPantalla.Text = "0";
                }
            }
            Button b = sender as Button;
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = b.Text;
            }
            else
                txtPantalla.Text += b.Text;
        }
        private void Operaciones (object sender, EventArgs e)
        {
            Button b = sender as Button;
            //Convert text to number
            value = double.Parse(txtPantalla.Text);
            operador1 = b.Text;
            txtPantalla.Text += b.Text;
            chaqueta = true;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operador1)
                {
                    case "+":
                        txtPantalla.Text = (value + double.Parse(txtPantalla.Text)).ToString();
                        break;
                    case "-":
                        txtPantalla.Text = (value - double.Parse(txtPantalla.Text)).ToString();
                        break;
                    case "*":
                        txtPantalla.Text = (value * double.Parse(txtPantalla.Text)).ToString();
                        break;
                    case "/":
                        txtPantalla.Text = (value / double.Parse(txtPantalla.Text)).ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btbdelete_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = " 0";
            value=0;
        }
     
    }
}
