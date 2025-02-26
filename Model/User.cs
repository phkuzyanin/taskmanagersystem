using System;
namespace Model.User;
public class User{
    int Id{get; set;}                        //Хранит id пользователя
    string? Username{get; set;}               //Хранит имя пользователя
    string? Email{get; set;}                  //Хранит адресс почты пользователя
    string? PasswordHash{get; set;}           //Хранит хэш пароля пользователя
    DateTime CreatedAt{get; set;}             //Хранит вреся создания пользователя
    public User(int id, string username, string email, string password)
    {
        Id = id;
        Username = username;
        Email = email;
        PasswordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 12);
        CreatedAt = DateTime.Now;
    }
    async public void ShowInformation(HttpContext context, string password)
    {
        await context.Response.WriteAsync($"{Id},   {Username},   {Email},   {CreatedAt}\t");
        await context.Response.WriteAsync($"{Convert.ToString(BCrypt.Net.BCrypt.EnhancedVerify(password, PasswordHash))}\t");
    }
}

/*

string password = "Secret Password";
string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);

Console.WriteLine(passwordHash);
Console.WriteLine(BCrypt.Net.BCrypt.EnhancedVerify("Secret Password", passwordHash)); возвращает true

*/