namespace Music_Playlist
{
    partial class Login_Form
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
            this.T_UserName = new System.Windows.Forms.TextBox();
            this.L_UserName = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.T_Password = new System.Windows.Forms.TextBox();
            this.B_Login = new System.Windows.Forms.Button();
            this.L_Register = new System.Windows.Forms.Label();
            this.B_Register = new System.Windows.Forms.Button();
            this.G_Login = new System.Windows.Forms.GroupBox();
            this.L_Header = new System.Windows.Forms.Label();
            this.P_Logo = new System.Windows.Forms.PictureBox();
            this.L_Admin = new System.Windows.Forms.Label();
            this.B_Admin = new System.Windows.Forms.Button();
            this.G_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // T_UserName
            // 
            this.T_UserName.Location = new System.Drawing.Point(94, 29);
            this.T_UserName.Name = "T_UserName";
            this.T_UserName.Size = new System.Drawing.Size(100, 20);
            this.T_UserName.TabIndex = 0;
            // 
            // L_UserName
            // 
            this.L_UserName.AutoSize = true;
            this.L_UserName.Location = new System.Drawing.Point(31, 32);
            this.L_UserName.Name = "L_UserName";
            this.L_UserName.Size = new System.Drawing.Size(57, 13);
            this.L_UserName.TabIndex = 1;
            this.L_UserName.Text = "UserName";
            // 
            // L_Password
            // 
            this.L_Password.AccessibleDescription = "Username";
            this.L_Password.AutoSize = true;
            this.L_Password.Location = new System.Drawing.Point(35, 74);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(53, 13);
            this.L_Password.TabIndex = 2;
            this.L_Password.Text = "Password";
            // 
            // T_Password
            // 
            this.T_Password.Location = new System.Drawing.Point(94, 74);
            this.T_Password.Name = "T_Password";
            this.T_Password.Size = new System.Drawing.Size(100, 20);
            this.T_Password.TabIndex = 3;
            this.T_Password.UseSystemPasswordChar = true;
            // 
            // B_Login
            // 
            this.B_Login.Location = new System.Drawing.Point(94, 117);
            this.B_Login.Name = "B_Login";
            this.B_Login.Size = new System.Drawing.Size(100, 23);
            this.B_Login.TabIndex = 4;
            this.B_Login.Text = "Login";
            this.B_Login.UseVisualStyleBackColor = true;
            this.B_Login.Click += new System.EventHandler(this.B_Login_Click);
            // 
            // L_Register
            // 
            this.L_Register.AutoSize = true;
            this.L_Register.Location = new System.Drawing.Point(257, 302);
            this.L_Register.Name = "L_Register";
            this.L_Register.Size = new System.Drawing.Size(294, 13);
            this.L_Register.TabIndex = 5;
            this.L_Register.Text = "Not a member? Come Join us register and enjoy great Songs!";
            // 
            // B_Register
            // 
            this.B_Register.Location = new System.Drawing.Point(260, 318);
            this.B_Register.Name = "B_Register";
            this.B_Register.Size = new System.Drawing.Size(285, 27);
            this.B_Register.TabIndex = 6;
            this.B_Register.Text = "Register";
            this.B_Register.UseVisualStyleBackColor = true;
            this.B_Register.Click += new System.EventHandler(this.B_Register_Click);
            // 
            // G_Login
            // 
            this.G_Login.Controls.Add(this.T_Password);
            this.G_Login.Controls.Add(this.T_UserName);
            this.G_Login.Controls.Add(this.L_UserName);
            this.G_Login.Controls.Add(this.B_Login);
            this.G_Login.Controls.Add(this.L_Password);
            this.G_Login.Location = new System.Drawing.Point(295, 97);
            this.G_Login.Name = "G_Login";
            this.G_Login.Size = new System.Drawing.Size(207, 146);
            this.G_Login.TabIndex = 7;
            this.G_Login.TabStop = false;
            this.G_Login.Text = "Sign In";
            // 
            // L_Header
            // 
            this.L_Header.AutoSize = true;
            this.L_Header.Font = new System.Drawing.Font("Rage Italic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Header.Location = new System.Drawing.Point(146, 18);
            this.L_Header.Name = "L_Header";
            this.L_Header.Size = new System.Drawing.Size(268, 24);
            this.L_Header.TabIndex = 9;
            this.L_Header.Text = "Welcome! To [COMPANY NAME] ";
            // 
            // P_Logo
            // 
            this.P_Logo.Image = global::Music_Playlist.Properties.Resources.logo;
            this.P_Logo.Location = new System.Drawing.Point(12, 64);
            this.P_Logo.Name = "P_Logo";
            this.P_Logo.Size = new System.Drawing.Size(250, 188);
            this.P_Logo.TabIndex = 8;
            this.P_Logo.TabStop = false;
            // 
            // L_Admin
            // 
            this.L_Admin.AutoSize = true;
            this.L_Admin.Location = new System.Drawing.Point(40, 336);
            this.L_Admin.Name = "L_Admin";
            this.L_Admin.Size = new System.Drawing.Size(116, 13);
            this.L_Admin.TabIndex = 10;
            this.L_Admin.Text = "Registered admins only";
            // 
            // B_Admin
            // 
            this.B_Admin.Location = new System.Drawing.Point(81, 352);
            this.B_Admin.Name = "B_Admin";
            this.B_Admin.Size = new System.Drawing.Size(75, 23);
            this.B_Admin.TabIndex = 11;
            this.B_Admin.Text = "Admin";
            this.B_Admin.UseVisualStyleBackColor = true;
            this.B_Admin.Click += new System.EventHandler(this.B_Admin_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(557, 397);
            this.Controls.Add(this.B_Admin);
            this.Controls.Add(this.L_Admin);
            this.Controls.Add(this.L_Header);
            this.Controls.Add(this.P_Logo);
            this.Controls.Add(this.G_Login);
            this.Controls.Add(this.B_Register);
            this.Controls.Add(this.L_Register);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login_Form";
            this.Text = "[Company Name]";
            this.G_Login.ResumeLayout(false);
            this.G_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T_UserName;
        private System.Windows.Forms.Label L_UserName;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.TextBox T_Password;
        private System.Windows.Forms.Button B_Login;
        private System.Windows.Forms.Label L_Register;
        private System.Windows.Forms.Button B_Register;
        private System.Windows.Forms.GroupBox G_Login;
        private System.Windows.Forms.PictureBox P_Logo;
        private System.Windows.Forms.Label L_Header;
        private System.Windows.Forms.Label L_Admin;
        private System.Windows.Forms.Button B_Admin;
    }
}