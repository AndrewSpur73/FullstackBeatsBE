using FullstackBeatsBE.Models;

namespace FullstackBeatsBE.API
{
    public class CategoryAPI
    {
        public static void Map(WebApplication app)
        {
            //Get Categories
            app.MapGet("/categories", (FullstackBeatsBEDbContext db) =>
            {
                var categories = db.Categories.ToList();
                if (categories == null)
                {
                    return Results.StatusCode(204);
                }
                return Results.Ok(categories);
            });

            //Create Category
            app.MapPost("/categories", (FullstackBeatsBEDbContext db, Category category) =>
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return Results.Created($"/categories/{category.Id}", category);
            });

            //Update Category
            app.MapPatch("/categories/{id}", (FullstackBeatsBEDbContext db, int id, Category category) =>
            {
                Category categoryToUpdate = db.Categories.SingleOrDefault(u => u.Id == id);
                if (categoryToUpdate == null)
                {
                    return Results.NotFound();
                }
                categoryToUpdate.Name = category.Name;
                db.SaveChanges();
                return Results.Ok(categoryToUpdate);
            });

            // Delete Category
            app.MapDelete("/categories/{id}", (FullstackBeatsBEDbContext db, int id) =>
            {
                var categoryToDelete = db.Categories.FirstOrDefault(s => s.Id == id);

                if (categoryToDelete == null)
                {
                    return Results.NotFound("No category with matching id");
                }

                db.Categories.Remove(categoryToDelete);
                db.SaveChanges();
                return Results.Ok("Category deleted");
            }); 
        }
    }
}