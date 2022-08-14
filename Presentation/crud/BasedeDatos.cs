using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dashboard;

namespace sistemaClientes
{
    class BasedeDatos
    {
        readonly SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-9N97K99;Initial Catalog= mycompany;Integrated Security=True");

        public void enviar(String consulta)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public DataSet recibir(String consulta)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            DataSet datos = new DataSet();
            SqlDataAdapter adaptador_de_datos = new SqlDataAdapter(comando);
            adaptador_de_datos.Fill(datos);
            return datos;
        }
    }

}
