using System;
namespace Model.Label;

public class Label{
    int Id{get;set;}            //Id метки
    string? Name{get;set;}      //Имя метки
    int Color{get;set;}         //Цвет метки
    int BoardId{get;set;}       //Id доски
    public Label(int id, string? name, int color, int boardId)
    {
        Id = id;
        Name = name;
        Color = color;
        BoardId = boardId;
    }
}