using HeroesOfBlazor.Dto;
using HeroesOfBlazor.Entities;

namespace HeroesOfBlazor.Interfaces;

public interface IHeroesService
{
    public Task<IEnumerable<Hero>> GetHeroesAsync();
    public Task<IQueryable<Hero>> GetHeroesQueryableAsync();
    public Task<Hero> GetHeroAsync(int id);
    public Task<UpdateHeroDto> GetHeroForUpdateAsync(int id);
    public Task<Hero> CreateHeroAsync(CreateHeroDto createHeroDto);
    public Task<Hero> UpdateHeroAsync(UpdateHeroDto updateHeroDto);
    public Task DeleteHeroAsync(int id);
}