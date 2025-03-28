using System;
using Models.List;
namespace Models.Board;

public class Board{
    int Id{get; set;}                   //id доски
    string? Name{get; set;}             //имя доски
    DateTime CreatedAt{get; set;}       //дата создания
    int UserId{get; set;}               //id создателя

    public Board(int id, string? name, int userId)
    {
        Id = id;
        Name= name;
        CreatedAt = DateTime.Now;
        UserId = userId;
    }
}