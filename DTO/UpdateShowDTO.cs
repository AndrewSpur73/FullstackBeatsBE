namespace FullstackBeatsBE.DTO
{
    public class UpdateShowDTO
    {
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime AirDate { get; set; }
        public int CategoryId { get; set; }

        public string DateFormat => AirDate.ToString("MM/dd/yyy");


    }
}
