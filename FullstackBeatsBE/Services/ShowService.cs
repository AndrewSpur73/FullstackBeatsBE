using FullstackBeatsBE.DTO;
using FullstackBeatsBE.Interfaces;
using FullstackBeatsBE.Models;

namespace FullstackBeatsBE.Services
{
    public class ShowService : IShowService
    {

        private readonly IShowRepository _showRepo;

        public ShowService(IShowRepository showRepo)
        {
            _showRepo = showRepo;
        }

        public async Task<Show> CreateShowAsync(CreateShowDTO showDTO)
        {
            return await _showRepo.CreateShowAsync(showDTO);
        }

        public async Task<Show> DeleteShowAsync(int id)
        {
            return await _showRepo.DeleteShowAsync(id);
        }

        public async Task<List<Show>> GetAllShowsAsync()
        {
            return await _showRepo.GetAllShowsAsync();
        }

        public async Task<Show> GetShowByIdAsync(int id)
        {
            var singleShow = _showRepo.GetShowByIdAsync(id);

            if (singleShow == null)
            {
                throw new ArgumentException("Show not found.");
            }

            return await _showRepo.GetShowByIdAsync(id);

        }

        public async Task<Show> UpdateShowAsync(int id, UpdateShowDTO showDTO)
        {
            return await _showRepo.UpdateShowAsync(id, showDTO);

        }
    }
}
