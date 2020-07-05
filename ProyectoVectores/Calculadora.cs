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
    public enum TipoTecla
    {
        NINGUNO=0,
        DIGITO=1,
        OPERADOR=2,
        AC=3
    }
    public partial class Calculadora : Form
    {
        private TipoTecla mUltimaPulsacion;
        private int mOperando1;
        private int mOperando2;
        private int mNumOperandos;
        private string mOperador;
        public Calculadora()
        {
            InitializeComponent();
        }
        bool validaDigito(string teclapulsada)
        {
            if (teclapulsada.Equals("0")) return true;
            if (teclapulsada.Equals("1")) return true;
            if (teclapulsada.Equals("2")) return true;
            if (teclapulsada.Equals("3")) return true;
            if (teclapulsada.Equals("4")) return true;
            if (teclapulsada.Equals("5")) return true;
            if (teclapulsada.Equals("6")) return true;
            if (teclapulsada.Equals("7")) return true;
            if (teclapulsada.Equals("8")) return true;
            if (teclapulsada.Equals("9")) return true;
            return false;
        }
        private void btb0_Click(object sender, EventArgs e)
        {
            //detectar que botón se pulsó
            // cast -- casting -- casteo
            Button btn = (Button)sender;
            string strnum = btn.Text;



            if (this.mUltimaPulsacion != TipoTecla.DIGITO)
                this.txtPantalla.Text = "";
           


            if (validaDigito(strnum))
            {
                this.txtPantalla.Text += strnum; //método abreviado
                this.mUltimaPulsacion = TipoTecla.DIGITO;
            }
            else if ((strnum == "+" || strnum == "-" || strnum == "X" || strnum == "/" || strnum == "=") && this.mUltimaPulsacion == TipoTecla.DIGITO)
            {
                if (this.mUltimaPulsacion == TipoTecla.DIGITO)
                    this.mNumOperandos++;
               
                if (this.mNumOperandos == 1 )
                {
                    
                        this.mOperando1 = Int32.Parse(this.txtPantalla.Text);
                  

                }
                
                else if (this.mNumOperandos == 2)
                {
                    this.mOperando2 = Int32.Parse(this.txtPantalla.Text);
                    switch (this.mOperador)
                    {
                        case "+":
                            this.mOperando1 += this.mOperando2;
                            break;
                        case "-":
                            this.mOperando1 -= this.mOperando2;
                            break;
                        case "X":
                            this.mOperando1 *= this.mOperando2;
                            break;
                        case "/":
                            this.mOperando1 /= this.mOperando2;
                            break;
                        case "=":
                            this.txtPantalla.Show();

                            break;
                    }
                    this.txtPantalla.Text = this.mOperando1.ToString();
                    this.mNumOperandos = 1;
                }

                //this.txtPantalla.Text = "";
                
                this.mUltimaPulsacion = TipoTecla.OPERADOR;
                this.mOperador = strnum;
            }
      
            if (strnum == "AC")
            {
                this.txtPantalla.Clear();
                this.mNumOperandos = 0;
            }
           

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            this.mUltimaPulsacion = TipoTecla.NINGUNO;
            this.mOperando1 = 0;
            this.mOperando2 = 0;
            this.mNumOperandos = 0;
            this.mUltimaPulsacion = TipoTecla.NINGUNO;

            btb1.Click += new EventHandler(btb0_Click);
            btb2.Click += new EventHandler(btb0_Click);
            btb3.Click += new EventHandler(btb0_Click);
            btb4.Click += new EventHandler(btb0_Click);
            btb5.Click += new EventHandler(btb0_Click);
            btb6.Click += new EventHandler(btb0_Click);
            btb7.Click += new EventHandler(btb0_Click);
            btb8.Click += new EventHandler(btb0_Click);
            btb9.Click += new EventHandler(btb0_Click);

            this.btbsuma.Click += new EventHandler(btb0_Click);
            this.btbresta.Click += new EventHandler(btb0_Click);
            this.btbmultiplicacion.Click += new EventHandler(btb0_Click);
            this.btbdivision.Click += new EventHandler(btb0_Click);
            this.btbigual.Click += new EventHandler(btb0_Click);
            this.btbac.Click += new EventHandler(btb0_Click);
        }

        private void btbigual_Click(object sender, EventArgs e)
        {
            
        }
    }
}
