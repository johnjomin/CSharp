namespace Music_Playlist
{
    partial class Music_Form
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
            this.DGV_Music = new System.Windows.Forms.DataGridView();
            this.L_S_Name = new System.Windows.Forms.Label();
            this.T_Song_Search = new System.Windows.Forms.TextBox();
            this.B_S_Search = new System.Windows.Forms.Button();
            this.B_S_LogOff = new System.Windows.Forms.Button();
            this.B_S_SHOW_ALL = new System.Windows.Forms.Button();
            this.M_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_image)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Music
            // 
            this.DGV_Music.AllowUserToOrderColumns = true;
            this.DGV_Music.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Music.Location = new System.Drawing.Point(344, 70);
            this.DGV_Music.Name = "DGV_Music";
            this.DGV_Music.ReadOnly = true;
            this.DGV_Music.Size = new System.Drawing.Size(422, 256);
            this.DGV_Music.TabIndex = 0;
            // 
            // L_S_Name
            // 
            this.L_S_Name.AutoSize = true;
            this.L_S_Name.Location = new System.Drawing.Point(341, 24);
            this.L_S_Name.Name = "L_S_Name";
            this.L_S_Name.Size = new System.Drawing.Size(35, 13);
            this.L_S_Name.TabIndex = 1;
            this.L_S_Name.Text = "Name";
            // 
            // T_Song_Search
            // 
            this.T_Song_Search.Location = new System.Drawing.Point(344, 44);
            this.T_Song_Search.Name = "T_Song_Search";
            this.T_Song_Search.Size = new System.Drawing.Size(168, 20);
            this.T_Song_Search.TabIndex = 2;
            // 
            // B_S_Search
            // 
            this.B_S_Search.Location = new System.Drawing.Point(530, 33);
            this.B_S_Search.Name = "B_S_Search";
            this.B_S_Search.Size = new System.Drawing.Size(109, 31);
            this.B_S_Search.TabIndex = 3;
            this.B_S_Search.Text = "Search";
            this.B_S_Search.UseVisualStyleBackColor = true;
            this.B_S_Search.Click += new System.EventHandler(this.B_S_Search_Click);
            // 
            // B_S_LogOff
            // 
            this.B_S_LogOff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B_S_LogOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_S_LogOff.Location = new System.Drawing.Point(344, 347);
            this.B_S_LogOff.Name = "B_S_LogOff";
            this.B_S_LogOff.Size = new System.Drawing.Size(109, 35);
            this.B_S_LogOff.TabIndex = 6;
            this.B_S_LogOff.Text = "Log off";
            this.B_S_LogOff.UseVisualStyleBackColor = false;
            this.B_S_LogOff.Click += new System.EventHandler(this.B_S_LogOff_Click);
            // 
            // B_S_SHOW_ALL
            // 
            this.B_S_SHOW_ALL.Location = new System.Drawing.Point(656, 33);
            this.B_S_SHOW_ALL.Name = "B_S_SHOW_ALL";
            this.B_S_SHOW_ALL.Size = new System.Drawing.Size(110, 31);
            this.B_S_SHOW_ALL.TabIndex = 7;
            this.B_S_SHOW_ALL.Text = "Show All Songs";
            this.B_S_SHOW_ALL.UseVisualStyleBackColor = true;
            this.B_S_SHOW_ALL.Click += new System.EventHandler(this.B_S_SHOW_ALL_Click);
            // 
            // M_image
            // 
            this.M_image.Image = global::Music_Playlist.Properties.Resources.M_Image;
            this.M_image.Location = new System.Drawing.Point(9, 33);
            this.M_image.Name = "M_image";
            this.M_image.Size = new System.Drawing.Size(326, 314);
            this.M_image.TabIndex = 8;
            this.M_image.TabStop = false;
            // 
            // Music_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(827, 409);
            this.Controls.Add(this.M_image);
            this.Controls.Add(this.B_S_SHOW_ALL);
            this.Controls.Add(this.B_S_LogOff);
            this.Controls.Add(this.B_S_Search);
            this.Controls.Add(this.T_Song_Search);
            this.Controls.Add(this.L_S_Name);
            this.Controls.Add(this.DGV_Music);
            this.Name = "Music_Form";
            this.Text = "Music_Form";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Music;
        private System.Windows.Forms.Label L_S_Name;
        private System.Windows.Forms.TextBox T_Song_Search;
        private System.Windows.Forms.Button B_S_Search;
        private System.Windows.Forms.Button B_S_LogOff;
        private System.Windows.Forms.Button B_S_SHOW_ALL;
        private System.Windows.Forms.PictureBox M_image;
    }
}