using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace True_Quizers.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository repo;

        public QuestionController(IQuestionRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var questions = repo.GetAllQuestions();

            return View(questions);
        }

        public IActionResult ViewQuestion(int id)
        {
            var question = repo.GetQuestion(id);

            return View(question);
        }


    }
}
