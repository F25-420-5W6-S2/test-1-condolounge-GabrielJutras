using CondoLounge.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace CondoLounge.Data
{
    public class CondoLoungeSeeder
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hosting;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public CondoLoungeSeeder(ApplicationDbContext context,
                IWebHostEnvironment hosting,
                UserManager<ApplicationUser> userManager,
                RoleManager<IdentityRole<int>> roleManager)
        {
            _db = context;
            _hosting = hosting;     //will be used to find the full path of the project 
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            _db.Database.EnsureCreated();

            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole<int>("Admin"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Default"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Building"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Condo"));
            }

            if (!_userManager.Users.Any())
            {
                var user = new ApplicationUser() { UserName = "admin@email.com", Email = "admin@email.com" };
                await _userManager.CreateAsync(user, "VerySecureAdmin45%");
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            //var building = new Building
            //{
            //    BuildingName = "Penfield",
            //    Address = "123 Maple Street",
            //};

            
        }
    }
}
