using System;
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

        public IActionResult HangmanInitialize()
        {
            Hangman newHangman = new Hangman();
            return View(newHangman);
        }

        public IActionResult Hangman(string Input, Hangman newHangman)
        {

            if (Input != null)
            {
                newHangman.CheckInput(Input, newHangman);    

                if (newHangman.RoundCap == 0)
                {
                    return View("~/Views/Hangman/LoseView.cshtml", HangManData.emptySpaces);
                }

                else if (!HangManData.emptySpaces.Contains('_'))
                {
                    
                    return View("~/Views/Hangman/WinView.cshtml", HangManData.emptySpaces);
                }
            }
            
            //HangManData.SetEmptySpaces(newHangman);
            ViewBag.roundCap = newHangman.RoundCap;
            return View(HangManData.emptySpaces);
            }

        }
    }

