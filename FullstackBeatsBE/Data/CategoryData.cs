using FullstackBeatsBE.Models;

namespace FullstackBeatsBE.Data
{
    public class CategoryData
    {
        public static List<Category> Categories =
        [
            new() { Id = 1, Name = "Music" },
            new() { Id = 2, Name = "Comedy" },
            new() { Id = 3, Name = "Education" },
            new() { Id = 4, Name = "Gaming" },
            new() { Id = 5, Name = "Presentation" }
        ];
    }
}
