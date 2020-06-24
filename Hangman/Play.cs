using HangmanData;
using HangmanLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Play : Form
    {
        Controller controller;
        public Play(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            FindRandomWord();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string inputLetter = tbLetter.Text;
            if(inputLetter.Length > 1)
            {
                MessageBox.Show("Gib bitte nur einen Buchstaben ein.");
            }

        }
        public void FindRandomWord()
        {
            SearchWord randomWord = controller.FindRandomWord();
            string firstLetter = randomWord.word.Substring(0,1);
            string restOfWord = randomWord.word.Substring(1);
            Regex rgx = new Regex("[a-zA-Z]");
            restOfWord = rgx.Replace(restOfWord, "_");
            labelSearchWord.Text = firstLetter + restOfWord;
        }
    }
}
