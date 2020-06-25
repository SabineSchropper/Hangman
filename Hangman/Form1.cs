using HangmanLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        string path = "C:\\Users\\DCV\\C#\\Hangman\\hangman10.jpg";
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(path);
            ///while initializing Form1 the List with words should get filled
            controller.getSearchWords();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string newWord = textBoxNewWord.Text;
            controller.AddNewWord(newWord);
            MessageBox.Show("Wort hinzugefügt.");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            var form = new Spieler(controller);
            form.Show();
            
        }
    }
}
