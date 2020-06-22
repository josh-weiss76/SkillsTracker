using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]

        public IActionResult Index()
        {
            string html = "<form method='post' action='/skills/'>" + 
                "<h1>Skills Tracker</h1>" + 
                "<h2>Coding Skills to learn: </h2>" +
                "<ol>" +
                    "<li>JavaScript</li>" +
                    "<li>C#</li>" +
                    "<li>Python</li>";
            return Content(html, "text/html");
        }

        [HttpGet]
        [Route("/skills/form")]
        public IActionResult SkillsInput()
        {
            string html = "<form method='post' action='/skills/form'>" +
                "<p><b>Date:<b><br></p>" +
                "<input type='text' name='date'></input>" + 
                "<p>mm / dd / yyyy <br></p>" +
                "<p><b>JavaScript:<b><br></p>" +
                "<select name='jProficiency'>" +
                    "<option value='basic'>Learning Code</option>" +
                    "<option value='intermediate'>Making Apps</option>" +
                    "<option value='advanced'>Master Coder</option>" +
                "</select>" +
                "<p><br><b>C#:<b><br></p>" +
                "<select name='cProficiency'>" +
                    "<option value='basic'>Learning Code</option>" +
                    "<option value='intermediate'>Making Apps</option>" +
                    "<option value='advanced'>Master Coder</option>" +
                "</select>" +
                "<p><br><b>Python:<b><br></p>" +
                "<select name='pProficiency'>" +
                    "<option value='basic'>Learning Code</option>" +
                    "<option value='intermediate'>Making Apps</option>" +
                    "<option value='advanced'>Master Coder</option>" +
                "</select>" +
                "<p></p>" +
                "<input type='submit' value='Submit' />" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/skills/form")]
        public IActionResult CreateSkillList(string date, string jProficiency, string cProficiency, string pProficiency)
        {
            string java = "";
            string c = "";
            string python = "";
            if (jProficiency == "basic")
            {
                java += "Learning Basics";
            }
            else if (jProficiency == "intermediate")
            {
                java += "Making Apps";
            }
            else if (jProficiency == "advanced")
            {
                java += "Master Coder";
            }

            if (cProficiency == "basic")
            {
                c += "Learning Basics";
            }
            else if (cProficiency == "intermediate")
            {
                c += "Making Apps";
            }
            else if (cProficiency == "advanced")
            {
                c += "Master Coder";
            }

            if (pProficiency == "basic")
            {
                python += "Learning Basics";
            }
            else if (pProficiency == "intermediate")
            {
                python += "Making Apps";
            }
            else if (pProficiency == "advanced")
            {
                python += "Master Coder";
            }

            string output = "<h1>" + date + "<br></h1>" +
                "<p><b>JavaScript: " + java + "<b><br></p>" +
                "<p><br><b>C#: " + c + "<b><br></p>" +
                "<p><br><b>Python: " + python + "<b><br></p>" +
                "<p></p>";
            //string output = "< h1 > Welcome to my app, " + date + "! </ h1 > ";
            return Content(output, "text/html");
        }
    }
}
