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
    public partial class FrmNumerosLetras : Form
    {
       
        public FrmNumerosLetras()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (int.TryParse(this.txtNumero.Text, out int num))
                {
                    //TODO: asignar cada entero al vector 
                    this.txtResultado.Text = clases.NumLetras.getLetras(num);
                    this.txtNumero.Text="";
                }
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
