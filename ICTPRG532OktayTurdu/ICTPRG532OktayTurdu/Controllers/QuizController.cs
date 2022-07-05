using ICTPRG532OktayTurdu.DTO;
using ICTPRG532OktayTurdu.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ICTPRG532OktayTurdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly PerfectPolicyContext _context;

        /// <summary>
        /// initiates dependency injection for Quiz Controller
        /// </summary>
        /// <param name="context"></param>
        public QuizController(PerfectPolicyContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Retrieves All Quizzes From Database
        /// </summary>
        /// <returns>All Quizzes in Database</returns>
        // GET: api/<QuizController>
        [HttpGet]
        public ActionResult<IEnumerable<Quiz>> Get()
        {
            return Ok(_context.Quizzes.AsEnumerable());
        }
        /// <summary>
        /// Retrieves Quiz infromation that is related to that particular ID of Quiz
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Quiz related to provided ID</returns>
        // GET api/<QuizController>/5
        [HttpGet("{id}")]
        public ActionResult<Quiz> Get(int id)
        {
            var Quiz = _context.Quizzes.Find(id);

            if (Quiz == null)
            {
                return NotFound(new { message = "Quiz has not been found." });
            }

            return Ok(Quiz);
        }
        /// <summary>
        /// Creates new Quiz with provided information
        /// </summary>
        /// <param name="quiz"></param>
        // POST api/<QuizController>
        [HttpPost]
        public void Post([FromBody] QuizCreate quiz)
        {
            Quiz newQuiz = new Quiz
            {
                QuizTitle = quiz.QuizTitle,
                QuizTopic = quiz.QuizTopic,
                QuizAuthor = quiz.QuizAuthor,
                QuizDate = quiz.QuizDate,
                QuizPass = quiz.QuizPass
            };

            _context.Quizzes.Add(newQuiz);

            _context.SaveChanges();
        }
        /// <summary>
        /// Modifies a particular quiz with provided ID with new provided information
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quiz"></param>
        /// <returns>The particular quiz with the new information</returns>
        // PUT api/<QuizController>/5
        [Authorize]
        [HttpPut("{id}")]
        public ActionResult Put(int id, Quiz quiz)
        {
            _context.Entry(quiz).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }
        /// <summary>
        /// Deletes Quiz with specified ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Database with the specified quiz deleted</returns>
        // DELETE api/<QuizController>/5
        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var quiz = _context.Quizzes.Find(id);
            if (quiz != null)
            {
                _context.Quizzes.Remove(quiz);
                _context.SaveChanges();
                return Ok();
            }

            return BadRequest();
        }
    }
}
