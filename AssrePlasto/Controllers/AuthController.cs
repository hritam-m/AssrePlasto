using AssrePlasto.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AssrePlasto.Controllers;

public class AuthController : BaseController
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return HandleView("Login", "_Login", layout: "_AuthLayout");
    }

    public IActionResult Register()
    {
        return HandleView("Register", "_Register", layout: "_AuthLayout");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
