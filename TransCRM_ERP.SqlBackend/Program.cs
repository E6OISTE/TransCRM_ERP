using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;
using TransCRM_ERP.Infrastructure;
using AutoMapper;

namespace TransCRM_ERP.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllers()
                .AddJsonOptions(option => option.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

            // Connect to Db
            //var connection = builder.Configuration.GetConnectionString("SqliteConnection");
            //builder.Services.AddDbContext<AppDbContext>(option =>
            //    option.UseSqlite($"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "sqliteDbTrans.db")}"));

            // CORS
            // app.UseCors()
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                await db.Database.MigrateAsync();
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            if (app.Environment.IsProduction())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapControllers();

            app.UseCors();

            app.Run();
        }
    }
}