using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CZBooks_WebAPI.Domains;
using CZBooks_WebAPI.Interfaces;
using CZBooks_WebAPI.Repositories;
using System;

namespace CZBooks_WebAPI.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]

    [Authorize(Roles = "1")]
    public class AutorController
    {


    }
}
