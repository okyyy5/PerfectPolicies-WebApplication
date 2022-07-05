using ICTPRG532OktayTurduFE.Models;
using ICTPRG532OktayTurduFE.Models.DTO;
using ICTPRG532OktayTurduFE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurduFE.Controllers
{
    public class OptionController : Controller
    {
        private readonly IApiRequest<Question> _questionService;
        private readonly IApiRequest<Option> _optionService;
        private string controllerName = "Option";
        
        /// <summary>
        /// Initiates dependency injection
        /// </summary>
        /// <param name="questionService"></param>
        /// <param name="optionService"></param>
        public OptionController(IApiRequest<Question> questionService, IApiRequest<Option> optionService)
        {
            _questionService = questionService;
            _optionService = optionService;
        }
        /// <summary>
        /// Retrieves index page of Option
        /// </summary>
        /// <returns>Index View of Options</returns>
        // GET: OptionController
        public ActionResult Index()
        {
            var options = _optionService.GetAll(controllerName);
            return View(options);
        }
        /// <summary>
        /// Retrieves the details of a single option with provided ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Details View of a single option</returns>
        // GET: OptionController/Details/5
        public ActionResult Details(int id)
        {
            var options = _optionService.GetSingle(controllerName, id);
            return View(options);
        }
        /// <summary>
        /// Retrieves filtered list of options for a particular Question
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Filtered list of options for a particular Question</returns>
        // GET: OptionController
        public ActionResult OptionsForQuestionID(int id)
        {
            var options = _optionService.GetChildrenForParentID("Option", "GetForQuestionID", id);
            return View("Index", options);
        }
        /// <summary>
        /// Creates a list for choosing a Question to assign option to
        /// </summary>
        /// <returns>Question information</returns>
        // GET: OptionController/Create
        public ActionResult Create()
        {
            var question = _questionService.GetAll("Question");

            var questionSelect = question.Select(c => new SelectListItem
            {
                Value = c.QuestionID.ToString(),
                Text = c.QuestionText
            }).ToList();

            ViewBag.QuestionSelect = questionSelect;

            return View();
        }
        /// <summary>
        /// Creates a new Option with provided details
        /// </summary>
        /// <param name="option"></param>
        /// <returns>Updated database with new option</returns>
        // POST: OptionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OptionCreate option)
        {
            try
            {
                Option newOption = new Option
                {
                    OptionLetter = option.OptionLetter,
                    OptionText = option.OptionText,
                    IsCorrect = option.IsCorrect,
                    QuestionID = option.QuestionID
                };

                _optionService.Create("Option", newOption);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        /// <summary>
        /// Retrieves Option details for Edit Page
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Edit Page with provided details</returns>
        // GET: OptionController/Edit/5
        public ActionResult Edit(int id)
        {
            if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(_optionService.GetSingle(controllerName, id));
        }

        /// <summary>
        /// Initiates Edit for specified Option ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="option"></param>
        /// <returns>Index view with edited option</returns>
        // POST: OptionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Option option)
        {
            try
            {
                if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
                {
                    return RedirectToAction("Login", "Auth");
                }
                _optionService.Edit(controllerName, id, option);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        /// <summary>
        /// If authorised, returns view for deletion page of Option ID alongside its details
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Delete View Page with details of specified Option ID</returns>
        // GET: OptionController/Delete/5
        public ActionResult Delete(int id)
        {
            if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(_optionService.GetSingle("Option", id));
        }


        /// <summary>
        /// If authorised, deletes Option with specified ID, and redirects user to updated Index Page.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="option"></param>
        /// <returns>Redirects User to Updated Option Index page after delete confirmation on delete page.</returns>
        // POST: OptionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Option option)
        {
            try
            {
                if (Helpers.AuthHelper.IsNotLoggedIn(HttpContext))
                {
                    return RedirectToAction("Login", "Auth");
                }
                _optionService.Delete("Option", id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
