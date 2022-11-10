using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using class_jwt.ViewModels;
using class_jwt.Models;

namespace class_jwt.Controllers
{
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

    [HttpPost]

    [HttpPost]

    public ActionResult<UserViewModel> Authenticate([FromBody] User user)
    {
    UserViewModel userViewModel = new UserViewModel();
    try
    {
        userViewModel.User = new UserRepository().Get(user);

        if (userViewModel.User == null)
        {
        return NotFound("User not found!");
        }

        userViewModel.Token = new TokenGenerator().Generate();

        userViewModel.User.Password = string.Empty;
    } 
    catch (Exception ex)
    {
        return BadRequest(ex.Message);
    }
    return userViewModel;
    }
    }
}