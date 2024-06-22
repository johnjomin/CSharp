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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        //create a connection object
        OleDbConnection myConn = new OleDbConnection();

        private void B_Login_Click(object sender, EventArgs e)
        {
            OleDbDataReader myDR;
            try
            {
             myConn.ConnectionString = connectionDetails.establish_Connection;
this.Hide();
             Music_Form m = new Music_Form();
             
                OleDbCommand myCmd = myConn.CreateCommand();

                //use an SQL Select to query the to find email and password
                myCmd.CommandText = "SELECT email,password FROM Customer WHERE email=@email  AND password=@password;";
               
                myCmd.Parameters.AddWithValue("email", T_UserName.Text);
                myCmd.Parameters.AddWithValue("password", T_Password.Text);
                myConn.Open();
           
                myDR = myCmd.ExecuteReader();
                myDR.Read(); 
                if (myDR.HasRows)
                {

                    MessageBox.Show("Worked! You are connected to the database!");
                    Music_Form music = new Music_Form();
                    this.Visible = false;
                    music.Show();
                }
                else
                {
                    MessageBox.Show("It has failed! Email is not recognised!");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_Register_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Come to the Dark side...We have MUSIC!");
            Register_Form music = new Register_Form();
            this.Visible = false;
            music.Show();
        }

        private void B_Admin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome Admin! Add any song you wish!");
            Admin_Form admin = new Admin_Form();
            this.Visible = false;
            admin.Show();
        }
    }
}
