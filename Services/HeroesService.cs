using HeroesOfBlazor.Data;
using HeroesOfBlazor.Entities;
using HeroesOfBlazor.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HeroesOfBlazor.Services;

public class HeroesService : IHeroesService
{
    private readonly ApplicationDbContext _context;

    public HeroesService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Hero>> GetHeroesAsync()
    {
        var result = await _context.Heroes.ToListAsync();
        return result;
    }

    public Task<IQueryable<Hero>> GetHeroesQueryableAsync()
    {
        var query = _context.Heroes.AsQueryable();
        return Task.FromResult(query);
    }
}