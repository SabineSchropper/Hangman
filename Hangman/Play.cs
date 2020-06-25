using HangmanData;
using HangmanLogic;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Play : Form
    {
        public Controller controller;
        public Stopwatch stopwatch = new Stopwatch();
        public SearchWord randomWord;
        
        public Play(Controller controller)
        {
            stopwatch.Start();
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
            bool trialsLeft;
            bool hasWon = controller.GetHasWon();
            if (hasWon)
            {
                stopwatch.Stop();
                controller.FormatTime(stopwatch.Elapsed);

                var form = new Gratulation(controller);
                form.Show();

                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 10000;
                timer.Tag = form;
                timer.Tick += ((sender, e) =>
                {
                    form.Close();
                    var timerSender = sender as System.Windows.Forms.Timer;
                    timerSender.Stop();
                    this.Close();
                });
                /*
                 *         private void Timer_Tick(object sender, EventArgs e)
                            {
                                form.Close();
                            }
                 * 
                 */
                timer.Start();


                
                controller.SaveData();
                
            }
            else
            {
                trialsLeft = controller.CheckIfThereAreTrialsLeft();
                if (!trialsLeft)
                {
                    MessageBox.Show("Leider verloren. Du hast mehr als 10 mal falsch geraten.");
                    stopwatch.Stop();
                    controller.FormatTime(stopwatch.Elapsed);
                    controller.SaveData();                  
                }
            }
        }
    }
}
