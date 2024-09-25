public class TokenValidationMiddleware
{
	private readonly RequestDelegate _next;

	public TokenValidationMiddleware(RequestDelegate next)
	{
		_next = next;
	}

	public async Task InvokeAsync(HttpContext context)
	{
		if (context.Request.Path.StartsWithSegments("/health"))
		{
			await _next(context);
			return;
		}

		if (context.Request.Headers.ContainsKey("Authorization"))
		{
			var token = context.Request.Headers["Authorization"].ToString();

			if (token == "Bearer 123")
			{
				await _next(context);				
			}
			else
			{
				context.Response.StatusCode = 401;
				await context.Response.WriteAsync("Unauthorized: Invalid token");
			}
		}
		else
		{
			context.Response.StatusCode = 401;
				await context.Response.WriteAsync("Unauthorized: Not token provided");
		}
	}
}