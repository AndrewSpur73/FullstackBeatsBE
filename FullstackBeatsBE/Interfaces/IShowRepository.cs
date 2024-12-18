﻿using FullstackBeatsBE.DTO;
using FullstackBeatsBE.Models;

namespace FullstackBeatsBE.Interfaces
{
    public interface IShowRepository
    {
     
        Task<List<Show>> GetAllShowsAsync();
        Task<Show> CreateShowAsync(CreateShowDTO showDTO);
        Task<Show> UpdateShowAsync(int id, UpdateShowDTO showDTO);
        Task<Show> DeleteShowAsync(int id);
        Task<Show> GetShowByIdAsync(int id);


    }
}
