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
    public partial class modificar : Form
    {
        
        BindingSource bs = new BindingSource();
        public modificar()
        {
            InitializeComponent();
        }
        public void buscardatos()
        {
            BasedeDatos bus = new BasedeDatos();
            DataSet ds = bus.recibir("select * from empleados where " + "IdEmpleados" + "='" + txtBuscar.Text + "'");
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
        }
        
        public void cargardatos()
        {

            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from empleados");
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;

        }
        
        private void Modificar_Load(object sender, EventArgs e)
        {
            

            cargardatos();
            txtci.DataBindings.Add("Text", bs, "IdEmpleados");
            txtnombres.DataBindings.Add("Text", bs, "Nombre");
            txtapellidop.DataBindings.Add("Text", bs, "apellidop");
            txtapellidom.DataBindings.Add("Text", bs, "apellidom");
            txtcel.DataBindings.Add("Text", bs, "celular"); 

            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            buscardatos();
                
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                BasedeDatos x = new BasedeDatos();
                String IdEmpleados = txtci.Text;
                String nombres = txtnombres.Text;
                String apellidop = txtapellidop.Text;
                String apellidom = txtapellidom.Text;
                String cel = txtcel.Text;
                
                x.enviar("update empleados set nombre='" + nombres + "', apellidop='" + apellidop + "', apellidom='" + apellidom + "', celular='" + cel + "' where IdEmpleados='" + IdEmpleados + "'");
                cargardatos();
                lbagregado.Visible = true;
                timer1.Start();
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
    }
}
