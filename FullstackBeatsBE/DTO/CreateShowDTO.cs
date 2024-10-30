namespace FullstackBeatsBE.DTO
{
    public class CreateShowDTO
    {
        public int HostId { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Rsvps { get; set; } = 0;
        public DateTime AirDate { get; set; }
        public int CategoryId { get; set; }

        public string DateFormat => AirDate.ToString("MM/dd/yyy");


    }
}
