using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicEightBall.Controllers
{
    public class MagicEightBallController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShakeBall(string question)
        {
            Random random = new Random();
            int randomAnswer = random.Next(0, 19);
            List<string> answers = new List<string>
            {
                {"It is certain." },
                {"As I see it, yes." },
                {"Reply hazy, try again." },
                {"It is decidedly so." },
                {"Most likely." },
                {"Ask again later." },
                {"Without a doubt." },
                {"Outlook good." },
                {"Better not \ntell you now." },
                {"Yes-definitely." },
                {"Yes." },
                {"Cannot predict now." },
                {"You may rely on it." },
                {"Signs point to yes." },
                {"Concentrate \nand ask again." },
                {"Don't count on it." },
                {"My reply is no." },
                {"My sources say no." },
                {"Outlook not so good." },
                {"Very doubtful." }
            };

            string thisAnswer = answers[randomAnswer];
            int num = answers.IndexOf(thisAnswer);
            ViewBag.thisAnswer = thisAnswer;
            ViewBag.yourQuestion = question;

            return View();
        }
    }
}
