namespace Login
{
    partial class Register
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
            this.checkbxShowPas = new System.Windows.Forms.CheckBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_cpassword = new System.Windows.Forms.TextBox();
            this.lbl_cpassword = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkbxShowPas
            // 
            this.checkbxShowPas.AutoSize = true;
            this.checkbxShowPas.BackColor = System.Drawing.Color.Transparent;
            this.checkbxShowPas.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkbxShowPas.ForeColor = System.Drawing.Color.FloralWhite;
            this.checkbxShowPas.Location = new System.Drawing.Point(243, 342);
            this.checkbxShowPas.Name = "checkbxShowPas";
            this.checkbxShowPas.Size = new System.Drawing.Size(126, 23);
            this.checkbxShowPas.TabIndex = 20;
            this.checkbxShowPas.Text = "Mostrar clave";
            this.checkbxShowPas.UseVisualStyleBackColor = false;
            this.checkbxShowPas.CheckedChanged += new System.EventHandler(this.CheckbxShowPas_CheckedChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Sylfaen", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_title.Location = new System.Drawing.Point(210, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(170, 66);
            this.lbl_title.TabIndex = 11;
            this.lbl_title.Text = "Create";
            this.lbl_title.Click += new System.EventHandler(this.Lbl_title_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_clear.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(163, 435);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(287, 26);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Limpiar/Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // btn_register
            // 
            this.btn_register.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_register.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_register.Location = new System.Drawing.Point(163, 389);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(287, 26);
            this.btn_register.TabIndex = 16;
            this.btn_register.Text = "Register/Registrar";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // txt_password
            // 
            this.txt_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txt_password.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_password.ForeColor = System.Drawing.Color.ForestGreen;
            this.txt_password.Location = new System.Drawing.Point(272, 236);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(197, 23);
            this.txt_password.TabIndex = 4;
            // 
            // txt_username
            // 
            this.txt_username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txt_username.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_username.ForeColor = System.Drawing.Color.ForestGreen;
            this.txt_username.Location = new System.Drawing.Point(272, 189);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(197, 23);
            this.txt_username.TabIndex = 3;
            this.txt_username.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_username.Location = new System.Drawing.Point(146, 189);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(98, 23);
            this.lbl_username.TabIndex = 12;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_password.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_password.Location = new System.Drawing.Point(146, 236);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(96, 23);
            this.lbl_password.TabIndex = 14;
            this.lbl_password.Text = "Password:";
            // 
            // txt_cpassword
            // 
            this.txt_cpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_cpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txt_cpassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_cpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cpassword.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_cpassword.ForeColor = System.Drawing.Color.ForestGreen;
            this.txt_cpassword.Location = new System.Drawing.Point(272, 285);
            this.txt_cpassword.Name = "txt_cpassword";
            this.txt_cpassword.PasswordChar = '•';
            this.txt_cpassword.Size = new System.Drawing.Size(197, 23);
            this.txt_cpassword.TabIndex = 5;
            this.txt_cpassword.TextChanged += new System.EventHandler(this.Txt_compassword_TextChanged);
            // 
            // lbl_cpassword
            // 
            this.lbl_cpassword.AutoSize = true;
            this.lbl_cpassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpassword.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cpassword.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_cpassword.Location = new System.Drawing.Point(123, 285);
            this.lbl_cpassword.Name = "lbl_cpassword";
            this.lbl_cpassword.Size = new System.Drawing.Size(121, 23);
            this.lbl_cpassword.TabIndex = 21;
            this.lbl_cpassword.Text = "C. Password:";
            // 
            // btn_regresar
            // 
            this.btn_regresar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_regresar.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_regresar.Location = new System.Drawing.Point(163, 481);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(287, 26);
            this.btn_regresar.TabIndex = 23;
            this.btn_regresar.Text = "Regresar/Back";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // txt_lastname
            // 
            this.txt_lastname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_lastname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txt_lastname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lastname.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_lastname.ForeColor = System.Drawing.Color.ForestGreen;
            this.txt_lastname.Location = new System.Drawing.Point(270, 149);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(197, 23);
            this.txt_lastname.TabIndex = 2;
            this.txt_lastname.TextChanged += new System.EventHandler(this.Txt_lastname_TextChanged);
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lastname.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_lastname.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_lastname.Location = new System.Drawing.Point(159, 149);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(94, 23);
            this.lbl_lastname.TabIndex = 2;
            this.lbl_lastname.Text = "Lastname:";
            this.lbl_lastname.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txt_name
            // 
            this.txt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txt_name.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_name.ForeColor = System.Drawing.Color.ForestGreen;
            this.txt_name.Location = new System.Drawing.Point(270, 110);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(197, 23);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_name.Location = new System.Drawing.Point(159, 110);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(63, 23);
            this.lbl_name.TabIndex = 26;
            this.lbl_name.Text = "Name:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 536);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.txt_cpassword);
            this.Controls.Add(this.lbl_cpassword);
            this.Controls.Add(this.checkbxShowPas);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_password);
            this.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(700, 580);
            this.MinimumSize = new System.Drawing.Size(581, 536);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbxShowPas;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_cpassword;
        private System.Windows.Forms.Label lbl_cpassword;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label lbl_lastname;
        private TextBox txt_name;
        private Label lbl_name;
    }
}