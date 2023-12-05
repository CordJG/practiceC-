using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MealSystem.Commons.Filters
{
    public class ApiKeyAuthFilter : IAuthorizationFilter
    {
        private const string ApiKeyHeader = "X-Api-Key";
        private const string ApiKey = "Authentication:ApiKey";
        private readonly string? _expectedApiKey;
        public ApiKeyAuthFilter(IConfiguration configuration) 
        {
            _expectedApiKey = configuration[ApiKey];
            /*_expectedApiKey = configuration.GetValue<string>("Authentication:ApiKey");*/
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeader, out var apiKeyValue))
            {
                context.Result = new UnauthorizedObjectResult("API Key not found");
                return;
            }

            if (!apiKeyValue.Equals(_expectedApiKey))
            {
                context.Result = new UnauthorizedObjectResult("Invalid API Key");
            }
        }


    }
}
