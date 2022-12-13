using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Collections.Generic;

namespace CV.Controllers;

[ApiController]
[Route("image")]
public class ImageController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ImageController> _logger;

    public ImageController(ILogger<ImageController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Image> Get()
    {
        IEnumerable<Image> images = new List<Image>();
        foreach (var file in Directory.EnumerateFiles(@"/home/tangram/Proyectos/DBimages/109D7100/"))
        {
            Image image = new Image(File.GetCreationTime(file), file);
            images.Add(image);
        }
        return images.ToArray();
    }
}
