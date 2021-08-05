using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MagicEightBall.Models;

namespace MagicEightBall.Data
{
    public class HangManData
    {
        public static List<string> answers = new List<string> { "peach", "grape" };
        public static List<char> emptySpaces = new List<char> { '_', '_', '_', '_', '_' };
        public static List<Hangman> ourHangman = new List<Hangman> { };

        // = new List<char> {'_', '_', '_', '_', '_'};

        public static void Add(char input, Hangman newHangman)
        {
            foreach (char i in newHangman.Answer)
            {
                if (i == input)
                {
                    int num = newHangman.Answer.IndexOf(input);
                    emptySpaces[num] = input;
                }
            }
        }

        public static void SetEmptySpaces(int answer)
        {
            for (int i = 0; i < answer; i++)
            {

                emptySpaces.Add('_');
            }
        }
    }
}
