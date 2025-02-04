using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fngetmoviedetail
{
    public class GetMovieDetail
    {
        private readonly ILogger<GetMovieDetail> _logger;

        public GetMovieDetail(ILogger<GetMovieDetail> logger)
        {
            _logger = logger;
        }

        [Function("GetMovieDetail")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
