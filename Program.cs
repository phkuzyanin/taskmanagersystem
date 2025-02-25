using Model.User;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Use(RegisterSimulation);


app.Run();
async Task RegisterSimulation(HttpContext context, Func<Task> next){
    User user = new User(1,"Bob", "bob@email.com", "bob password");
    user.ShowInformation(context, "password");
    user.ShowInformation(context, "bob passwordt");
}