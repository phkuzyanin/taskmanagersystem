using Models.User;
using Db.ApplicationContext;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Use(RegisterSimulation);
app.Run(async (context) =>{
    using(ApplicationContext db = new ApplicationContext()){
        User tom = new User(1, "Tom", "toms@mail.com", "tompassword");
        User Bob = new User(2, "Bob", "bobs@mail.com", "bobpassword");
        db.User.Add(tom);
        db.User.Add(bob);
        db.SaveChanges();

        var users = db.Users.ToList();
        foreach (User u in users)
        {
            await context.Response.WriteAsync($"{u.Id},   {u.Username},   {u.Email},   {u.CreatedAt}\t");
        }
    }   }
);
app.Run();
/*async Task RegisterSimulation(HttpContext context, Func<Task> next){
    User user = new User(1,"Bob", "bob@email.com", "bob password");
    user.ShowInformation(context, "password");
    user.ShowInformation(context, "bob passwordt");
}*/