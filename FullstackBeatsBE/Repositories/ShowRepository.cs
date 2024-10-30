using FullstackBeatsBE.DTO;
using FullstackBeatsBE.Interfaces;
using FullstackBeatsBE.Models;
using Microsoft.EntityFrameworkCore;


namespace FullstackBeatsBE.Repositories
{
    public class ShowRepository : IShowRepository
    {
        private readonly FullstackBeatsBEDbContext _context;

        public ShowRepository(FullstackBeatsBEDbContext context)
        {
            _context = context;
        }

        //Get all Shows
        public async Task<List<Show>> GetAllShowsAsync()
        {
            {

                var show = await _context.Shows
                    .ToListAsync();

                if (show == null)
                {
                    return null;
                }

                return show;

            };
        }


        //Create a show
        public async Task<Show> CreateShowAsync(CreateShowDTO showDTO)
        {

            var newShow = new Show
            {
                HostId = showDTO.HostId,
                Image = showDTO.Image,
                Name = showDTO.Name,
                Description = showDTO.Description,
                Rsvps = showDTO.Rsvps,
                AirDate = showDTO.AirDate,
                CategoryId = showDTO.CategoryId,

            };

            try
            {
                _context.Shows.Add(newShow);
                await _context.SaveChangesAsync();
                return newShow;
            }
            catch (DbUpdateException)
            {
                return null;
            }

        }


        //Update a show
        public async Task<Show> UpdateShowAsync(int id, UpdateShowDTO showDTO)
        {
            var showToUpdate = await _context.Shows.FirstOrDefaultAsync(s => s.Id == id);

            if (showToUpdate == null)
            {
                return null;
            }

            showToUpdate.Image = showDTO.Image;
            showToUpdate.Name = showDTO.Name;
            showToUpdate.Description = showDTO.Description;
            showToUpdate.AirDate = showDTO.AirDate;
            showToUpdate.CategoryId = showDTO.CategoryId;

            try
            {
                await _context.SaveChangesAsync();
                return showToUpdate;
            }
            catch (DbUpdateException ex)
            {
                return null;
            }
        }
    
        //Delete a show
        public async Task<Show> DeleteShowAsync(int id)
        {

            var show = await _context.Shows
                    .Include(s => s.Attendee)
                    .FirstOrDefaultAsync(s => s.Id == id);

            if (show == null)
            {
                return null;
            }

            // Remove all associations with the attendees
            show.Attendee.Clear();

            // Remove the show itself
            _context.Shows.Remove(show);
            _context.SaveChanges();

            return show;

        }
    }
}
