namespace Dashboard
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.MenuStripDashboard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFacturacion = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnUtileria = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.btnAdministrativo = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Showpanel = new System.Windows.Forms.Panel();
            this.childForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.MenuStripDashboard.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.BackgroundImage = global::Presentation.Properties.Resources.fondito;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.ContextMenuStrip = this.MenuStripDashboard;
            this.panelMenu.Controls.Add(this.btnFacturacion);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnUtileria);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnAdministrativo);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.IndianRed;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(279, 640);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMenu_MouseDown);
            // 
            // MenuStripDashboard
            // 
            this.MenuStripDashboard.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStripDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRegistroToolStripMenuItem,
            this.modificarRegistroToolStripMenuItem,
            this.buscarDataToolStripMenuItem,
            this.eliminarDataToolStripMenuItem});
            this.MenuStripDashboard.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStripDashboard.Name = "MenuStripDashboard";
            this.MenuStripDashboard.Size = new System.Drawing.Size(177, 100);
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.nuevoRegistroToolStripMenuItem.Text = "Nueva data";
            // 
            // modificarRegistroToolStripMenuItem
            // 
            this.modificarRegistroToolStripMenuItem.Name = "modificarRegistroToolStripMenuItem";
            this.modificarRegistroToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.modificarRegistroToolStripMenuItem.Text = "Modificar data";
            // 
            // buscarDataToolStripMenuItem
            // 
            this.buscarDataToolStripMenuItem.Name = "buscarDataToolStripMenuItem";
            this.buscarDataToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.buscarDataToolStripMenuItem.Text = "Buscar data";
            // 
            // eliminarDataToolStripMenuItem
            // 
            this.eliminarDataToolStripMenuItem.Name = "eliminarDataToolStripMenuItem";
            this.eliminarDataToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.eliminarDataToolStripMenuItem.Text = "Eliminar data";
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.Transparent;
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFacturacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFacturacion.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnFacturacion.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFacturacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacturacion.IconSize = 38;
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 433);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(275, 47);
            this.btnFacturacion.TabIndex = 6;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.BtnFacturacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.LevelDownAlt;
            this.btnSalir.IconColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 50;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 557);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(275, 79);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Cerrar sesion";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnUtileria
            // 
            this.btnUtileria.BackColor = System.Drawing.Color.Transparent;
            this.btnUtileria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUtileria.FlatAppearance.BorderSize = 0;
            this.btnUtileria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtileria.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUtileria.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUtileria.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.btnUtileria.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUtileria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUtileria.IconSize = 38;
            this.btnUtileria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtileria.Location = new System.Drawing.Point(0, 360);
            this.btnUtileria.Name = "btnUtileria";
            this.btnUtileria.Size = new System.Drawing.Size(275, 73);
            this.btnUtileria.TabIndex = 4;
            this.btnUtileria.Text = "Utileria";
            this.btnUtileria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtileria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUtileria.UseVisualStyleBackColor = false;
            this.btnUtileria.Click += new System.EventHandler(this.BtnUtileria_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInventario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.ItchIo;
            this.btnInventario.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventario.IconSize = 38;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 292);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(275, 68);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // btnAdministrativo
            // 
            this.btnAdministrativo.BackColor = System.Drawing.Color.Transparent;
            this.btnAdministrativo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrativo.FlatAppearance.BorderSize = 0;
            this.btnAdministrativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrativo.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdministrativo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdministrativo.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnAdministrativo.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdministrativo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdministrativo.IconSize = 38;
            this.btnAdministrativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrativo.Location = new System.Drawing.Point(0, 225);
            this.btnAdministrativo.Name = "btnAdministrativo";
            this.btnAdministrativo.Size = new System.Drawing.Size(275, 67);
            this.btnAdministrativo.TabIndex = 2;
            this.btnAdministrativo.Text = "Administrativo";
            this.btnAdministrativo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrativo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministrativo.UseVisualStyleBackColor = false;
            this.btnAdministrativo.Click += new System.EventHandler(this.BtnAdministrativo_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Dashcube;
            this.btnDashboard.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 38;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 155);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(275, 70);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(275, 155);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLogo_Paint);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(276, 152);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Presentation.Properties.Resources.fondito;
            this.panel1.Controls.Add(this.Showpanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(279, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 157);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // Showpanel
            // 
            this.Showpanel.Location = new System.Drawing.Point(0, 157);
            this.Showpanel.Name = "Showpanel";
            this.Showpanel.Size = new System.Drawing.Size(745, 483);
            this.Showpanel.TabIndex = 0;
            // 
            // childForm
            // 
            this.childForm.BackColor = System.Drawing.Color.Transparent;
            this.childForm.BackgroundImage = global::Presentation.Properties.Resources.fondito;
            this.childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childForm.Location = new System.Drawing.Point(279, 157);
            this.childForm.Name = "childForm";
            this.childForm.Size = new System.Drawing.Size(745, 483);
            this.childForm.TabIndex = 3;
            this.childForm.Paint += new System.Windows.Forms.PaintEventHandler(this.Showform);
            this.childForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChildForm_MouseDown);
            // 
            // FormMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.ContextMenuStrip = this.MenuStripDashboard;
            this.Controls.Add(this.childForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormMainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danvae";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMainMenu_KeyPress);
            this.panelMenu.ResumeLayout(false);
            this.MenuStripDashboard.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnFacturacion;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnUtileria;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnAdministrativo;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.ContextMenuStrip MenuStripDashboard;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDataToolStripMenuItem;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel childForm;
        private Panel Showpanel;
    }
}

