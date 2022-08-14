using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dashboard.Forms;
using FontAwesome.Sharp;

namespace Dashboard
{
    public partial class FormMainMenu : Form
    {
        private const DockStyle fill = DockStyle.Fill;

        //Fields
        public IconButton? CurrentBtn { get; }

        private readonly Panel leftBorderBtn;
        public  Form? currentChildForm;

        public Keys ModifierKey { get; private set; }

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 60)
            };
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

     

        //Metodos
        private void ActivateButton(object senderBtn, Color color, IconButton CurrentBtn)
        {
            if(senderBtn != null)
            {
                DisableButton();
                CurrentBtn = (IconButton)senderBtn;
                CurrentBtn.BackColor = Color.FromArgb(37, 36, 81);
                CurrentBtn.ForeColor = color;
                CurrentBtn.TextAlign = ContentAlignment.MiddleCenter;
                CurrentBtn.IconColor = color;
                CurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Boton izquierdo
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, CurrentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
               
               
            }
        }
        private void DisableButton()
        {
            if(CurrentBtn != null)
            {
                CurrentBtn.BackColor = Color.FromArgb(31, 30, 68);
                CurrentBtn.ForeColor = Color.OrangeRed;
                CurrentBtn.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Openchildform(object childForm)
        {

            if (this.childForm.Controls.Count > 0)
                this.childForm.Controls.RemoveAt(0);
            Form? fh = childForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.childForm.Controls.Add(fh);
            this.childForm.Tag = fh;
            fh.Show();
            

        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnUtileria_Click(object sender, EventArgs e)
        {
            Openchildform(new UtileriaForm());
            


        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Openchildform(new DashboardForm());
            this.Hide();

        }

        private void BtnAdministrativo_Click(object sender, EventArgs e)
        {
            
            Openchildform(new Forms.Administrativo());
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            Openchildform(new Forms.Inventario());
        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            Openchildform(new Facturacion());
        }

        public void BtnSalir_Click(object sender, EventArgs e)
        {

            string Message = "Deseas cerrar la aplicacion?";
            string caption = "HEY, ESPERA";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Mostrar esto
            result = MessageBox.Show(Message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();

            }
        }



        private void BtnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //RESETEAR BOTONES
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int lParam, int v);
        
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormMainMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                string Message = "Deseas cerrar la aplicacion?";
                string caption = "HEY, ESPERA";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                //Mostrar esto
                result = MessageBox.Show(Message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();

                }

            }
        }


        private void ChildForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Showform(object sender, PaintEventArgs e)
        {
          
        }

    }
}
