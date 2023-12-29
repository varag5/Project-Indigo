using Bll.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			//builder.Services.AddEndpointsApiExplorer();
			//builder.Services.AddSwaggerGen();

			builder.Services.AddOpenApiDocument(configure =>
			{
				configure.Title = "Indigo API";
				configure.Version = "v1";
				configure.Description = "An ASP.NET Web API for the Indigo Project";
			});

			builder.Services.AddTransient<IItineraryService, Bll.Services.Mock.ItineraryService>();
			builder.Services.AddTransient<IRecordingService, Bll.Services.Mock.RecordingService>();
			builder.Services.AddTransient<IRouteService, Bll.Services.Mock.RouteService>();
			builder.Services.AddTransient<IUserService, Bll.Services.Mock.UserService>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseOpenApi();
				app.UseSwaggerUi3();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}