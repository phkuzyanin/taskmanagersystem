using System;
namespace Models.User;
public class User{
    public int Id{get; set;}                        //Хранит id пользователя
    public string? Username{get; set;}               //Хранит имя пользователя
    public string? Email{get; set;}                  //Хранит адресс почты пользователя
    public string? PasswordHash{get; set;}           //Хранит хэш пароля пользователя
    public DateTime CreatedAt{get; set;}             //Хранит вреся создания пользователя
    public User(int id, string username, string email, string password)
    {
        Id = id;
        Username = username;
        Email = email;
        PasswordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 12);
        CreatedAt = DateTime.Now;
    }
}