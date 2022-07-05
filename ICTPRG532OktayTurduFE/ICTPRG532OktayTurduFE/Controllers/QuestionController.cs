using ICTPRG532OktayTurduFE.Models;
using ICTPRG532OktayTurduFE.Models.DTO;
using ICTPRG532OktayTurduFE.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurduFE.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        private readonly IApiRequest<Quiz> _quizService;
        private readonly IApiRequest<Question> _questionService;
        private string controllerName = "Question";

        /// <summary>
        /// Initiates dependency injection
        /// </summary>
        /// <param name="quizService"></param>
        /// <param name="questionService"></param>
        /// <param name="hostingEnvironment"></param>
        public QuestionController(IApiRequest<Quiz> quizService,IApiRequest<Question> questionService, IWebHostEnvironment hostingEnvironment)
        {
            _quizService = quizService;
            _questionService = questionService;
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Retrieves index page of Question
        /// </summary>
        /// <returns>Index View of Questions</returns>
        // GET: QuestionController
        public ActionResult Index()
        {
            var questions = _questionService.GetAll(controllerName);
            return View(questions);
        }

        /// <summary>
        /// Retrieves the details of a single question with provided ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Details View of a single Question</returns>
        // GET: QuestionController/Details/5
        public ActionResult Details(int id)
        {
            var questions = _questionService.GetSingle(controllerName, id);
            return View(questions);
        }

        /// <summary>
        /// Retrieves filtered list of questions for a particular Quiz
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Filtered list of questions for a particular Quiz</returns>
        // GET: QuestionController
        public ActionResult QuestionsForQuizID(int id)
        {
            var questions = _questionService.GetChildrenForParentID("Question", "GetForQuizID", id);
            return View("Index", questions);
        }

        /// <summary>
        /// Creates a list for choosing a Quiz to assign Question to
        /// </summary>
        /// <returns>Quiz Information</returns>
        // GET: QuestionController/Create
        public ActionResult Create()
        {
            var quiz = _quizService.GetAll("Quiz");

            var quizSelect = quiz.Select(c => new SelectListItem
            {
                Value = c.QuizID.ToString(),
                Text = c.QuizTitle
            }).ToList();

            ViewBag.QuizSelect = quizSelect;

            return View();
        }

        /// <summary>
        /// Creates a new Question with provided details
        /// </summary>
        /// <param name="question"></param>
        /// <returns>Updated database with new Question</returns>
        // POST: QuestionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QuestionCreate question)
        {
            try
            {
                Question newQuestion = new Question
                {
                    QuestionTopic = question.QuestionTopic,
                    QuestionText = question.QuestionText,
                    QuestionImage = question.QuestionImage,
                    QuizID = question.QuizID
                };

                _questionService.Create("Question", newQuestion);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// Retrieves Question details for Edit Page
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Question Edit Page with provided details</returns>
        // GET: QuestionController/Edit/5
        public ActionResult Edit(int id)
        {

            if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(_questionService.GetSingle(controllerName, id));
        }

        /// <summary>
        /// Initiates Edit for specified Question ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="question"></param>
        /// <returns>Index view with edited Question</returns>
        // POST: QuestionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Question question)
        {
            try
            {
                if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
                {
                    return RedirectToAction("Login", "Auth");
                }
                _questionService.Edit(controllerName, id, question);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// If authorised, returns view for deletion page of Question ID alongside its details
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Delete View Page with details of specified Question ID</returns>
        // GET: QuestionController/Delete/5
        public ActionResult Delete(int id)
        {
            if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(_questionService.GetSingle("Question", id));
        }

        /// <summary>
        /// If authorised, deletes Question with specified ID, and redirects user to updated Index Page.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="question"></param>
        /// <returns>Redirects User to Updated Question Index page after delete confirmation on delete page.</returns>
        // POST: QuestionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Question question)
        {
            try
            {
                if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
                {
                    return RedirectToAction("Login", "Auth");
                }
                _questionService.Delete("Question", id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// Method that uploads files
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Ok if file is successfully updated.</returns>
        // Upload POST
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            string folderRoot = Path.Combine(_hostingEnvironment.ContentRootPath, "wwwroot\\uploads");
            string filePath = Path.Combine(folderRoot, file.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(new { success = true, message = "File Uploaded" });
        }
    }
}
