using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaClientes
{
    public partial class eliminar : Form
    {
        BindingSource bs = new BindingSource();
        public eliminar()
        {
            InitializeComponent();
        }

        
        public void cargardatos()
        {
            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from empleados");
            bs.DataSource = ds.Tables[0];
            dataGridView2.DataSource = bs;
        }

        public void buscardatos()
        {
            BasedeDatos bus = new BasedeDatos();

            
                DataSet ds = bus.recibir("select * from empleados where " + "IdEmpleados" + "='" + txtBuscar.Text + "'");
                cargardatos();
                bs.DataSource = ds.Tables[0];
                dataGridView2.DataSource = bs;
            
            
        }
        private void Eliminar_Load(object sender, EventArgs e)
        {
           cargardatos();


           txtBuscar.DataBindings.Add("Text", bs, "IdEmpleados");
           
        }
       

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                buscardatos();
            }
            catch
            {
                lberror.Visible = true;
                timer2.Start();
            }
        }

       

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbtimer.Text += 1;
            if (lbtimer.Text == "01111111111111111111111111")
            {
                lbagregado.Visible = false;

                timer1.Stop();
                lbtimer.Text = "0";


            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            lbtimer2.Text += 1;

            if (lbtimer2.Text == "0111111111111111111111111")
            {

                lberror.Visible = false;
                timer2.Stop();
                lbtimer2.Text = "0";
            }
        }


        private void Button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                BasedeDatos x = new BasedeDatos();

                x.enviar("delete from empleados where " + "IdEmpleados" + "='" + txtBuscar.Text + "'");
                lbagregado.Visible = true;
                cargardatos();
                timer1.Start();

            }
            catch
            {
                lberror.Visible = true;
                timer2.Start();
            }
        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderColor = Color.Red;
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderColor = Color.White;
        }
    }
}
