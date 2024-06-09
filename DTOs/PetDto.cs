namespace pet_mart_api.DTOs
{
    public class PetDto
    {
        public required string Name { get; set; }
        public required string Type { get; set; }
        public int Age { get; set; }
        public string? Description { get; set; }
    }
}
