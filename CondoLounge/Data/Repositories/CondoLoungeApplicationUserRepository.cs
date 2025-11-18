using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class CondoLoungeApplicationUserRepository : CondoLoungeGenericGenericRepository<ApplicationUser>, ICondoLoungeApplicationUserRepository
    {
        public CondoLoungeApplicationUserRepository(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<ApplicationUser>> logger) : base(db, logger)
        {
        }
    }
}
