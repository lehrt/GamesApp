using System;
using MagicEightBall.Data;

namespace MagicEightBall.Models
{
    public class Hangman
    {
        //private static Random wordPicker = new Random();
        //private string _answer { get; set; }
        public string Answer { get; }
        private static int _roundCap = 6;
        public int RoundCap { get; }
        //private bool BeenInitialized { get; set; } = false;

        //public Hangman()
        //{

        //}

        public Hangman()
        {
            Answer = SetAnswer();

            SetEmptySpaces();

            RoundCap = _roundCap;
            //Answer = _answer;

            //HangManData.SetEmptySpaces(Answer.Length);
        }

        public string SetAnswer()
        {
            Random wordPicker = new Random();
            string thisAnswer = HangManData.answers[wordPicker.Next(HangManData.answers.Count)];
            return thisAnswer;
        }

        public void DecreaseRoundCap()
        {
            --_roundCap;
        }

        public void CheckInput(string Input, Hangman newHangman)
        {
            if (Answer.Contains(Input) == true)
            {
                char input = Input[0];
                HangManData.Add(input, newHangman);
            }

            else
            {
                DecreaseRoundCap();
            }
        }

        public void SetEmptySpaces()
        {
            int answerLength = this.Answer.Length;
            for (int i = 0; i < answerLength; i++)
            {
                HangManData.emptySpaces.Add('_');
            }
        }
    }
}
