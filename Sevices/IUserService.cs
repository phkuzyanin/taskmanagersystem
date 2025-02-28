using System;
using Models.User;
namespace Services.UserServices;

public interface IUserServices{
    Task<User> Register(User user, string? password);               //Регистрация пользователя
    Task<User> Login(User user, string? login, string? password);   //Вход пользователя
    Task<User> GetUserById(User user);                              //Получение пользователя по ID
    
}