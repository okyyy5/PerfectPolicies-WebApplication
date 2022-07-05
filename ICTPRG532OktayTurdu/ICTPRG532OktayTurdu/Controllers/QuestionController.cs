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
    public class QuestionController : ControllerBase
    {
        private readonly PerfectPolicyContext _context;

        /// <summary>
        /// Initiates dependency injection for Question Controller
        /// </summary>
        /// <param name="context"></param>
        public QuestionController(PerfectPolicyContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all questions for index page
        /// </summary>
        /// <returns>Index of questions</returns>
        // GET: api/<QuestionController>
        [HttpGet]
        public ActionResult<Question> Get()
        {
            return Ok(_context.Questions.AsEnumerable());
        }

        /// <summary>
        /// Seeks filtered list of questions for specified Quiz ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Filtered list of Questions</returns>
        // GET: api/<QuestionController>/GetForQuizID
        [HttpGet]
        [Route("GetForQuizID/{id}")]
        public ActionResult<IEnumerable<Question>> GetForQuizID(int id)
        {
            return Ok(_context.Questions.Where(c => c.QuizID == id).AsEnumerable());
        }

        /// <summary>
        /// Retrieves Question Detail with specified Question ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Question details with specified ID</returns>
        // GET api/<QuestionController>/5
        [HttpGet("{id}")]
        public ActionResult<Question> Get(int id)
        {
            var question = _context.Questions.Find(id);
            if (question == null)
            {
                return NotFound(new { message = "Question has not been found." });
            }

            return Ok(question);
        }

        /// <summary>
        /// Creates question with specified parameters
        /// </summary>
        /// <param name="question"></param>
        // POST api/<QuestionController>
        [HttpPost]
        public void Post([FromBody] QuestionCreate question)
        {
            Question newQuestion = new Question
            {
                QuestionTopic = question.QuestionTopic,
                QuestionText = question.QuestionText,
                QuestionImage = question.QuestionImage,
                QuizID = question.QuizID
            };

            _context.Questions.Add(newQuestion);

            _context.SaveChanges();
        }

        /// <summary>
        /// Edits specified Question ID and Saves edited details.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="question"></param>
        /// <returns>Saves Edited Question with specified details.</returns>
        // PUT api/<QuestionController>/5
        [Authorize]
        [HttpPut("{id}")]
        public ActionResult Put(int id, Question question)
        {
            _context.Entry(question).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }

        /// <summary>
        /// Deletes question with specified ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Saves Changes (Deletes Question) and returns OK</returns>
        // DELETE api/<QuestionController>/5
        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var question = _context.Questions.Find(id);
            if (question != null)
            {
                _context.Questions.Remove(question);
                _context.SaveChanges();
                return Ok();
            }

            return BadRequest();
        }
    }
}
