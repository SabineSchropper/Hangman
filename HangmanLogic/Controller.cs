using HangmanData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace HangmanLogic
{

    public class Controller
    {
        int mistakes = 0;
        List<string> alreadySearchedLetters = new List<string>();
        List<SearchWord> allSearchWords = new List<SearchWord>();
        string changedWord = "";
        SearchWord randomWord;
        bool hasWon;
        string playerName;
        Repository repository = new Repository();
        public string Time { get; set; }
        public TimeSpan Ts;
        List<HighscoreShowModel> highscoreShowModels;
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
        public string SearchRightLetters(string inputLetter)
        {
            List<string> lettersToReplace = new List<string>();
            string wordInProgress = randomWord.word;
            string firstLetter = wordInProgress.Substring(0, 1);
            string restOfWord = wordInProgress.Substring(1);
            inputLetter = inputLetter.ToLower();
            if (restOfWord.Contains(inputLetter))
            {
                alreadySearchedLetters.Add(inputLetter);
            }
            else
            {
                mistakes++;
            }
            ///should change all letters into "_" except the existing letters
            for (int i = 0; i < restOfWord.Length; i++)
            {
                string oneLetter = restOfWord[i].ToString();
                foreach (var item in alreadySearchedLetters)
                {
                    if (!(oneLetter == item))
                    {
                        lettersToReplace.Add(oneLetter);
                        if (alreadySearchedLetters.Contains(oneLetter))
                        {
                            lettersToReplace.Remove(oneLetter);
                        }
                    }
                }
            }
            foreach (var item in lettersToReplace)
            {
                restOfWord = restOfWord.Replace(item, "_");
            }
            if (alreadySearchedLetters.Count == 0)
            {
                Regex rgx = new Regex("[a-zA-Z]");
                restOfWord = rgx.Replace(restOfWord, "_");
            }
            changedWord = firstLetter + restOfWord;
            if (!changedWord.Contains("_"))
            {
                hasWon = true;
            }
            return changedWord;

        }
        public void CompareWord(string inputWord)
        {
            hasWon = false;
            string compareInput = inputWord.ToLower();
            string solution = randomWord.word.ToLower();
            if (compareInput == solution)
            {
                hasWon = true;
            }
            else
            {
                mistakes++;
            }

        }
        public SearchWord FindRandomWord()
        {
            Random random = new Random();
            int randomId = random.Next(1, allSearchWords.Count + 1);
            List<SearchWord> randomWords = allSearchWords.Where(x => x.id == randomId).ToList();
            this.randomWord = randomWords[0];
            return randomWord;
        }
        public int GetMistakes()
        {
            return mistakes;
        }
        public bool GetHasWon()
        {
            return hasWon;
        }
        public void SetPlayerName(string playerName)
        {
            this.playerName = playerName;
        }
        public bool CheckIfThereAreTrialsLeft()
        {
            bool trialsLeft = true;
            if (mistakes == 10)
            {
                trialsLeft = false;
            }
            return trialsLeft;
        }
        public void FormatTime(TimeSpan ts)
        {
            Ts = ts;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds);

            this.Time = elapsedTime;
        }
        public void SaveData()
        {
            Highscore highscore = new Highscore();
            highscore.hasWon = hasWon;
            highscore.player = playerName;
            highscore.trials = mistakes;
            highscore.time_in_seconds = (int)Ts.TotalSeconds;
            repository.AddPlayToHighscore(highscore);
        }
        public void HandleHighscore()
        {
            List<Highscore> highscores = repository.GetHighscoreFromDatabase();
            List<HighscoreShowModel> highscoreShowModels = new List<HighscoreShowModel>();
            foreach(var item in highscores)
            {
                highscoreShowModels.Add(new HighscoreShowModel(item.player,item.trials,item.time_in_seconds));
            }
            this.highscoreShowModels = highscoreShowModels;
        }
        public List<HighscoreShowModel> GetHighscore()
        {
            return highscoreShowModels;
        }
    }
}
