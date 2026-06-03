using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interfaces;

using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Models;

public class Book : Media, IBorrowable
{
    private bool isBorrowed;

    public string Author { get; set; } = "";

    public int CategoryId { get; set; }

    public bool IsBorrowed => isBorrowed;

    public Book()
    {
    }

    public Book(
        int id,
        string title,
        string author,
        decimal price,
        string category)
    {
        Id = id;
        Title = title;
        Author = author;
        Price = price;
        Category = category;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"{Id} | {Title} | {Author} | {Price} | {Category} | {(isBorrowed ? "Đã mượn" : "Có sẵn")}");
    }

    public void Borrow()
    {
        isBorrowed = true;
    }

    public void Return()
    {
        isBorrowed = false;
    }
}