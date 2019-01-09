using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApiTemplate.Filters;
using AspNetCoreApiTemplate.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreApiTemplate.Controllers
{
    [ApiController]
    [CustomExceptionFilter]
    public class BaseController : ControllerBase
    {
    }
}
