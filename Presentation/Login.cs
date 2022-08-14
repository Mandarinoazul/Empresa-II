using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Dashboard;

namespace Login
{
    public partial class Form_login : Form
    {
         
    
    public Form_login()
        {
            InitializeComponent();
        }

        readonly SqlConnection conn = new (@"Data Source=DESKTOP-9N97K99;Initial Catalog= mycompany;Integrated Security=True");

        public Keys ModifierKey { get; private set; }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form_login_Load(object sender, EventArgs e)
        {


        }
   
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            this.Show();
            txt_username.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
          
            
            String Username, Password;
            Username = txt_username.Text;
            Password = txt_password.Text;
            
            try
            {
                String querry = "SELECT * FROM Users WHERE username = '" + Username + "' AND password = '"+ Password +"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if(dtable.Rows.Count > 0)
                {
                    Username = txt_username.Text;
                    Password = txt_password.Text;
                    //la pagina que se cargara aca abajo.
                    FormMainMenu form2 = new FormMainMenu();
                    form2.Show();
                    this.Hide();
                    
                }
                
                else
                {
                    MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                    

                }
            }
            catch
            {
                MessageBox.Show("Inicio de sesion incorrecto");
                
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }
        //Casilla para ver y ocultar clave.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '•';
            }
        }
        //Boton para registrar y enviar informacion
        private void btn_signup_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
        //Tecla ESC para cerrar aplicacion
        private void Form_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                string Message = "Desea cerrar la aplicacion?";
                string caption = "Prog II by Dan&Jun";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                //Mostrar esto
                result = MessageBox.Show(Message, caption, buttons);
                if ( result == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();

                }

            }
        }

        //Para no cerrar app con alt+f4
        private void Form_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (Control.ModifierKeys == Keys.Alt || ModifierKey == Keys.F4)
                {
                e.Cancel = true;
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int lParam, int v);
        private void Form_login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            string message = "Desea cerrar la aplicacion?";
            string title = "Cerrar ventana";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do something  
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    
}
