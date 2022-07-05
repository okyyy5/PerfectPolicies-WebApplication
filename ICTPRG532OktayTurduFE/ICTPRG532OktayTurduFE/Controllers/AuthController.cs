using ICTPRG532OktayTurduFE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurduFE.Controllers
{
    public class AuthController : Controller
    {
        private readonly HttpClient _client;

        /// <summary>
        /// Initiates dependency injection for AuthController.
        /// </summary>
        /// <param name="httpClientFactory"></param>
        public AuthController(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("ApiClient");
        }

        /// <summary>
        /// Clears all session details, logs user out, and returns them to Home Page.
        /// </summary>
        /// <returns>Redirection to Home Page</returns>
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Returns Login View
        /// </summary>
        /// <returns>Returns Login View</returns>
        public IActionResult Login()
        {
            return View();
        }


        /// <summary>
        /// Reads token and sets session details with provided UserName and Password details.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Index Page</returns>
        [HttpPost]
        public IActionResult Login(UserInfo user)
        {
            // Send the username and password to the API
            HttpResponseMessage result = _client.PostAsJsonAsync("Token/GenerateToken", user).Result;

            if (result.IsSuccessStatusCode)
            {
                // Retrieve the token from the result
                var token = result.Content.ReadAsStringAsync().Result;

                // Tidy up the token and save to the session
                HttpContext.Session.SetString("Token", token.Trim('"'));
                HttpContext.Session.SetString("UserName", user.UserName);

                // Redirect to the Index Page
                return RedirectToAction("Index", "Home");
            }

            return View();

        }
    }
}
