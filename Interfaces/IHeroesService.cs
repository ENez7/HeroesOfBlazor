using HeroesOfBlazor.Entities;

namespace HeroesOfBlazor.Interfaces;

public interface IHeroesService
{
    public Task<IEnumerable<Hero>> GetHeroesAsync();
    public Task<IQueryable<Hero>> GetHeroesQueryableAsync();
}