using API.DTOs;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController(ISurveyRepository surveyRepository,
    ICalculationsRepository calculationsRepository) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SubmitSurvey([FromBody] SurveyDto surveyDto)
        {
            if (surveyDto == null)
            {
                return BadRequest("Survey data is required.");
            }

            var survey = new Survey
            {
                FullNames = surveyDto.FullName,
                Email = surveyDto.Email,
                Age = surveyDto.Age,
                FavoriteFoods = surveyDto.FavoriteFoods,
                EatingOutRating = surveyDto.EatOutRating,
                WatchingMoviesRating = surveyDto.WatchMoviesRating,
                WatchingTvRating = surveyDto.WatchTvRating,
                ListeningRadioRating = surveyDto.ListenRadioRating
            };

            await surveyRepository.AddSurveyAsync(survey);
            return Ok(new { message = "Survey submitted successfully." });
        }
        [HttpGet]
        public async Task<IActionResult> GetSurveyStats()
        {
            var surveys = await calculationsRepository.GetSurveyStatsAsync();
            if (surveys == null)
            {
                return NotFound("No survey statistics found.");
            }
           
            return Ok(surveys);
        }

        
    }
}
