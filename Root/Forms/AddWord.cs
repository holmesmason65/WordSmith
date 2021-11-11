using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Root.Forms
{
    public partial class frmAddWord : Form
    {
        public frmAddWord()
        {
            InitializeComponent();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            Word addedWord = new Word();
            addedWord.name = txtWordName.Text;
            addedWord.definition = txtDefinition.Text;
            bool wordWasAdded = addedWord.AddWord();
            if (wordWasAdded)
                MessageBox.Show("Sucess");
            else
                MessageBox.Show("Failure");
        }
    }
}
