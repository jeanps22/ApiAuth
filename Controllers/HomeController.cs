using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApiAuth.Models;
using Microsoft.AspNetCore.Authorization;

namespace ApiAuth.Controllers;

[ApiController]
[Route("v1")]
public class HomeController : ControllerBase
{
    [HttpGet]
    [Route("anonymous")]
    [AllowAnonymous]
    public string Anonymous() => "An�nimo";

    [HttpGet]
    [Route("authenticated")]
    [Authorize]
    public string Authenticated() => "Autorizado";

    [HttpGet]
    [Route("manager")]
    [Authorize(Roles = "manager")]
    public string Manager() => "Gerente";

    [HttpGet]
    [Route("employee")]
    [Authorize(Roles = "employee, manager")]
    public string Employee() => "Funcion�rio";
}
