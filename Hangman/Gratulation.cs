﻿using HangmanLogic;
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
    public partial class Gratulation : Form
    {
        Controller controller;
        public Gratulation(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            labelMistakes.Text = controller.GetMistakes().ToString();
            labelTime.Text = controller.Time;
            
        }

        private void Gratulation_Load(object sender, EventArgs e)
        {

        }

        private void Gratulation_Shown(object sender, EventArgs e)
        {
        }
    }
}
