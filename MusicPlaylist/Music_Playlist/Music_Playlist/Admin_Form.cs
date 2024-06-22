using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Music_Playlist
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }
        //create a connection object
        OleDbConnection myConn = new OleDbConnection();
        private void B_A_Add_Song_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.ConnectionString = connectionDetails.establish_Connection;

                OleDbCommand myCmd = myConn.CreateCommand();
                //This (more efficient) alternative uses stream-mode ADO.NET
                // SQL Insert command 
                myCmd.CommandText = "INSERT INTO Music(musicID, title, artist, duration,[price])" +
              " VALUES (@music, @title, @artist, @duration,@price);";

                myCmd.Parameters.AddWithValue("music", T_A_musicID.Text);
                myCmd.Parameters.AddWithValue("title", T_A_title.Text);
                myCmd.Parameters.AddWithValue("artist", T_A_artist.Text);
                myCmd.Parameters.AddWithValue("duration", T_A_duration.Text);
                myCmd.Parameters.AddWithValue("price", T_A_price.Text);

                myConn.Open();
                myCmd.ExecuteNonQuery();
                myConn.Close();
                
                MessageBox.Show("Song " + T_A_title.Text + " is added to the database!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
