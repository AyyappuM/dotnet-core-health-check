using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHealthChecks();
var app = builder.Build();

app.UseMiddleware<TokenValidationMiddleware>();

app.MapHealthChecks("/health", new HealthCheckOptions
	{
		ResponseWriter = async (context, report) =>
		{
			context.Response.ContentType = "application/json";
			await context.Response.WriteAsync("Healthy");
		}
	});
app.MapGet("/", () => "Hello World!");

app.Run();
