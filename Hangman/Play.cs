using HangmanData;
using HangmanLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Play : Form
    {
        Controller controller;
        SearchWord randomWord;
        public Play(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            FindRandomWord();
            pictureBoxPlay.Image = Image.FromFile("C:\\Users\\DCV\\C#\\Hangman\\hangman0.jpg");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string changedWord = "";
            string inputLetter = tbLetter.Text;
            string inputWord = tbWord.Text;
            if (!string.IsNullOrEmpty(inputWord))
            {
                controller.CompareWord(inputWord);
            }
            if(inputLetter.Length > 1)
            {
                MessageBox.Show("Gib bitte nur einen Buchstaben ein.");
            }
            else
            {
                changedWord = controller.SearchRightLetters(inputLetter);            
            }
            labelSearchWord.Text = changedWord;
            CheckMistakes();
            CheckIfWon();

        }
        public void FindRandomWord()
        {
            SearchWord randomWord = controller.FindRandomWord();
            this.randomWord = randomWord;
            string firstLetter = randomWord.word.Substring(0,1);
            string restOfWord = randomWord.word.Substring(1);
            Regex rgx = new Regex("[a-zA-Z]");
            restOfWord = rgx.Replace(restOfWord, "_");
            labelSearchWord.Text = firstLetter + restOfWord;
        }
        public void CheckMistakes()
        {
            int mistakes = controller.GetMistakes();

            pictureBoxPlay.Image = Image.FromFile("C:\\Users\\DCV\\C#\\Hangman\\hangman"+mistakes+".jpg");
        }
        public void CheckIfWon()
        {
            bool hasWon = controller.GetHasWon();
            if (hasWon)
            {
                var form = new Gratulation(controller);
                form.Show();
            }
        }
    }
}
