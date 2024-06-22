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
    public partial class Music_Form : Form
    {
       
         
        public Music_Form()
        {
            
            InitializeComponent();
        }
        //create a connection object
        OleDbConnection myConn = new OleDbConnection();

        private void B_S_Search_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.ConnectionString = connectionDetails.establish_Connection;
                string sql = @"Select title,artist,duration,price From Music"
                    + @" Where title=@title;";
                // lets create Data Adapter! 
                OleDbDataAdapter myDadapter = new OleDbDataAdapter(sql, myConn);
                OleDbParameter pTitle = new OleDbParameter("@title",T_Song_Search.Text);
                myDadapter.SelectCommand.Parameters.Add(pTitle);
                // lets allow them to search now!
         

                // create a datable to hold our search!
                DataTable dtMusicSearch = new DataTable();
                //get data from db into the datatable we just made!
                myDadapter.Fill(dtMusicSearch);

                // finally linlk the dataTable to the Datagridview 
                DGV_Music.AutoGenerateColumns = true;
                DGV_Music.DataSource = dtMusicSearch;
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_S_SHOW_ALL_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.ConnectionString = connectionDetails.establish_Connection;
                string sql = @"Select title,artist,duration,price From Music;";
                // lets create Data Adapter! 
                OleDbDataAdapter myDadapter = new OleDbDataAdapter(sql, myConn);
             
                // lets allow them to search now!


                // create a datable to hold our search!
                DataTable dtMusicSearch = new DataTable();
                //get data from db into the datatable we just made!
                myDadapter.Fill(dtMusicSearch);

                // finally linlk the dataTable to the Datagridview 
                DGV_Music.AutoGenerateColumns = true;
                DGV_Music.DataSource = dtMusicSearch;
                myConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_S_LogOff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have logged off!!");
            Login_Form login = new Login_Form();
            this.Visible = false;
            login.Show();
        }



    }
}
