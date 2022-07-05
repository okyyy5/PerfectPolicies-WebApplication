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
    public class OptionController : ControllerBase
    {
        private readonly PerfectPolicyContext _context;

        /// <summary>
        /// Initiates dependency injection for Option Controller
        /// </summary>
        /// <param name="context"></param>
        public OptionController(PerfectPolicyContext context)
        {
            _context = context;
        }

        /// <summary>
        /// All Options stored in database.
        /// </summary>
        /// <returns>All Options for index Page</returns>
        // GET: api/<OptionController>
        [HttpGet]
        public ActionResult<IEnumerable<Option>> Get()
        {
            return Ok(_context.Options.AsEnumerable());
        }

        /// <summary>
        /// Filters and retrieves Options for a specified Question ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Options for specified Question ID</returns>
        // GET: api/<OptionController>/GetForQuestionID
        [HttpGet]
        [Route("GetForQuestionID/{id}")]
        public ActionResult<IEnumerable<Option>> GetForQuestionID(int id)
        {
            return Ok(_context.Options.Where(c => c.QuestionID == id).AsEnumerable());
        }

        /// <summary>
        /// Retrieves Option and its details with specified Option ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns option with specified Option ID</returns>
        // GET api/<OptionController>/5
        [HttpGet("{id}")]
        public ActionResult<Option> Get(int id)
        {
            var option = _context.Options.Find(id);

            if (option == null)
            {
                return NotFound(new { message = "Option has not been found." });
            }

            return Ok(option);
        }
        /// <summary>
        /// Creates new Option with specified details.
        /// </summary>
        /// <param name="option"></param>
        // POST api/<OptionController>
        [HttpPost]
        public void Post([FromBody] OptionCreate option)
        {
            Option newOption = new Option
            {
                OptionText = option.OptionText,
                OptionLetter = option.OptionLetter,
                IsCorrect = option.IsCorrect,
                QuestionID = option.QuestionID
            };

            _context.Options.Add(newOption);

            _context.SaveChanges();
        }


        /// <summary>
        /// Edits specified Option ID and saves new details.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="option"></param>
        /// <returns>Saves edited option and returns OK</returns>
        // PUT api/<OptionController>/5
        [Authorize]
        [HttpPut("{id}")]
        public ActionResult Put(int id, Option option )
        {
            _context.Entry(option).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }


        /// <summary>
        /// Deletes option with specified ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Saves Changes (Deletes Option) and returns OK</returns>
        // DELETE api/<OptionController>/5
        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var option = _context.Options.Find(id);
            if (option != null)
            {
                _context.Options.Remove(option);
                _context.SaveChanges();
                return Ok();
            }

            return BadRequest();
        }
    }
}
