using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CondoLounge.Data.Repositories
{
    public class CondoLoungeCondoRepository : CondoLoungeGenericGenericRepository<Condo>, ICondoLoungeCondoRepository
    {
        protected readonly ApplicationDbContext _db;
        protected readonly ILogger<CondoLoungeGenericGenericRepository<Condo>> _logger;

        public CondoLoungeCondoRepository(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Condo>> logger) : base(db, logger)
        {
            _db = db;
            _logger = logger;
        }

        public IEnumerable<Condo> GetCondosForBuilding(int buildingId)
        {
            return _db.Condos
                .Include(c => c.Building)
                .Where(c => c.BuildingId == buildingId)
                .ToList();
        }
    }
}
