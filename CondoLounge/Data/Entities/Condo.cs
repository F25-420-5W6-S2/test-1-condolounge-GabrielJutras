namespace CondoLounge.Data.Entities
{
    public class Condo
    {
        public int Id { get; set; }
        public string CondoNumber { get; set; }

        public int BuildingId { get; set; }
        public Building Building { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }

    }
}
