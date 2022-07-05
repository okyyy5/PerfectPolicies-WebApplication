using ICTPRG532OktayTurdu.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICTPRG532OktayTurdu.DTO;

namespace ICTPRG532OktayTurdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {

        private readonly PerfectPolicyContext _context;

        /// <summary>
        /// Dependency injection for Report
        /// </summary>
        /// <param name="context"></param>
        public ReportController(PerfectPolicyContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves special list of questions with quizzes.
        /// </summary>
        /// <returns>A report data regarding questions with quizzes.</returns>
        [HttpGet("QuestionsPerQuizReport")]
        public IActionResult QuestionsPerQuizReport()
        {
            var questionsWithQuizzes = _context.Questions.Include(c => c.Quiz).ToList();

            List<QuestionsPerQuizViewModel> reportData = questionsWithQuizzes.Select(c => new QuestionsPerQuizViewModel
            {
                QuizName = c.Quiz.QuizTitle,
                QuestionCount = c.Quiz.Questions.Count
            }).ToList();

            return (Ok(reportData));
        }
    }
}
