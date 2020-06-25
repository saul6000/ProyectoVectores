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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btbsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btbingresar_Click(object sender, EventArgs e)
        {
            if (login(this.txtusuario.Text, this.txtcontraseña.Text))
            {
                this.Visible = false;//oculta el login 
                FrmMenu frm1 = new FrmMenu();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o clave incorrecto");
            }
        }
        private bool login (string usuario , string clave)
        {
            return usuario=="admin"&& clave=="Xop02698";
        }
    }
}
