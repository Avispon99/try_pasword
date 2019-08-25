using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.Clave_de_3_intentos
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {

            int count = int.Parse(cuenta.Text);


            if (id.Text == "Jhonatan" && clave.Text == "Cinco")
            {
                if (cuenta.Text != "3" )
                {
                    MessageBox.Show(" BIENVENIDO SEÑOR JHONATAN.");
                }
                else { MessageBox.Show(" La cuenta ha sido BLOQUEADA por superar los 3 Intentos."); }
                
            }
            else
            {
                if (cuenta.Text != "3")
                {
                    MessageBox.Show(" Contraseña o ID Errada.");
                    count++;
                    cuenta.Text = count.ToString();
                }
                else { MessageBox.Show(" La cuenta ha sido BLOQUEADA por superar los 3 Intentos."); }

            }





        }


       
    }
}
