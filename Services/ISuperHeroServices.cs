namespace superHero.Services
{
    public interface ISuperHeroServices
    {
        Task<List<SuperHero>> GetSuperHeroesAsync();
        Task<SuperHero?> GetSuperHeroesByIdAsync(int id);
        Task<List<SuperHero>> AddSuperHeroesAsync(SuperHero hero);
        Task<List<SuperHero>?> UpdateSuperHeroAsync(int id, SuperHero newHero);
        Task<List<SuperHero>?> DeleteSuperHeroAsync(int id);
    }
}
