using System;
namespace Model.UserBoard;

public class UserBoard{
    int Id{get;set;}                    //id участника доски
    int UserId{get;set;}                //id пользователя
    int BoardId{get;set;}               //id доски
    public UserBoard(int id, int userId, int boardId)
    {
        Id = id;
        UserId = userId;
        BoardId = boardId;
    }
}