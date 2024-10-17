using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace MathsUI
{
    public static class Addition
    {
        [FunctionName("Addition")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            if (!int.TryParse(req.Query["x"], out int x) || !int.TryParse(req.Query["y"], out int y))
            {
                return new BadRequestObjectResult("Both 'x' and 'y' must be provided as integers.");
            }

            int result = x + y;
            return new OkObjectResult(result);
        }
    }

    public static class Subtraction
    {
        [FunctionName("Subtraction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            if (!int.TryParse(req.Query["x"], out int x) || !int.TryParse(req.Query["y"], out int y))
            {
                return new BadRequestObjectResult("Both 'x' and 'y' must be provided as integers.");
            }

            int result = x - y;
            return new OkObjectResult(result);
        }
    }

    public static class Multiplication
    {
        [FunctionName("Multiplication")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            if (!int.TryParse(req.Query["x"], out int x) || !int.TryParse(req.Query["y"], out int y))
            {
                return new BadRequestObjectResult("Both 'x' and 'y' must be provided as integers.");
            }

            int result = x * y;
            return new OkObjectResult(result);
        }
    }

    public static class Division
    {
        [FunctionName("Division")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            if (!int.TryParse(req.Query["x"], out int x) || !int.TryParse(req.Query["y"], out int y))
            {
                return new BadRequestObjectResult("Both 'x' and 'y' must be provided as integers.");
            }

            if (y == 0)
            {
                return new BadRequestObjectResult("Division by zero is not allowed.");
            }

            int result = x / y;
            return new OkObjectResult(result);
        }
    }
}
