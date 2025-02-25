using System;
namespace Model.User;
class User(){
    int Id{                        //Хранит id пользователя
        get; set;  
    }
    string? Username{               //Хранит имя пользователя
        get; set;
    }
    string? Email{                  //Хранит адресс почты пользователя
        get; set;
    }
    string? PasswordHash{           //Хранит хэш пароля пользователя
        get; set;
    }
    DateTime CreatedAt{             //Хранит вреся создания пользователя
        get; set;
    }
    public User(int id, string username, string email, string password) :this()
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