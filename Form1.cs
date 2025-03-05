using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Format_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obligar al usuario que ingrese una edad válida
            if (int.TryParse(txt.Text, out int edad))
            {
                if (edad > 17)
                {
                    MessageBox.Show("Es mayor de edad");
                }
                else
                {
                    MessageBox.Show("Es menor de edad");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese una edad valida");
            }
        }
            
    }

}


