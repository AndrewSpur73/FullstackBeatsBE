namespace FullstackBeatsBE.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Uid { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Image {  get; set; }
        public string? About { get; set; }
        public List<Show>? WatchShow {  get; set; } 
        public List<Show>? HostShow { get; set; }
    }
}
