﻿namespace S36_ConsoleApp_EfCore_DbDesign.Entities;

public class Like
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int UserId { get; set; }

}