using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanData
{
    public class HighscoreShowModel
    {
        public string Spieler { get; set; }
        public int? Fehlversuche { get; set; }
        public int? Zeit_in_Sekunden { get; set; }

        public HighscoreShowModel(string player, int? trials, int? timeInSeconds)
        {
            Spieler = player;
            Fehlversuche = trials;
            Zeit_in_Sekunden = timeInSeconds;
        }
    }
}
