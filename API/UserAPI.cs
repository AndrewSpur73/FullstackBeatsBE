using FullstackBeatsBE.Models;

namespace FullstackBeatsBE.API
{
    public class UserAPI
    {
        public static void Map(WebApplication app)
        {
            //LOGIN
            app.MapGet("/checkuser/{uid}", (FullstackBeatsBEDbContext db, string uid) =>
                {
                    var authUser = db.Users.Where(u => u.Uid == uid).FirstOrDefault();
                    if (authUser == null)
                    {
                        return Results.StatusCode(204);
                    }
                    return Results.Ok(authUser);
                });

            //Register User
            app.MapPost("/users", (FullstackBeatsBEDbContext db, User userInfo) =>
            {
                db.Users.Add(userInfo);
                db.SaveChanges();
                return Results.Created($"/users/{userInfo.Id}", userInfo);
            });

            //Check User
            app.MapGet("/users/{id}", (FullstackBeatsBEDbContext db, int id) =>
            {
                User user = db.Users.SingleOrDefault(u => u.Id == id);
                if (user == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(user);
            });

            //Get User Details
            app.MapGet("/users/details/{uid}", (FullstackBeatsBEDbContext db, string uid) =>
            {

                User user = db.Users.SingleOrDefault(u => u.Uid == uid);

                if (user == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(user);
            });
        }
    }
}
