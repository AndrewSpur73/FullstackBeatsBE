using FullstackBeatsBE.Models;

namespace FullstackBeatsBE.Data
{
    public class UserData
    {

        public static List<User> Users =
        [
           new() { Id = 1,
               Uid = "fgikJy5FMVXz3M8t5DkBSzUp64i2",
               UserName = "Noah",
               Email = "noahcurryallenpa@gmail.com",
               Image = "tech_guru.png",
               About = "Loves exploring new gadgets and technologies." },

           new() { Id = 2,
               Uid = "MJ1mbp0Gm1dnXYqECtMh3PH5dHy2",
               UserName = "Toren",
               Email = "deramust@gmail.com",
               Image = "music_maven.jpg",
               About = "Avid music lover with a passion for discovering new artists." },

           new() { Id = 3,
               Uid = "ghi789",
               UserName = "film_buff",
               Email = "filmbuff@example.com",
               Image = "film_buff.png",
               About = "Movie enthusiast and amateur filmmaker." }
        ];


    }
}
