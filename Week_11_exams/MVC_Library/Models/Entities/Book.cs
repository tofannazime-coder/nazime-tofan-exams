using System;

namespace MVC_Library.Models.Entities;

public class Book
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public int PageCount { get; set; }

}
