using HangmanData;
using System;
using System.Collections.Generic;
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
           for(int i = 0; i < restOfWord.Length; i++)
            {
                string oneLetter = restOfWord[i].ToString();
                foreach(var item in alreadySearchedLetters)
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
           foreach(var item in lettersToReplace)
            {
                restOfWord = restOfWord.Replace(item, "_");
            }
           if(alreadySearchedLetters.Count == 0)
            {
                Regex rgx = new Regex("[a-zA-Z]");
                restOfWord = rgx.Replace(restOfWord, "_");
            }
            changedWord = firstLetter + restOfWord;
            if(!changedWord.Contains("_"))
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
            if(compareInput == solution)
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
            int randomId = random.Next(1, allSearchWords.Count+1);
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
    }
}
