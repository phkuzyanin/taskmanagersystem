using System;
using Model.List;
namespace Model.Board;

public class Board{
    int Id{get; set;}                   //id доски
    string? Name{get; set;}             //имя доски
    DateTime CreatedAt{get; set;}       //дата создания
    int UserId{get; set;}               //id создателя

    List<ListCard> ListCards;
    public Board(int id, string? name, int userId)
    {
        Id = id;
        Name= name;
        CreatedAt = DateTime.Now;
        UserId = userId;
    }
}