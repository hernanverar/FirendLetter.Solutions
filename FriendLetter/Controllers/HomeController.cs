using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/")]
        public ActionResult Letter()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = "Hanix";
            myLetterVariable.Sender = "Naji";
            return View(myLetterVariable);
        }

        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/postcard")]
        public ActionResult Postcard(string recipient, string sender, string place1, string place2, string souvenir)
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = recipient;
            myLetterVariable.Sender = sender;
            myLetterVariable.Place1 = place1;
            myLetterVariable.Place2 = place2;
            myLetterVariable.Souvenir = souvenir;
            return View(myLetterVariable);
        }
    }
}