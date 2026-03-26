
using superHero.Data;

namespace superHero.Services
{
    public class SuperHeroService : ISuperHeroServices
    {   
        //private static List<SuperHero> SuperHeroes = new List<SuperHero>
        //{
        //    new SuperHero{id=1,name="spider man",FirstName="Prter",LastName="parker",place="new york"},
        //    new SuperHero{id=2,name="batman",FirstName="vruce",LastName="wayan",place="gotham"}
        //};

        private readonly DataContext _dataContext;
        public SuperHeroService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<SuperHero>> AddSuperHeroesAsync(SuperHero hero)
        {
           await _dataContext.Anguler_Api.AddAsync(hero);
            await _dataContext.SaveChangesAsync();
            return await _dataContext.Anguler_Api.ToListAsync();
        }

        public async Task<List<SuperHero>?> DeleteSuperHeroAsync(int id)
        {
            SuperHero? superHero =await _dataContext.Anguler_Api.FindAsync(id);
            if (superHero == null)
                return null;
            _dataContext.Anguler_Api.Remove(superHero);
            await _dataContext.SaveChangesAsync();
            return await _dataContext.Anguler_Api.ToListAsync();
        }

        public async Task<List<SuperHero>> GetSuperHeroesAsync()
        {
          return await _dataContext.Anguler_Api.ToListAsync();
        }

        public async Task<SuperHero?> GetSuperHeroesByIdAsync(int id)
        {
            SuperHero? superHero = await _dataContext.Anguler_Api.FindAsync(id);
            if (superHero == null)
                return null;
            return superHero;
        }

        public async Task<List<SuperHero>?> UpdateSuperHeroAsync(int id, SuperHero newHero)
        {
            SuperHero? superHero = await _dataContext.Anguler_Api.FindAsync(id);
            if (superHero == null)
                return null;
            superHero.name = newHero.name;
            superHero.email = newHero.email;
            superHero.phone = newHero.phone;
            superHero.gender = newHero.gender;
            superHero.technology=newHero.technology;
            superHero.testing_type=newHero.testing_type;
             await _dataContext.SaveChangesAsync();
            return await _dataContext.Anguler_Api.ToListAsync();
        }
    }
}
