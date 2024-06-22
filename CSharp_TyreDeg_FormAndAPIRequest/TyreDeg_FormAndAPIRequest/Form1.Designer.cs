namespace TyreDeg_FormAndAPIRequest
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dropdownFrontLeft = new System.Windows.Forms.ComboBox();
            this.dropdownRearLeft = new System.Windows.Forms.ComboBox();
            this.dropdownTrack = new System.Windows.Forms.ComboBox();
            this.dropdownFrontRight = new System.Windows.Forms.ComboBox();
            this.dropdownRearRight = new System.Windows.Forms.ComboBox();
            this.temperatureBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Front Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Front Right";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rear Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rear Right";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Track";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Temperature";
            // 
            // dropdownFrontLeft
            // 
            this.dropdownFrontLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dropdownFrontLeft.FormattingEnabled = true;
            this.dropdownFrontLeft.Location = new System.Drawing.Point(132, 137);
            this.dropdownFrontLeft.Name = "dropdownFrontLeft";
            this.dropdownFrontLeft.Size = new System.Drawing.Size(180, 21);
            this.dropdownFrontLeft.TabIndex = 7;
            this.dropdownFrontLeft.SelectedIndexChanged += new System.EventHandler(this.DropdownFrontLeft_SelectedIndexChanged);
            // 
            // dropdownRearLeft
            // 
            this.dropdownRearLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dropdownRearLeft.FormattingEnabled = true;
            this.dropdownRearLeft.Location = new System.Drawing.Point(132, 188);
            this.dropdownRearLeft.Name = "dropdownRearLeft";
            this.dropdownRearLeft.Size = new System.Drawing.Size(179, 21);
            this.dropdownRearLeft.TabIndex = 8;
            // 
            // dropdownTrack
            // 
            this.dropdownTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dropdownTrack.FormattingEnabled = true;
            this.dropdownTrack.Location = new System.Drawing.Point(132, 336);
            this.dropdownTrack.Name = "dropdownTrack";
            this.dropdownTrack.Size = new System.Drawing.Size(179, 21);
            this.dropdownTrack.TabIndex = 9;
            this.dropdownTrack.SelectedIndexChanged += new System.EventHandler(this.DropdownTrack_SelectedIndexChanged);
            // 
            // dropdownFrontRight
            // 
            this.dropdownFrontRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dropdownFrontRight.FormattingEnabled = true;
            this.dropdownFrontRight.Location = new System.Drawing.Point(509, 141);
            this.dropdownFrontRight.Name = "dropdownFrontRight";
            this.dropdownFrontRight.Size = new System.Drawing.Size(166, 21);
            this.dropdownFrontRight.TabIndex = 10;
            // 
            // dropdownRearRight
            // 
            this.dropdownRearRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dropdownRearRight.FormattingEnabled = true;
            this.dropdownRearRight.Location = new System.Drawing.Point(510, 193);
            this.dropdownRearRight.Name = "dropdownRearRight";
            this.dropdownRearRight.Size = new System.Drawing.Size(165, 21);
            this.dropdownRearRight.TabIndex = 11;
            // 
            // temperatureBox
            // 
            this.temperatureBox.Location = new System.Drawing.Point(510, 337);
            this.temperatureBox.Name = "temperatureBox";
            this.temperatureBox.Size = new System.Drawing.Size(165, 20);
            this.temperatureBox.TabIndex = 12;
            this.temperatureBox.TextChanged += new System.EventHandler(this.TemperatureBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Show Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(232, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Tyre Degradation";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 432);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.temperatureBox);
            this.Controls.Add(this.dropdownRearRight);
            this.Controls.Add(this.dropdownFrontRight);
            this.Controls.Add(this.dropdownTrack);
            this.Controls.Add(this.dropdownRearLeft);
            this.Controls.Add(this.dropdownFrontLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dropdownRearLeft;
        private System.Windows.Forms.ComboBox dropdownTrack;
        private System.Windows.Forms.ComboBox dropdownFrontRight;
        private System.Windows.Forms.ComboBox dropdownRearRight;
        private System.Windows.Forms.TextBox temperatureBox;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox dropdownFrontLeft;
        private System.Windows.Forms.TextBox textBox1;
    }
}

