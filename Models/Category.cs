namespace FullstackBeatsBE.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Show? Show { get; set; }
    }
}
