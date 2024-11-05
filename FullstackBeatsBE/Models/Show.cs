namespace FullstackBeatsBE.Models
{
    public class Show
    {
        public int Id { get; set; }
        public int HostId { get; set; }
        public string? Image {  get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Rsvps { get; set; }
        public DateTime AirDate { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<User>? Attendee { get; set; }
        public User? Host { get; set; }

        public string AirDateFormatted => AirDate.ToString("yyyy-MM-dd");


    }
}
