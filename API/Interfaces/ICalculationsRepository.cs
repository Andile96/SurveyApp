using System;
using API.DTOs;

namespace API.Interfaces;

public interface ICalculationsRepository
{
    Task<CalculateStatsDto> GetSurveyStatsAsync();
}
