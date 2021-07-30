using System;
using MagicEightBall.Data;

namespace MagicEightBall.Models
{
    public class Hangman
    {
        public string Answer { get; set; }
        //private static int _roundCap = 6;
        public int RoundCap { get; set; } = 6;

        public Hangman()
        {
            Random wordPicker = new Random();
            string thisAnswer = HangManData.answers[wordPicker.Next(HangManData.answers.Count)];
            this.Answer = thisAnswer;
            //RoundCap = _roundCap;
        }

        public void DecreaseRoundCap()
        {
            RoundCap--;
        }
    }
}
