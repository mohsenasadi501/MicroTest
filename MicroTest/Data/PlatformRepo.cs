using MicroTest.Models;
namespace MicroTest.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _appDbContext;

        public PlatformRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void CreatePlatform(Platform platform)
        {
            if (platform == null) throw new ArgumentNullException();
            else
                _appDbContext.Platforms.Add(platform);
        }
        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _appDbContext.Platforms.ToList();
        }
        public Platform GetPlatformById(int id)
        {
            return _appDbContext.Platforms.FirstOrDefault(p => p.Id == id);
        }
        public bool SaveChanges()
        {
            return _appDbContext.SaveChanges() >= 0;
        }
    }
}
