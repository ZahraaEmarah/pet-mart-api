namespace pet_mart_api.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public int OwnerID { get; set; } // Foreign Keys
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public bool Vaccinated { get; set; }
        public int Likes { get; set; }
        public string? Description { get; set; }
        public string Image { get; set; }
        public User Owner { get; set; }
    }
}
