using ICTPRG532OktayTurduFE.Models;
using ICTPRG532OktayTurduFE.Models.DTO;
using ICTPRG532OktayTurduFE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurduFE.Controllers
{
    public class QuizController : Controller
    {
        private readonly IApiRequest<Quiz> _quizService;

        private string controllerName = "Quiz";

        /// <summary>
        /// Initiates dependency injection for Quiz Controller
        /// </summary>
        /// <param name="quizService"></param>
        public QuizController(IApiRequest<Quiz> quizService)
        {
            _quizService = quizService;
        }

        /// <summary>
        /// Retrieves all Quizzes and returns view of index Page
        /// </summary>
        /// <returns>Index view page with list of quizzes</returns>
        // GET: QuizController
        public ActionResult Index()
        {
            var quizes = _quizService.GetAll(controllerName);
            return View(quizes);
        }


        /// <summary>
        /// Provides view for details of single quiz data
        /// </summary>
        /// <param name="id"></param>
        /// <returns>View for quiz details of specified ID</returns>
        // GET: QuizController/Details/5
        public ActionResult Details(int id)
        {
            var quiz = _quizService.GetSingle(controllerName, id);
            return View(quiz);
        }

        /// <summary>
        /// Returns Create View for new Quiz
        /// </summary>
        /// <returns>Returns Create View for new Quiz</returns>
        // GET: QuizController/Create
        public ActionResult Create()
        {
            return View();
        }


        /// <summary>
        /// Adds Details for New Quiz for processing in the back-end, and redirects
        /// to Quiz Index Page.
        /// </summary>
        /// <param name="quiz"></param>
        /// <returns>Updated Index Page view with new Quiz</returns>
        // POST: QuizController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QuizCreate quiz)
        {
            try
            {
                Quiz newQuiz = new Quiz()
                {
                    QuizTitle = quiz.QuizTitle,
                    QuizAuthor = quiz.QuizAuthor,
                    QuizDate = quiz.QuizDate,
                    QuizTopic = quiz.QuizTopic,
                    QuizPass = quiz.QuizPass,
                };
                _quizService.Create(controllerName, newQuiz);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        /// <summary>
        /// Produces edit view with details of Quiz in accordance with specified ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>View with details of a single quiz in accordance with specified ID</returns>
        // GET: QuizController/Edit/5
        public ActionResult Edit(int id)
        {
           if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(_quizService.GetSingle(controllerName,id));
        }


        /// <summary>
        /// Redirect user to updated Quiz Index Page with Edited Quiz
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quiz"></param>
        /// <returns>Quiz Index Page with updated Quiz</returns>
        // POST: QuizController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Quiz quiz)
        {
            try
            {
                if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
                {
                    return RedirectToAction("Login", "Auth");
                }

                _quizService.Edit(controllerName, id, quiz);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        /// <summary>
        /// If authorised, returns view for deletion page of Quiz ID alongside its details
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Delete View Page with details of specified Quiz ID</returns>
        // GET: QuizController/Delete/5
        public ActionResult Delete(int id)
        {
            if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(_quizService.GetSingle(controllerName,id));
        }


        /// <summary>
        /// If authorised, deletes Quiz with specified ID, and redirects user to updated Index Page.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns>Redirects User to Updated Index page after delete confirmation on delete page.</returns>
        // POST: QuizController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
                {
                    return RedirectToAction("Login", "Auth");
                }

                _quizService.Delete(controllerName, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
