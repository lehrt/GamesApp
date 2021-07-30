﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicEightBall.Models;
using MagicEightBall.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicEightBall.Controllers
{
    public class HangmanController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hangman(string Input)
        {
            //ViewBag.Input = Input;
            //List<string> answers = new List<string> { "apple" };
            //ViewBag.answers = answers;
            //List<string> emptySpaces = new List<string> { };
            //ViewBag.emptySpaces = emptySpaces;
            //int roundCap = 6;
            //ViewBag.win = "Congrats! You won!";
            //ViewBag.lose = "You lost. Because of you, an innocent man has died.";

            //for (int i = 0; i < answer.Length; i++)
            //{
            //    emptySpaces.Add("");
            //}

            //List<string> deadMan = new List<string>
            //{
            //    { "     ╔═════╗\n     O     ║\n    /│\\    ║\n    / \\    ║" },
            //    { "     ╔═════╗\n     O     ║\n    /│\\    ║\n    /      ║" },
            //    { "     ╔═════╗\n     O     ║\n    /│\\    ║\n           ║" },
            //    { "     ╔═════╗\n     O     ║\n    /│     ║\n           ║" },
            //    { "     ╔═════╗\n     O     ║\n     │     ║\n           ║" },
            //    { "     ╔═════╗\n     O     ║\n           ║\n           ║" },
            //    { "     ╔═════╗\n           ║\n           ║\n           ║" },

            //};

            Hangman newHangman = new Hangman();
            string answer = newHangman.Answer;
            //ViewBag.roundCap = newHangman.RoundCap;

                for (int i = 0; i < answer.Length; i++)
                {
                    HangManData.emptySpaces.Add('_');
                }

                if (Input != null)
                {
                    //do
                    //{
                            if (answer.Contains(Input) == true)
                            {
                                char input = Input[0];
                                HangManData.Add(input, newHangman);
                            }

                            else if (answer.Contains(Input) != true)
                            {
                                HangManData.DecreaseRoundCap(newHangman);
                                return View();
                                //}
                            }

                            //if (newHangman.RoundCap == 0)
                            //{
                            //    "<p>You lost. Because of you, an innocent man has died.</p>";
                            //}
                            //else
                            //{
                            //    Hangman.Answer;
                            //    "<p>CONGRATS!! You won!!!</p>
                            //}
                        //}

            //while (HangManData.emptySpaces.Contains('_') && (newHangman.RoundCap != 0));
            }
            
            ViewBag.roundCap = newHangman.RoundCap;
            return View(HangManData.emptySpaces);
            }

        }
    }
