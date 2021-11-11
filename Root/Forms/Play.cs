using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Root;

namespace Root.Forms
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }

        string correctWordName;
        int score;
        int total; 

        private void Play_Load(object sender, EventArgs e)
        {
            try
            {
                
                Word word = new Word();
                List<Word> words = word.GetWords();
                GameController g = new GameController();

                g.Shuffler<Word>(words);

                Random r = new Random();

                Word correctWord = words[r.Next(words.Count)];

                string correctDefinition = correctWord.definition;
                correctWordName = correctWord.name;
                List<Button> randomButtons = new List<Button>(4) { btnA, btnB, btnC, btnD };
                g.Shuffler<Button>(randomButtons);

                for(int i = 0; i < 3; i++)
                {
                    randomButtons[i].Text = words[i].name;
                }
                randomButtons[3].Text = correctWordName;

                lblDefinition.Text = correctDefinition;

                btnNext.Focus();
            }

            catch 
            {
                MessageBox.Show("Connection to database was not established"); 
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == correctWordName)
            {
                lblCorrectOrIncorrect.Visible = true; 
                lblCorrectOrIncorrect.Text = "Correct!";
                score += 1;
                total++; 
            }
            else 
            {
                lblCorrectOrIncorrect.Visible = true;
                lblCorrectOrIncorrect.Text = "Incorrect";
                score -= 0;
                total++;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == correctWordName)
            {
                lblCorrectOrIncorrect.Visible = true;
                lblCorrectOrIncorrect.Text = "Correct!";
                score += 1;
                total++;
            }
            else
            {
                lblCorrectOrIncorrect.Visible = true;
                lblCorrectOrIncorrect.Text = "Incorrect";
                score -= 1;
                total++;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == correctWordName)
            {
                lblCorrectOrIncorrect.Visible = true;
                lblCorrectOrIncorrect.Text = "Correct!";
                score += 1;
                total++;
            }
            else
            {
                lblCorrectOrIncorrect.Visible = true;
                lblCorrectOrIncorrect.Text = "Incorrect";
                score -= 1;
                total++;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == correctWordName)
            {
                lblCorrectOrIncorrect.Visible = true;
                lblCorrectOrIncorrect.Text = "Correct!";
                score += 1;
                total++;
            }
            else
            {
                lblCorrectOrIncorrect.Visible = true;
                lblCorrectOrIncorrect.Text = "Incorrect";
                score -= 1;
                total++;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblCorrectOrIncorrect.Visible = false;
            
            Word word = new Word();
            List<Word> words = word.GetWords();
            GameController g = new GameController();

            g.Shuffler<Word>(words);

            Random r = new Random();

            Word correctWord = words[r.Next(words.Count)];

            string correctDefinition = correctWord.definition;
            correctWordName = correctWord.name;
            List<Button> randomButtons = new List<Button>(4) { btnA, btnB, btnC, btnD };
            g.Shuffler<Button>(randomButtons);

            for (int i = 0; i < 3; i++)
            {
                randomButtons[i].Text = words[i].name;
            }
            randomButtons[3].Text = correctWordName;

            lblDefinition.Text = correctDefinition;

            btnNext.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You got {score} out of {total} correct! ({((decimal)total / (decimal)score) * 100}%)"); 
            this.Close(); 
        }
    }
}
