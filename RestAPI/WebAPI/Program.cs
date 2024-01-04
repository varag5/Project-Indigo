using Bll.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using ServiceProvider = Bll.Services.Mock;

namespace WebAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();

			builder.Services.AddOpenApiDocument(configure =>
			{
				configure.Title = "Indigo API";
				configure.Version = "v1";
				configure.Description = "An ASP.NET Web API for the Indigo Project";
			});

			builder.Services.AddTransient<IItineraryService, ServiceProvider.ItineraryService>();
			builder.Services.AddTransient<IRecordingService, ServiceProvider.RecordingService>();
			builder.Services.AddTransient<IRouteService, ServiceProvider.RouteService>();
			builder.Services.AddTransient<IUserService, ServiceProvider.UserService>();

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