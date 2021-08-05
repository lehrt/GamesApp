using System;
using MagicEightBall.Data;

namespace MagicEightBall.Models
{
    public class Hangman
    {
        //private static Random wordPicker = new Random();
        //private string _answer { get; set; }
        public string Answer { get; set; }
        private static int _roundCap = 6;
        public int RoundCap { get; }
        private bool BeenInitialized { get; set; } = false;

        //public Hangman()
        //{

        //}

        public Hangman()
        {
            if (BeenInitialized == false)
            {
                Answer = SetAnswer();

            //for (int i = 0; i < Answer.Length; i++)
            //{
            //    HangManData.emptySpaces.Add('_');
            //}

                BeenInitialized = true;
            }
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

            else if (Answer.Contains(Input) != true)
            {
                DecreaseRoundCap();
            }
        }

    }
}
