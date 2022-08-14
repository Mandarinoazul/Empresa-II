using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
        }

        private static readonly SqlConnection sqlConnection1 = new(@"Data Source= SUMINISTROS;Initial Catalog= mycompany ;Integrated Security=True");
        private static readonly SqlConnection sqlConnection = sqlConnection1;
        readonly SqlConnection con = sqlConnection;
        SqlCommand cmd = new();
        readonly SqlDataAdapter sda = new();
        readonly DataTable dtable = new();
        private void Lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" && txt_name.Text == "" && txt_lastname.Text == "" && txt_password.Text == "" && txt_cpassword.Text == "")
            {
                MessageBox.Show("Debe llenar todas las casillas, por favor.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password.Text == txt_cpassword.Text)
            {
                con.Open();
                string register = "INSERT INTO Users (username, name, lastname , password, cpassword) VALUES ('" + txt_username.Text + "','" + txt_name.Text + "', '" + txt_lastname.Text + "','" + txt_password.Text + "', '"+ txt_cpassword.Text +"')";
                cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Su cuenta fue creada/Your account has been created", "Registro completado/Register completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_name.Text = "";
                txt_lastname.Text = "";
                txt_username.Text = "";
                txt_password.Text = "";
                txt_cpassword.Text = "";

            }
            else
            {
                MessageBox.Show("Clave no coincide/Password does not match", "Registro fallido/Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_lastname.Text = "";
                lbl_lastname.Text = "";
                txt_password.Text = "";
                txt_cpassword.Text = "";
                txt_password.Focus();
            }
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txt_password.PasswordChar = '\0';
                txt_cpassword.PasswordChar = '\0';

            }
            else
            {
                txt_password.PasswordChar = '•';
                txt_cpassword.PasswordChar = '•';

            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            txt_lastname.Text = "";
            lbl_lastname.Text = "";
            txt_username.Text = "";
            txt_password.Text = "";
            txt_cpassword.Text = "";
            txt_username.Focus();
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            new Form_login().Show();
            this.Hide();
        }

        private void Txt_compassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
