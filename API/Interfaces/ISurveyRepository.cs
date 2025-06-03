using System;
using API.Entities;

namespace API.Interfaces;

public interface ISurveyRepository
{
    Task AddSurveyAsync(Survey response);
    Task<List<Survey>> GetAllSurveysAsync();
}
