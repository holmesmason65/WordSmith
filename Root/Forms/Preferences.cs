using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Root.Forms;
using Root; 

namespace GamePreferences
{
    public partial class frmGamePreferences : Form
    {
        public frmGamePreferences()
        {
            InitializeComponent();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            this.Close();
            Play playForm = new Play();
            playForm.Show();
            
        }

        private void frmGamePreferences_Load(object sender, EventArgs e)
        {
            Word w = new Word();

            List<Word> words = w.GetWords();

            Random r = new Random();

            Word randomWord = new Word(); 

            try
            {
                randomWord = words[r.Next(words.Count)];
            }
            catch 
            {
                MessageBox.Show("Could not retrieve vocabulary words from database.");
            }

            lblRandomDefinition.Visible = true;
            lblRandomWord.Visible = true;
            lblRandomDefinition.Text = randomWord.definition;
            lblRandomWord.Text = randomWord.name;
        }
    }
}
