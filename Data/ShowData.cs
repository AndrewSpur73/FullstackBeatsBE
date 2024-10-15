using FullstackBeatsBE.Models;

namespace FullstackBeatsBE.Data
{
    public class ShowData
    {

        public static List<Show> Shows =
        [
            new() { Id = 1, HostId = 1, Image = "future_tech.jpg", Name = "Future Tech", Description = "Exploring the latest advancements in technology.", Rsvps = 120, AirDate = new DateTime(2024, 10, 20), CategoryId = 1 },
            new() { Id = 2, HostId = 1, Image = "ai_revolution.jpg", Name = "AI Revolution", Description = "How artificial intelligence is changing the world.", Rsvps = 85, AirDate = new DateTime(2024, 11, 5), CategoryId = 1 },
            new() { Id = 3, HostId = 2, Image = "soundwave_live.jpg", Name = "Soundwave Live", Description = "A live concert series featuring emerging artists.", Rsvps = 200, AirDate = new DateTime(2024, 10, 22), CategoryId = 2 },
            new() { Id = 4, HostId = 2, Image = "behind_the_beats.jpg", Name = "Behind the Beats", Description = "Exclusive interviews with top music producers.", Rsvps = 150, AirDate = new DateTime(2024, 11, 10), CategoryId = 2 },
            new() { Id = 5, HostId = 3, Image = "cinema_history.jpg", Name = "Cinema History", Description = "A deep dive into the history of filmmaking.", Rsvps = 95, AirDate = new DateTime(2024, 10, 25), CategoryId = 5 },
            new() { Id = 6, HostId = 3, Image = "indie_scene.jpg", Name = "The Indie Scene", Description = "Spotlighting indie filmmakers and their work.", Rsvps = 110, AirDate = new DateTime(2024, 11, 12), CategoryId = 5 }
        ];

    }
}
