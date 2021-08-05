using System;
using MagicEightBall.Data;

namespace MagicEightBall.Models
{
    public class Hangman
    {
        //private static Random wordPicker = new Random();
        //private string _answer { get; set; }
        public string Answer { get; set; }
        //private int _roundCap = 6;
        public int RoundCap { get; set; } = 6;
        private bool BeenInitialized { get; set; } = false;

        public Hangman()
        {
            Random wordPicker = new Random();
            string thisAnswer = HangManData.answers[wordPicker.Next(HangManData.answers.Count)];
            this.Answer = thisAnswer;
            if (BeenInitialized == false)
            {
                //SetAnswer();

                //for (int i = 0; i < Answer.Length; i++)
                //{
                //    HangManData.emptySpaces.Add('_');
                //}

                BeenInitialized = true;
            }
            //RoundCap = _roundCap;
            //Answer = _answer;

            //HangManData.SetEmptySpaces(Answer.Length);


        }

        public void SetAnswer()
        {
            Random wordPicker = new Random();
            string thisAnswer = HangManData.answers[wordPicker.Next(HangManData.answers.Count)];
            this.Answer = thisAnswer;
        }

        public void DecreaseRoundCap()
        {
            RoundCap--;
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
