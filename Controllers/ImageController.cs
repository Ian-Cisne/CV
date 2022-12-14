using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net;
using System.Web;
using System.Collections.Generic;
using System.Text.Json;
namespace CV.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ImageController : ControllerBase
{
    private readonly ILogger<ImageController> _logger;

    public ImageController(ILogger<ImageController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public JsonResult Get()
    {
        List<Image> images = new List<Image>();
        try{
            foreach (var file in Directory.EnumerateFiles(@"/home/geomatra/Proyectos/DBimages/109D7100/"))
            {
                Image image = new Image(System.IO.File.GetCreationTime(file), file);
                images.Add(image);
            }
        }
        catch(DirectoryNotFoundException e){
            return new JsonResult(string.Concat("{\"error\": \"", e.Message ,"\"}"));
        }
        return new JsonResult(images);
    }
}
