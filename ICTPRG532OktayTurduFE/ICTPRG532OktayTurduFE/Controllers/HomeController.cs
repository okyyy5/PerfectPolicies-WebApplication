using ChartJSCore.Models;
using CsvHelper;
using ICTPRG532OktayTurduFE.Models;
using ICTPRG532OktayTurduFE.Models.ViewModels;
using ICTPRG532OktayTurduFE.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurduFE.Controllers
{

    
    public class HomeController : Controller
    {
        private readonly IApiRequest<QuestionsPerQuizViewModel> _reportService;
        private readonly ILogger<HomeController> _logger;

        List<QuestionsPerQuizViewModel> _reportData;

        /// <summary>
        /// Initiates dependency injection
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="reportService"></param>
        public HomeController(ILogger<HomeController> logger, IApiRequest<QuestionsPerQuizViewModel> reportService)
        {
            _reportService = reportService;
            _reportData = _reportService.GetAll("Report", "QuestionsPerQuizReport");
            _logger = logger;
        }

        /// <summary>
        /// Creates list of quizzes and returns view with specified quizzes
        /// </summary>
        /// <returns>View of quizzes</returns>
        public IActionResult QuizList()
        {
            string apiURL = "https://localhost:44345/api/Quiz";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage message = client.GetAsync(apiURL).Result;
                List<Quiz> quizzes = message.Content.ReadAsAsync<List<Quiz>>().Result;

                return View(quizzes);
            }
        }

        /// <summary>
        /// Creates chart and modifies chart features for display chart view.
        /// </summary>
        /// <returns>Returns Display Chart view</returns>
        public IActionResult DisplayReport()
        {
            var reportData = _reportService.GetAll("Report", "QuestionsPerQuizReport");


            // Definitions and Declarations for new chart and its data
            Chart chart = new Chart();
            chart.Type = Enums.ChartType.Bar;

            ChartJSCore.Models.Data data = new ChartJSCore.Models.Data();


            // Customizes and Adds Labels to Chart
            data.Labels = reportData.Select(c => c.QuizName).ToList();

            BarDataset dataset = new BarDataset()
            {
                Label = "Question Count",
                Data = reportData.Select(c => (double?)c.QuestionCount).ToList()
            };


            // Adds Data to Chart
            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset);

            chart.Data = data;

            ViewData["chart"] = chart;

            return View("DisplayChart");
        }

        /// <summary>
        /// Outputs a CSV File in accordance to provided data.
        /// </summary>
        /// <returns>.CSV file with data provided</returns>
        public IActionResult ExportCSV()
        {
            var reportData = _reportData;

            var stream = new MemoryStream();

            using (var writeFile = new StreamWriter(stream, leaveOpen: true))
            {
                var csv = new CsvWriter(writeFile, CultureInfo.CurrentCulture, true);
                csv.WriteRecords(reportData);
            }

            stream.Position = 0;
            

            return File(stream, "application/octect-stream", $"ReportData_{DateTime.Now.ToString("ddMM_HHmmss")}.csv");



        }

        /// <summary>
        /// Returns Help Page View
        /// </summary>
        /// <returns>Returns Help Page View</returns>
        public IActionResult Help()
        {
            return View();
        }


        /// <summary>
        /// Returns Index View (Home Page)
        /// </summary>
        /// <returns>Returns Index View (Home Page)</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Returns Privacy Page
        /// </summary>
        /// <returns>Returns Privacy Page View</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Error Handling if model does not exist or response is incorrect
        /// </summary>
        /// <returns>Error View</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
