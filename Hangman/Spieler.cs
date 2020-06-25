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
    public partial class Spieler : Form
    {
        Controller controller;
        public Spieler(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void btnGetName_Click(object sender, EventArgs e)
        {
            string playerName = "";
            
            playerName = tbName.Text;

            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Gib bitte deinen Namen ein.");
            }
            else
            {
                controller.SetPlayerName(playerName);
                var form = new Play(controller);
                form.Show();
                Close();
            }         
        }
    }
}
