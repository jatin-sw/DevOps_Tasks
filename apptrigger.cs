using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class apptrigger
    {
        private readonly ILogger<apptrigger> _logger;

        public apptrigger(ILogger<apptrigger> logger)
        {
            _logger = logger;
        }

        [Function("apptrigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            string secretReference="APPSECRET";
            string? value=System.Environment.GetEnvironmentVariable(secretReference, EnvironmentVariableTarget.Process);
            return new OkObjectResult(value);
        }
    }
}
