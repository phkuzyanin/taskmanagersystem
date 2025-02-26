using System;
namespace Model.List;

public class ListCard{

    int Id{get;set;}
    string? Name{get; set;}
    int BoardId{get; set;}
    int Position{get; set;}
    public ListCard(int id, string? name, int boardId, int position){
        Id = id;
        Name= name;
        BoardId = boardId;
        Position = position;
    }
}