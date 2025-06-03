using System;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class SurveyRepository(DataContext _context) : ISurveyRepository
{
    public async Task AddSurveyAsync(Survey response)
    {
        _context.Surveys.Add(response);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Survey>> GetAllSurveysAsync()
    {
        return await _context.Surveys.ToListAsync();
    }
}
