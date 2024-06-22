namespace Music_Playlist
{
    partial class Register_Form
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
            this.L_R_FirstName = new System.Windows.Forms.Label();
            this.L_R_LastName = new System.Windows.Forms.Label();
            this.L_R_dateOfBirth = new System.Windows.Forms.Label();
            this.L_R_Password = new System.Windows.Forms.Label();
            this.L_R_Email = new System.Windows.Forms.Label();
            this.T_R_FirstName = new System.Windows.Forms.TextBox();
            this.T_R_LastName = new System.Windows.Forms.TextBox();
            this.T_R_Email = new System.Windows.Forms.TextBox();
            this.T_R_Password = new System.Windows.Forms.TextBox();
            this.T_R_dateOfBirth = new System.Windows.Forms.TextBox();
            this.B_R_Register = new System.Windows.Forms.Button();
            this.G_R_Register = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.G_R_Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // L_R_FirstName
            // 
            this.L_R_FirstName.AutoSize = true;
            this.L_R_FirstName.Location = new System.Drawing.Point(31, 26);
            this.L_R_FirstName.Name = "L_R_FirstName";
            this.L_R_FirstName.Size = new System.Drawing.Size(57, 13);
            this.L_R_FirstName.TabIndex = 0;
            this.L_R_FirstName.Text = "First Name";
            // 
            // L_R_LastName
            // 
            this.L_R_LastName.AutoSize = true;
            this.L_R_LastName.Location = new System.Drawing.Point(31, 51);
            this.L_R_LastName.Name = "L_R_LastName";
            this.L_R_LastName.Size = new System.Drawing.Size(58, 13);
            this.L_R_LastName.TabIndex = 1;
            this.L_R_LastName.Text = "Last Name";
            // 
            // L_R_dateOfBirth
            // 
            this.L_R_dateOfBirth.AutoSize = true;
            this.L_R_dateOfBirth.Location = new System.Drawing.Point(31, 132);
            this.L_R_dateOfBirth.Name = "L_R_dateOfBirth";
            this.L_R_dateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.L_R_dateOfBirth.TabIndex = 2;
            this.L_R_dateOfBirth.Text = "Date Of Birth";
            // 
            // L_R_Password
            // 
            this.L_R_Password.AutoSize = true;
            this.L_R_Password.Location = new System.Drawing.Point(31, 106);
            this.L_R_Password.Name = "L_R_Password";
            this.L_R_Password.Size = new System.Drawing.Size(53, 13);
            this.L_R_Password.TabIndex = 3;
            this.L_R_Password.Text = "Password";
            // 
            // L_R_Email
            // 
            this.L_R_Email.AutoSize = true;
            this.L_R_Email.Location = new System.Drawing.Point(31, 77);
            this.L_R_Email.Name = "L_R_Email";
            this.L_R_Email.Size = new System.Drawing.Size(32, 13);
            this.L_R_Email.TabIndex = 4;
            this.L_R_Email.Text = "Email";
            // 
            // T_R_FirstName
            // 
            this.T_R_FirstName.Location = new System.Drawing.Point(114, 19);
            this.T_R_FirstName.Name = "T_R_FirstName";
            this.T_R_FirstName.Size = new System.Drawing.Size(135, 20);
            this.T_R_FirstName.TabIndex = 5;
            // 
            // T_R_LastName
            // 
            this.T_R_LastName.Location = new System.Drawing.Point(112, 48);
            this.T_R_LastName.Name = "T_R_LastName";
            this.T_R_LastName.Size = new System.Drawing.Size(137, 20);
            this.T_R_LastName.TabIndex = 6;
            // 
            // T_R_Email
            // 
            this.T_R_Email.Location = new System.Drawing.Point(114, 77);
            this.T_R_Email.Name = "T_R_Email";
            this.T_R_Email.Size = new System.Drawing.Size(135, 20);
            this.T_R_Email.TabIndex = 7;
            // 
            // T_R_Password
            // 
            this.T_R_Password.Location = new System.Drawing.Point(114, 103);
            this.T_R_Password.Name = "T_R_Password";
            this.T_R_Password.Size = new System.Drawing.Size(135, 20);
            this.T_R_Password.TabIndex = 8;
            this.T_R_Password.UseSystemPasswordChar = true;
            // 
            // T_R_dateOfBirth
            // 
            this.T_R_dateOfBirth.Location = new System.Drawing.Point(114, 129);
            this.T_R_dateOfBirth.Name = "T_R_dateOfBirth";
            this.T_R_dateOfBirth.Size = new System.Drawing.Size(133, 20);
            this.T_R_dateOfBirth.TabIndex = 9;
            // 
            // B_R_Register
            // 
            this.B_R_Register.Location = new System.Drawing.Point(114, 155);
            this.B_R_Register.Name = "B_R_Register";
            this.B_R_Register.Size = new System.Drawing.Size(135, 62);
            this.B_R_Register.TabIndex = 10;
            this.B_R_Register.Text = "Register";
            this.B_R_Register.UseVisualStyleBackColor = true;
            this.B_R_Register.Click += new System.EventHandler(this.B_R_Register_Click);
            // 
            // G_R_Register
            // 
            this.G_R_Register.Controls.Add(this.B_R_Register);
            this.G_R_Register.Controls.Add(this.T_R_dateOfBirth);
            this.G_R_Register.Controls.Add(this.T_R_Password);
            this.G_R_Register.Controls.Add(this.T_R_Email);
            this.G_R_Register.Controls.Add(this.T_R_LastName);
            this.G_R_Register.Controls.Add(this.T_R_FirstName);
            this.G_R_Register.Controls.Add(this.L_R_Email);
            this.G_R_Register.Controls.Add(this.L_R_Password);
            this.G_R_Register.Controls.Add(this.L_R_dateOfBirth);
            this.G_R_Register.Controls.Add(this.L_R_LastName);
            this.G_R_Register.Controls.Add(this.L_R_FirstName);
            this.G_R_Register.Location = new System.Drawing.Point(497, 126);
            this.G_R_Register.Name = "G_R_Register";
            this.G_R_Register.Size = new System.Drawing.Size(255, 236);
            this.G_R_Register.TabIndex = 11;
            this.G_R_Register.TabStop = false;
            this.G_R_Register.Text = "Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Music_Playlist.Properties.Resources.nodame1;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 504);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(779, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.G_R_Register);
            this.Name = "Register_Form";
            this.Text = "Register_Form";
            this.G_R_Register.ResumeLayout(false);
            this.G_R_Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label L_R_FirstName;
        private System.Windows.Forms.Label L_R_LastName;
        private System.Windows.Forms.Label L_R_dateOfBirth;
        private System.Windows.Forms.Label L_R_Password;
        private System.Windows.Forms.Label L_R_Email;
        private System.Windows.Forms.TextBox T_R_FirstName;
        private System.Windows.Forms.TextBox T_R_LastName;
        private System.Windows.Forms.TextBox T_R_Email;
        private System.Windows.Forms.TextBox T_R_Password;
        private System.Windows.Forms.TextBox T_R_dateOfBirth;
        private System.Windows.Forms.Button B_R_Register;
        private System.Windows.Forms.GroupBox G_R_Register;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}