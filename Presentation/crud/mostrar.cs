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
    public partial class mostrar : Form
    {

        BindingSource bs = new BindingSource();
        public mostrar()
        {
            InitializeComponent();
        }
        public void cargardatos()
        {
            BasedeDatos con = new BasedeDatos();
            DataSet ds = con.recibir("select * from empleados");
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
    }
}
