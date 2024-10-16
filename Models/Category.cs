namespace FullstackBeatsBE.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Show>? Show { get; set; }
    }
}
