﻿using HangmanData;
using HangmanLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Highscore : Form
    {
        Controller controller;

        public Highscore(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            List<HighscoreShowModel> highscores = controller.GetHighscore();
            dataGridView1.DataSource = highscores;
            
            
        }
    }
}
