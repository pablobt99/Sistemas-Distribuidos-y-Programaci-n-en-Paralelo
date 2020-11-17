using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBuena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Boton pulsado");
             Form2 NuevoForm = new Form2();
             NuevoForm.Show();

            private void label2_Click(object sender, EventArgs e)

                try
            {
                decimmal ElREsultado = this.Dividir(this.numDividendo.VAlue, this.numDivisor.Value);
                this.txResultado.Text = ElREsultado.ToString();
            }
            catch
            {
                MessageBox.Show("no puede introducir un 0 en el divisor");
            }
      
                
        }
            private decimal Dividir (int ElDividendo, int ElDivisor)
            {
                return ElDividendo / ElDivisor;
            }
        }

    }
}
