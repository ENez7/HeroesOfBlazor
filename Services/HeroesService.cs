using AutoMapper;
using HeroesOfBlazor.Data;
using HeroesOfBlazor.Dto;
using HeroesOfBlazor.Entities;
using HeroesOfBlazor.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HeroesOfBlazor.Services;

public class HeroesService : IHeroesService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public HeroesService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
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

    public async Task<Hero> GetHeroAsync(int id)
    {
        var result = await _context.Heroes.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
        {
            throw new Exception($"Hero with id {id} not found.");
        }
        return result;
    }

    public async Task<UpdateHeroDto> GetHeroForUpdateAsync(int id)
    {
        var result = await _context.Heroes.FirstOrDefaultAsync(h => h.Id == id);
        if (result == null)
        {
            throw new Exception($"Hero with id {id} not found.");
        }
        return _mapper.Map<UpdateHeroDto>(result);
    }

    public async Task<Hero> CreateHeroAsync(CreateHeroDto createHeroDto)
    {
        var existingHero = await _context.Heroes.FirstOrDefaultAsync(x => x.HeroName == createHeroDto.HeroName);
        if (existingHero != null)
        {
            throw new Exception($"Hero with name {createHeroDto.HeroName} already exists.");
        }
        var hero = _mapper.Map<Hero>(createHeroDto);
        _context.Heroes.Add(hero);
        await _context.SaveChangesAsync();
        return hero;
    }

    public async Task<Hero> UpdateHeroAsync(UpdateHeroDto updateHeroDto)
    {
        var existingHero = _context.Heroes.FirstOrDefault(x => x.Id == updateHeroDto.Id)!;
        _mapper.Map(updateHeroDto, existingHero);
        _context.Heroes.Update(existingHero);
        await _context.SaveChangesAsync();
        return existingHero;
    }

    public async Task DeleteHeroAsync(int id)
    {
        var existingHero = await _context.Heroes.FirstOrDefaultAsync(x => x.Id == id);
        _context.Heroes.Remove(existingHero!);
        await _context.SaveChangesAsync();
    }
}