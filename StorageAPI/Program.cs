
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using StorageAPI.Data;
using StorageAPI.Services;

namespace StorageAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);




            DotNetEnv.Env.Load();

            // Add services to the container.

            builder.Services.AddControllers();
            
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddDbContext<ProductsDbContext>(options => options.UseSqlServer(DotNetEnv.Env.GetString("CONNECTION_STRING")));
            builder.Services.AddScoped<ProductsServices>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
                
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
