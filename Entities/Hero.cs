namespace HeroesOfBlazor.Entities;

public class Hero
{
    public int Id { get; set; }
    public string HeroName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
}