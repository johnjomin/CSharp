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
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

     //create a connection object
        OleDbConnection myConn = new OleDbConnection();
      
        private void B_R_Register_Click(object sender, EventArgs e)
        {
              //  OleDbDataReader myDR;
            try
            {
             myConn.ConnectionString = connectionDetails.establish_Connection;

               OleDbCommand myCmd = myConn.CreateCommand();
              //This (more efficient) alternative uses stream-mode ADO.NET
             // SQL Insert command 
               myCmd.CommandText = "INSERT INTO Customer(FirstName, LastName, DateOfBirth, Email,[Password])" +
             " VALUES (@firstname, @lastname, @dateofbirth, @email,@password);";

             myCmd.Parameters.AddWithValue("firstname", T_R_FirstName.Text);
             myCmd.Parameters.AddWithValue("lastname", T_R_LastName.Text);
             myCmd.Parameters.AddWithValue("dateofbirth", T_R_dateOfBirth.Text);
             myCmd.Parameters.AddWithValue("email", T_R_Email.Text);
             myCmd.Parameters.AddWithValue("password", T_R_Password.Text);
            
            myConn.Open(); 
            myCmd.ExecuteNonQuery();
            myConn.Close();

            MessageBox.Show("Welcome " + T_R_FirstName.Text + " To a world of Music!");
            Login_Form login = new Login_Form();
            this.Visible = false;
            login.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
