using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController > logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult Index()
    {  
        return View();
    }
}
