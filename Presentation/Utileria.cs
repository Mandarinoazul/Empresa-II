using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Forms
{
    public partial class UtileriaForm : Form
    {
        public UtileriaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message1 = "Le dije que no le diera al boton e,e" + "Deseas cerrar la aplicacion igual no lo hará?";
            string caption = "Hola, soy Mandarino";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Mostrar esto
            result = MessageBox.Show(message1, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/Mandarinoazul/Empresa-II");

            }
        }

        private void UtileriaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
