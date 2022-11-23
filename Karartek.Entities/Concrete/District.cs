namespace Karartek.Entities.Concrete
{
    public class District
    {
        public District()
        {
            this.Users = new List<User>();
        }

        public int Id { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public City City { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
