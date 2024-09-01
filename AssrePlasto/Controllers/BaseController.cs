using Microsoft.AspNetCore.Mvc;

namespace AssrePlasto.Controllers;

public class BaseController : Controller
{
    protected IActionResult HandleView(string? viewName = "Index", string partialViewName = "_Index", object? model = null, string? layout = "_Layout")
    {
        ViewData["Layout"] = layout;

        if (Request.Headers.ContainsKey("HX-Request"))
        {
            return PartialView(partialViewName, model);
        }

        if (!string.IsNullOrEmpty(viewName))
        {
            return View(viewName, model);
        }

        return View(model);
    }
}
