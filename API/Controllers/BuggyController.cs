using System;
using API.DTOs;
using Core.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BuggyController : BaseApiController
{
    [HttpGet("unauthorized")]
    public ActionResult GetUnauthorized()
    {
        return Unauthorized();
    }

    [HttpGet("badrequest")]
    public ActionResult GetBadRequest()
    {
        return BadRequest("This is bad request");
    }

    [HttpGet("notfound")]
    public ActionResult GetNotFound()
    {
        return NotFound();
    }

    [HttpGet("internalerror")]
    public ActionResult GetInternalError()
    {
        throw new Exception("This is a test exception");
    }

    [HttpPost("validationerror")]
    public ActionResult GetValidationError(CreateProductDto product)
    {
        return Ok();
    }
}
