using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Root.Forms
{
    public partial class frmRemoveWord : Form
    {
        public frmRemoveWord()
        {
            InitializeComponent();
        }

        private void btnRemoveWord_Click(object sender, EventArgs e)
        {
            if (txtRemoveWord.Text != "")
            {
                Word removeWord = new Word(txtRemoveWord.Text);
                bool wordExists = removeWord.CheckWordExists();
                if (wordExists)
                {
                    removeWord.RemoveWord();
                    MessageBox.Show("Word succesfully removed");
                }
                else 
                {
                    MessageBox.Show("Word entered does not exist");
                }
            }
            else 
            {
                MessageBox.Show("You must enter a word to remove it"); 
            }
        }
    }
}
