using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurduFE.Helpers
{
    /// <summary>
    /// Checks if user is not logged in.
    /// </summary>
    public static class AuthHelper
    {
        public static bool IsNotLoggedIn(HttpContext context)
        {
            if (!context.Session.Keys.Any(c => c.Equals("Token")))
            {
                return true;
            }
            return false;
        }
    }
}
