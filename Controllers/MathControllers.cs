using Microsoft.AspNetCore.Mvc;
using System;

namespace MathWizard.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(string left, string right)
        {
            int lefttop = Convert.ToInt32(left);
            int righttop = Convert.ToInt32(right);
            int sum = lefttop + righttop;

            ViewData["Sum"] = $"{left} plus {right} equals {sum}";

            return View();
        }

        public IActionResult Sub(string left, string right)
        {
            int lefttop = Convert.ToInt32(left);
            int righttop = Convert.ToInt32(right);
            int difference = lefttop - righttop;

            ViewData["Difference"] =
            $"{left} minus {right} equals {difference}";

            return View();
        }

        public IActionResult Mult(string left, string right)
        {
            int lefttop = Convert.ToInt32(left);
            int righttop = Convert.ToInt32(right);
            int product = lefttop * righttop;

            ViewData["Product"] =
            $"{left} multiplied by {right} equals {product}";

            return View();
        }

        public IActionResult Div(string left, string right)
        {
            int lefttop = Convert.ToInt32(left);
            int righttop = Convert.ToInt32(right);

            if (righttop == 0)
            {
                ViewData["Quotient"] =
                "Cannot not divide by zero.";
            }
            else
            {
                int quotient = lefttop / righttop;
                ViewData["Quotient"] =
                $"{left} divided by {right} equals {quotient}";
            }
            return View();
        }

        public IActionResult Mod(string left, string right)
        {
            int lefttop = Convert.ToInt32(left);
            int righttop = Convert.ToInt32(right);

            if(lefttop>=0 && righttop>0)
            {
                int remainder = lefttop%righttop;
                ViewData["Remainder"]=
                $"The remainder of {left} divided by {right} is {remainder}";
            }else
            {
                ViewData["Remainder"]=
                "Modulus can only be performed by two positive numbers and a divisor not equal to zero.";
            }
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}