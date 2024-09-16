using Microsoft.AspNetCore.Mvc;

namespace Blog.controllers;

[Controller]
[Route("api/v1/[controller]")]
public class CommentController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("cOMENTARIO");
    }
}