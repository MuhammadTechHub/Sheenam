//=========================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to Use comfort and Peace
//==========================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController 
    {
        [HttpGet]
        public ActionResult<string> Get() => Ok("Welcome to Sheenam API");
    }
}
