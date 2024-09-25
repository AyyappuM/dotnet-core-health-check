using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHealthChecks();
var app = builder.Build();

app.UseMiddleware<TokenValidationMiddleware>();

app.MapHealthChecks("/user/health");
app.MapGet("/", () => "Hello World!");

app.Run();
