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
    public partial class Form1 : Form
    {
        List<string> listaordenar = new List<string>();
        const int MAX = 100;
        private int[] vector = new int[MAX];
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtordenar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                if ( int.TryParse(this.txtordenar.Text,out int num))
                {
                    //TODO: asignar cada entero al vector 
                    if (contador < MAX)
                    {
                        vector[contador] = num;
                        contador++;
                        this.listBox1.Items.Add(num);
                    }
                    this.txtordenar.Text = " ";
                }
                else
                {
                    MessageBox.Show("Por favor ingrese solo valores numericos...");
                    this.txtordenar.Focus();
                }
            }
           
        }

        private void txtordenar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            
            int []x=clases.Ordenacion.odernaSeleccion(vector, contador);
            //TODO:mostrar el vector ordenado en un ListBox
            this.listBox1.Items.Clear();
            for(int i =0; i <contador; i++)
            {
                this.listBox1.Items.Add(x[i]);
            }
            /*string ordenar;
            ordenar = this.txtordenar.Text;
            listaordenar.Add(ordenar);
            listBox1.DataSource = null;
            listBox1.DataSource = listaordenar;*/

            //en los metodos estaticos no se necesita crear una instancia de la calse para llamarla 
            //mostrar el vector ordenaro en un listbox

        }

        private void d(object sender, EventArgs e)
        {

        }
    }
}
