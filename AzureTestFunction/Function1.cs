using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureTestFunction
{
    public static class Function
    {
        [FunctionName("HTTPFunction")]
        public static async Task<IActionResult> Run(
           [HttpTrigger(AuthorizationLevel.Admin, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string name = req.Query["name"];

            string responseMessage = $"Hello, {name}. This HTTP triggered function executed successfully.....Reddy123";

            return new OkObjectResult(responseMessage);
        }
    }
}

