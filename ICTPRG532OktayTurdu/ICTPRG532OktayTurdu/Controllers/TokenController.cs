using ICTPRG532OktayTurdu.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ICTPRG532OktayTurdu.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly PerfectPolicyContext _context;

        #region Config
        public TokenController(IConfiguration config, PerfectPolicyContext context)
        {
            _config = config;
            _context = context;
        }
        #endregion

        #region Public Endpoints


        /// <summary>
        /// Generate token for existing user and assign to user data.
        /// </summary>
        /// <param name="_userData"></param>
        /// <returns>Token for specified _userData</returns>
        [HttpPost]
        [Route("GenerateToken")]
        public IActionResult GenerateToken(UserInfo _userData)
        {
            // Null Checks
            if (_userData != null && _userData.UserName != null && _userData.Password != null)
            {
                // Retrieve user for these credentials
                var user = GetUser(_userData.UserName, _userData.Password);

                // If we have a user that matches the credentials
                if (user != null)
                {
                    // Create Claim Details based on user data
                    var claims = new Claim[] {
                    // JWT Subject
                    new Claim(JwtRegisteredClaimNames.Sub, _config["JWT:Subject"]),
                    // JWT ID
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    // JWT Date/Time
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    // JWT User ID
                    new Claim("Id", user.UserInfoId.ToString()),
                    // JWT UserName
                    new Claim("UserName", user.UserName)
                   };

                    // Generate a new key based on the Key we created and stored in appsettings.json
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
                    // use the generated key to generate new Signing Credentials
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    // Generate a new token based on all of the details generated so far
                    var token = new JwtSecurityToken(
                        _config["JWT:Issuer"],
                        _config["JWT:Audience"],
                        claims,
                        // How long the JWT will be valid for
                        expires: DateTime.UtcNow.AddDays(2),
                        signingCredentials: signIn);

                    // Return the Token via JSON
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Recieves User Details to Save for Token
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns>User information if it exists</returns>
        private UserInfo GetUser(string userName, string passWord)
        {
            var user = _context.Users.Where(c => c.UserName.Equals(userName)).FirstOrDefault();

            if (user != null && user.Password.Equals(passWord))
            {
                return user;
            }
            return null;
        }
        #endregion
    }
}
