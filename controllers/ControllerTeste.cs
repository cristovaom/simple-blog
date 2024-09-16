using Microsoft.AspNetCore.Mvc;

namespace Blog.controllers;

[Route("api/v1/[controller]")]
public class ControllerTeste : ControllerBase
{

    [HttpGet]
    [Route("get")]
    public IActionResult Get()
    {
        return Ok("Hello World");
    }
}