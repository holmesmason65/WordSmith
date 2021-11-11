using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Root;
using System.Data.SqlClient; 

namespace CreateAccount
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false; 
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" && txtLastName.Text == "" && txtEmail.Text == ""
                && txtUserName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("One or more fields empty.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User newUser = new User(txtFirstName.Text, txtLastName.Text, txtUserName.Text,
                    txtPassword.Text, txtEmail.Text);
                bool accountCreated = newUser.AddUser();
                if (accountCreated)
                {
                    MessageBox.Show("Account successfully created");
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Username already exsists");
                }
            }
        }
    }
}
