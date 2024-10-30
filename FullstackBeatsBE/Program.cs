using System.Text.Json.Serialization;
using FullstackBeatsBE.API;
using FullstackBeatsBE.Interfaces;
using FullstackBeatsBE.Repositories;
using FullstackBeatsBE.Services;
using Microsoft.AspNetCore.Http.Json;

namespace FullstackBeatsBE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(typeof(Program)); //Adds AutoMapper to the build
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.WithOrigins("http://localhost:3000", "https://localhost:8000")
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .AllowAnyHeader();
                });
            });

            // allows passing datetimes without time zone data 
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            // allows our api endpoints to access the database through Entity Framework Core
            builder.Services.AddNpgsql<FullstackBeatsBEDbContext>(builder.Configuration["FullstackBeatsBEDbConnectionString"]);

            builder.Services.Configure<JsonOptions>(options =>
            {
                options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });

            builder.Services.AddScoped<IShowRepository, ShowRepository>();
            builder.Services.AddScoped<IShowService, ShowService>();

            var app = builder.Build();

            app.UseCors();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            UserAPI.Map(app);
            ShowsAPI.Map(app);
            CategoryAPI.Map(app);

            app.Run();
        }
    }
}
