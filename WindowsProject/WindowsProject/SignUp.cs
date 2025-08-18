using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsProject
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if(username==""||password==""||confirmPassword=="")
            {
                MessageBox.Show("All fields are required.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if(password!=confirmPassword)
            {
                MessageBox.Show("Password and Confirm password do not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hashedPassword = PasswordHasher.Hash(password);

            using (SqlConnection conn=new SqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM testfirst WHERE dbusername =@username";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@username", username);

                int exists = (int)checkCmd.ExecuteScalar();
                if(exists>0)
                {
                    MessageBox.Show("Username already exists.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                string insertQuery = "INSERT INTO testfirst (dbusername,dbpassword) VALUES (@username,@password)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@password", hashedPassword);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Sign-up Successful!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
            Application.OpenForms["LoginForm"]?.Show();
        }
    }
}
