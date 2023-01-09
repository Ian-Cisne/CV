using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net;
using System.Web;
using System.Collections.Generic;
using System.Text.Json;
using CV.Models;

namespace CV.Controllers;

[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }


}
