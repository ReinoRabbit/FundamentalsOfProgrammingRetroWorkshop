using Services.Services;
using Services.Interfaces;
using Adapters;

namespace FundamentalsOfProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IImageServices, ImageService>();
            builder.Services.AddScoped<IImageAdapter, ImageAdapter>();
            builder.Services.AddScoped<IFactorialService, FactorialService>();//Added dependency after making Service public for access
            builder.Services.AddScoped<IReverseService, ReverseService>(); //added dependency after making service public for access

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
