/* TODO: 
 *      - figure out when the root form should close
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateAccount;
using Login;
using GamePreferences;
using System.Data.SqlClient;
using Root.Forms;

namespace Root
{
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
        }

        private void Root_Load(object sender, EventArgs e)
        {
            Word w = new Word();
            w.DisplayWords(); 
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmCreateAccount createAccount = new frmCreateAccount();
            createAccount.Show(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmLogin login = new frmLogin();
            login.Show(); 

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmGamePreferences preferences = new frmGamePreferences();
            Play frmPlay = new Play();
            frmPlay.Show(); 
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmAddWord AddWord = new frmAddWord();
            AddWord.Show(); 
        }

        private void Root_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show("Are you sure you want to exit? If you are in the middle of gameplay the form will close", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true; 
            }
            
        }

        private void btnRemoveWord_Click(object sender, EventArgs e)
        {
            frmRemoveWord frm = new frmRemoveWord();
            frm.Show(); 
        }
    }
}
