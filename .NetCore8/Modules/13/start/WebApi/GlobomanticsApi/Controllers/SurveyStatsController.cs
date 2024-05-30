using GlobomanticsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace GlobomanticsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SurveyStatsController : ControllerBase
    {
        [Authorize]
        [HttpGet(Name = "SurveyStats")]
        public SurveyStats Get(string? userEmail)
        {
            return new SurveyStats { UserEmail = userEmail, CompletedSurveys = 6 };
        }
    }
}