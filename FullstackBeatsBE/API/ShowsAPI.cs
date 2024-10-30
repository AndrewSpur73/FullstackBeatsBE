using FullstackBeatsBE.DTO;
using FullstackBeatsBE.Models;
using Microsoft.EntityFrameworkCore;

namespace FullstackBeatsBE.API
{
    public class ShowsAPI
    {
        public static async void Map(WebApplication app)
        {
            //Get All Shows
            app.MapGet("/shows", async (FullstackBeatsBEDbContext db) =>
            {

                var show = await db.Shows
                    .ToListAsync();

                return Results.Ok(show);

            });

            //Get a User's Shows
            app.MapGet("/shows/user/{id}", async (FullstackBeatsBEDbContext db, int id) =>
            {

                var userShows = await db.Shows.Where(s => s.HostId == id).ToListAsync();

                if (userShows == null)
                {
                    return Results.NotFound("No shows found for user.");
                }

                return Results.Ok(userShows);

            });

            //Get a Single Show
            app.MapGet("shows/{id}", async (FullstackBeatsBEDbContext db, int id) =>
            {

                var singleShow = await db.Shows
                .Include(s => s.Host)
                .Include (s => s.Category)
                .FirstOrDefaultAsync(s => s.Id == id);

                if (singleShow == null)
                {
                    return Results.NotFound("No show found.");
                }

                return Results.Ok(singleShow);
            });

            //Create a new show
            app.MapPost("/shows", async (CreateShowDTO showDTO, FullstackBeatsBEDbContext db) =>
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
                    db.Shows.Add(newShow);
                    await db.SaveChangesAsync();
                    return Results.Created($"/shows/{newShow.Id}", newShow);
                }
                catch (DbUpdateException)
                {
                    return Results.BadRequest("Unable to create show");
                }


            });

            //Update a show
            app.MapPut("/shows/{id}", async (int id, UpdateShowDTO showDTO, FullstackBeatsBEDbContext db) =>
            {
                var showToUpdate = await db.Shows.FirstOrDefaultAsync(s => s.Id == id);

                if (showToUpdate == null)
                {
                    return Results.NotFound("No show found.");
                }

                showToUpdate.Image = showDTO.Image;
                showToUpdate.Name = showDTO.Name;
                showToUpdate.Description = showDTO.Description;
                showToUpdate.AirDate = showDTO.AirDate;
                showToUpdate.CategoryId = showDTO.CategoryId;

                try
                {
                    await db.SaveChangesAsync();
                    return Results.Ok(showToUpdate);
                }
                catch (DbUpdateException ex)
                {
                    return Results.BadRequest($"Failed to update show: {ex.Message}");
                }

            });

            //Delete a show
            app.MapDelete("shows/{id}", async (FullstackBeatsBEDbContext db, int id) =>
            {
                var show = await db.Shows
                    .Include(s => s.Attendee)
                    .FirstOrDefaultAsync(s => s.Id == id);

                if (show == null)
                {
                    return Results.NotFound("Show not found.");
                }

                // Remove all associations with the attendees
                show.Attendee.Clear();

                // Remove the show itself
                db.Shows.Remove(show);
                db.SaveChanges();

                return Results.Ok("Show and its associations deleted successfully.");
            });

            //RSVP to a show
            app.MapPost("shows/attend", async (FullstackBeatsBEDbContext db, int showId, int userId) =>
            {

                var show = await db.Shows
                    .Include(s => s.Attendee)  // Include the attendees to manage the relationship
                    .FirstOrDefaultAsync(s => s.Id == showId);

                if (show == null)
                {
                    return Results.NotFound("Show not found.");
                }

                var user = await db.Users
                    .Include(u => u.WatchShow)  // Include WatchShow to manage the relationship
                    .FirstOrDefaultAsync(u => u.Id == userId);

                if (user == null)
                {
                    return Results.NotFound("User not found.");
                }

                // Check if the user is already attending the show
                if (show.Attendee.Any(a => a.Id == userId))
                {
                    return Results.BadRequest("User already RSVPed to this show.");
                }

                // Add the user to the show's attendees
                show.Attendee.Add(user);

                await db.SaveChangesAsync();

                return Results.Ok("RSVP successful.");

            });

            //Get a User's RSVPed shows
            app.MapGet("/shows/attend/{userId}", async (FullstackBeatsBEDbContext db, int userId) =>
            {

                var shows = await db.Shows
                    .Where(s => s.Attendee.Any(u => u.Id == userId))
                    .ToListAsync();

                return Results.Ok(shows);

            });

            //Delete an RSVP
            app.MapDelete("/shows/attend/{userId}/{showId}", async (FullstackBeatsBEDbContext db, int userId, int showId) =>
            {

                var show = await db.Shows
                .Include(s => s.Attendee) 
                .FirstOrDefaultAsync(s => s.Id == showId);

                if (show == null)
                {
                    return Results.NotFound($"Show with ID {showId} not found.");
                }

                var user = show.Attendee.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    return Results.NotFound($"User with ID {userId} is not attending show {showId}.");
                }

                show.Attendee.Remove(user);
                await db.SaveChangesAsync();

                return Results.NoContent(); 

            });
        }
    }
}
