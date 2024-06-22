namespace Music_Playlist
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.B_A_Add_Song = new System.Windows.Forms.Button();
            this.T_A_musicID = new System.Windows.Forms.TextBox();
            this.L_A_AddSong = new System.Windows.Forms.Label();
            this.T_A_title = new System.Windows.Forms.TextBox();
            this.T_A_artist = new System.Windows.Forms.TextBox();
            this.T_A_duration = new System.Windows.Forms.TextBox();
            this.T_A_price = new System.Windows.Forms.TextBox();
            this.L_A_musicID = new System.Windows.Forms.Label();
            this.L_A_title = new System.Windows.Forms.Label();
            this.L_A_artist = new System.Windows.Forms.Label();
            this.L_A_duration = new System.Windows.Forms.Label();
            this.L_A_price = new System.Windows.Forms.Label();
            this.L_A_Exit = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // B_A_Add_Song
            // 
            this.B_A_Add_Song.Location = new System.Drawing.Point(447, 237);
            this.B_A_Add_Song.Name = "B_A_Add_Song";
            this.B_A_Add_Song.Size = new System.Drawing.Size(91, 35);
            this.B_A_Add_Song.TabIndex = 0;
            this.B_A_Add_Song.Text = "Add Song";
            this.B_A_Add_Song.UseVisualStyleBackColor = true;
            this.B_A_Add_Song.Click += new System.EventHandler(this.B_A_Add_Song_Click);
            // 
            // T_A_musicID
            // 
            this.T_A_musicID.Location = new System.Drawing.Point(447, 49);
            this.T_A_musicID.Name = "T_A_musicID";
            this.T_A_musicID.Size = new System.Drawing.Size(91, 20);
            this.T_A_musicID.TabIndex = 1;
            // 
            // L_A_AddSong
            // 
            this.L_A_AddSong.AutoSize = true;
            this.L_A_AddSong.Location = new System.Drawing.Point(385, 248);
            this.L_A_AddSong.Name = "L_A_AddSong";
            this.L_A_AddSong.Size = new System.Drawing.Size(54, 13);
            this.L_A_AddSong.TabIndex = 2;
            this.L_A_AddSong.Text = "Add Song";
            // 
            // T_A_title
            // 
            this.T_A_title.Location = new System.Drawing.Point(447, 87);
            this.T_A_title.Name = "T_A_title";
            this.T_A_title.Size = new System.Drawing.Size(91, 20);
            this.T_A_title.TabIndex = 3;
            // 
            // T_A_artist
            // 
            this.T_A_artist.Location = new System.Drawing.Point(447, 122);
            this.T_A_artist.Name = "T_A_artist";
            this.T_A_artist.Size = new System.Drawing.Size(91, 20);
            this.T_A_artist.TabIndex = 4;
            // 
            // T_A_duration
            // 
            this.T_A_duration.Location = new System.Drawing.Point(447, 158);
            this.T_A_duration.Name = "T_A_duration";
            this.T_A_duration.Size = new System.Drawing.Size(91, 20);
            this.T_A_duration.TabIndex = 5;
            // 
            // T_A_price
            // 
            this.T_A_price.Location = new System.Drawing.Point(447, 191);
            this.T_A_price.Name = "T_A_price";
            this.T_A_price.Size = new System.Drawing.Size(91, 20);
            this.T_A_price.TabIndex = 6;
            // 
            // L_A_musicID
            // 
            this.L_A_musicID.AutoSize = true;
            this.L_A_musicID.Location = new System.Drawing.Point(386, 52);
            this.L_A_musicID.Name = "L_A_musicID";
            this.L_A_musicID.Size = new System.Drawing.Size(18, 13);
            this.L_A_musicID.TabIndex = 7;
            this.L_A_musicID.Text = "ID";
            // 
            // L_A_title
            // 
            this.L_A_title.AutoSize = true;
            this.L_A_title.Location = new System.Drawing.Point(386, 87);
            this.L_A_title.Name = "L_A_title";
            this.L_A_title.Size = new System.Drawing.Size(27, 13);
            this.L_A_title.TabIndex = 8;
            this.L_A_title.Text = "Title";
            // 
            // L_A_artist
            // 
            this.L_A_artist.AutoSize = true;
            this.L_A_artist.Location = new System.Drawing.Point(385, 125);
            this.L_A_artist.Name = "L_A_artist";
            this.L_A_artist.Size = new System.Drawing.Size(30, 13);
            this.L_A_artist.TabIndex = 9;
            this.L_A_artist.Text = "Artist";
            // 
            // L_A_duration
            // 
            this.L_A_duration.AutoSize = true;
            this.L_A_duration.Location = new System.Drawing.Point(385, 161);
            this.L_A_duration.Name = "L_A_duration";
            this.L_A_duration.Size = new System.Drawing.Size(47, 13);
            this.L_A_duration.TabIndex = 10;
            this.L_A_duration.Text = "Duration";
            // 
            // L_A_price
            // 
            this.L_A_price.AutoSize = true;
            this.L_A_price.Location = new System.Drawing.Point(385, 191);
            this.L_A_price.Name = "L_A_price";
            this.L_A_price.Size = new System.Drawing.Size(31, 13);
            this.L_A_price.TabIndex = 11;
            this.L_A_price.Text = "Price";
            // 
            // L_A_Exit
            // 
            this.L_A_Exit.AutoSize = true;
            this.L_A_Exit.Location = new System.Drawing.Point(467, 443);
            this.L_A_Exit.Name = "L_A_Exit";
            this.L_A_Exit.Size = new System.Drawing.Size(24, 13);
            this.L_A_Exit.TabIndex = 12;
            this.L_A_Exit.Text = "Exit";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(518, 430);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(91, 39);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit System";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 366);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(621, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.L_A_Exit);
            this.Controls.Add(this.L_A_price);
            this.Controls.Add(this.L_A_duration);
            this.Controls.Add(this.L_A_artist);
            this.Controls.Add(this.L_A_title);
            this.Controls.Add(this.L_A_musicID);
            this.Controls.Add(this.T_A_price);
            this.Controls.Add(this.T_A_duration);
            this.Controls.Add(this.T_A_artist);
            this.Controls.Add(this.T_A_title);
            this.Controls.Add(this.L_A_AddSong);
            this.Controls.Add(this.T_A_musicID);
            this.Controls.Add(this.B_A_Add_Song);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_A_Add_Song;
        private System.Windows.Forms.TextBox T_A_musicID;
        private System.Windows.Forms.Label L_A_AddSong;
        private System.Windows.Forms.TextBox T_A_title;
        private System.Windows.Forms.TextBox T_A_artist;
        private System.Windows.Forms.TextBox T_A_duration;
        private System.Windows.Forms.TextBox T_A_price;
        private System.Windows.Forms.Label L_A_musicID;
        private System.Windows.Forms.Label L_A_title;
        private System.Windows.Forms.Label L_A_artist;
        private System.Windows.Forms.Label L_A_duration;
        private System.Windows.Forms.Label L_A_price;
        private System.Windows.Forms.Label L_A_Exit;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}