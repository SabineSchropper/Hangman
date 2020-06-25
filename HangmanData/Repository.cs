using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanData;

namespace HangmanData
{
    
    public class Repository
    {
        HangmanEntities entities = new HangmanEntities();

        public List<SearchWord> getSearchWords()
        {
            List<SearchWord> searchWords = entities.SearchWord.Where(x => x.word != null).ToList();
            entities.SaveChanges();

            return searchWords;
        }
        public void AddNewWordToDatabase(string newWord)
        {
            SearchWord searchWord = new SearchWord();
            searchWord.word = newWord;
            entities.SearchWord.Add(searchWord);
            entities.SaveChanges();
        }
        public void AddPlayToHighscore(Highscore highscore)
        {
            entities.Highscore.Add(highscore);
            entities.SaveChanges();
        }
        public List<Highscore> GetHighscoreFromDatabase()
        {
            List<Highscore> highscores = entities.Highscore.Where(x => x.hasWon == true).OrderBy(x => x.time_in_seconds).Take(10).ToList();
            return highscores;
        }

    }
}
