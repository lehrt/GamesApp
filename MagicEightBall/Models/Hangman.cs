using System;
using MagicEightBall.Data;

namespace MagicEightBall.Models
{
    public class Hangman
    {
        private static Random wordPicker = new Random();
        private static string _answer = HangManData.answers[wordPicker.Next(HangManData.answers.Count)];
        public string Answer { get; }
        private static int _roundCap = 6;
        public int RoundCap { get; } 

        public Hangman()
        {
            //Random wordPicker = new Random();
            //string thisAnswer = HangManData.answers[wordPicker.Next(HangManData.answers.Count)];
            //this.Answer = thisAnswer;
            RoundCap = _roundCap;
            Answer = _answer;
            //HangManData.SetEmptySpaces(Answer.Length);


            //for (int i = 0; i < Answer.Length; i++)
            //{
            //    HangManData.emptySpaces.Add('_');
            //}
        }

        public void DecreaseRoundCap()
        {
            _roundCap--;
        }
    }
}
