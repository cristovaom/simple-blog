using Microsoft.AspNetCore.Mvc;

namespace Blog.controllers;

[Controller]
[Route("api/v1/[controller]")]
public class PostController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Post");
    }
}