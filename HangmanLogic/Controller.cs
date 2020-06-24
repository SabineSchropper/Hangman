using HangmanData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace HangmanLogic
{
    
    public class Controller
    {
        List<SearchWord> allSearchWords = new List<SearchWord>();
        Repository repository = new Repository();
        public void AddNewWord(string newWord)
        {
            repository.AddNewWordToDatabase(newWord);
            ///if a new Word is added to Database it should also be added to List allSearchWords
            getSearchWords();
        }
        public void getSearchWords()
        {
            List<SearchWord> searchWords = repository.getSearchWords();
            allSearchWords = searchWords;
        }
        public SearchWord FindRandomWord()
        {
            Random random = new Random();
            int randomId = random.Next(1, allSearchWords.Count+1);
            List<SearchWord> randomWord = allSearchWords.Where(x => x.id == randomId).ToList();

            return randomWord[0];
        }
    }
}
