var builder = WebApplication.CreateSlimBuilder(args);
var port = Environment.GetEnvironmentVariable("PORT") ?? "80";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () => Results.Json(new { message = "API works!" })); 
app.MapGet("/health", () => Results.Ok("I'm alive!"))
.WithName("health");

app.Run();


