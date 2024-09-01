using AssrePlasto.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AssrePlasto.Controllers;

public class ShopController : BaseController
{
    private readonly ILogger<ShopController> _logger;

    public ShopController(ILogger<ShopController> logger)
    {
        _logger = logger;
    }

    public IActionResult Products()
    {
        try
        {
            return HandleView("Products", "_Products");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while serving the Index view.");
            return StatusCode(500, "Internal server error");
        }
    }

    public IActionResult ProductDetails()
    {
        try
        {
            return HandleView("ProductDetails", "_ProductDetails");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while serving the Index view.");
            return StatusCode(500, "Internal server error");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
