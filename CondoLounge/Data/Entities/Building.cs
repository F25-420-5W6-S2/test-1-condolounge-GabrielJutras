namespace CondoLounge.Data.Entities
{
    public class Building
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public string Address { get; set; }
        public ICollection<Condo> Condos { get; set; }
    }
}
