using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CondoLounge.Data.Repositories
{
    

    public class CondoLoungeApplicationUserRepository : CondoLoungeGenericGenericRepository<ApplicationUser>, ICondoLoungeApplicationUserRepository
    {
        protected readonly ApplicationDbContext _db;
        protected readonly ILogger<CondoLoungeGenericGenericRepository<ApplicationUser>> _logger;

        public CondoLoungeApplicationUserRepository(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<ApplicationUser>> logger) : base(db, logger)
        {
            _db = db;
            _logger = logger;
        }

        public IEnumerable<ApplicationUser> GetUsersForBuilding(int buildingId)
        {
            return _db.Condos
                .Where(c => c.BuildingId == buildingId)
                .SelectMany(c => c.Users)
                .Distinct()
                .ToList();
        }
    }
}
