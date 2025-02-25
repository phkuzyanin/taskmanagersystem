var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Use(Configure);


app.Run();
async Task Configure(HttpContext context, Func<Task> next){
    context.Response.ContentType = "text/plain; charset=utf-8";
    await context.Response.WriteAsync("Сработал  Use");
}