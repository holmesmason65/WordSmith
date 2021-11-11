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
using Root.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; 
        }

        private void btnShowPasswordLogin_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false; 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User loginUser = new User(txtUsername.Text);
            bool userExists =  loginUser.CheckUserExists();
            if (userExists)
            {
                MessageBox.Show("Welcome " + loginUser.username + " !", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
            else 
            {
                MessageBox.Show("Username not found");
                
            }
        }
    }
}
