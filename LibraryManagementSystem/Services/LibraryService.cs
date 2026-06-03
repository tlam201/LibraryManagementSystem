using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services;

public class LibraryService
{
    private readonly List<Book> books = new();
    private readonly List<Category> categories = new();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void AddCategory(Category category)
    {
        categories.Add(category);
    }

    public void DisplayBooks()
    {
        foreach (var book in books)
        {
            book.DisplayInfo();
        }
    }

    public List<Book> SearchBook(string keyword)
    {
        return books
            .Where(x => x.Title.Contains(
                keyword,
                StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public void DeleteBook(int id)
    {
        var book = books.FirstOrDefault(x => x.Id == id);

        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Xóa thành công!");
        }
    }

    public void UpdateBook(int id)
    {
        var book = books.FirstOrDefault(x => x.Id == id);

        if (book == null)
        {
            Console.WriteLine("Không tìm thấy sách!");
            return;
        }

        Console.Write("Tên mới: ");
        book.Title = Console.ReadLine() ?? "";

        Console.Write("Tác giả mới: ");
        book.Author = Console.ReadLine() ?? "";

        Console.Write("Giá mới: ");
        book.Price = decimal.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Cập nhật thành công!");
    }

    public void BorrowBook(int id)
    {
        var book = books.FirstOrDefault(x => x.Id == id);

        if (book != null)
        {
            book.Borrow();
        }
    }

    public void ReturnBook(int id)
    {
        var book = books.FirstOrDefault(x => x.Id == id);

        if (book != null)
        {
            book.Return();
        }
    }

    public void CountByCategory()
    {
        var result = books.GroupBy(x => x.Category);

        foreach (var group in result)
        {
            Console.WriteLine(
                $"{group.Key}: {group.Count()} sách");
        }
    }

    public decimal TotalPrice()
    {
        return books.Sum(x => x.Price);
    }

    public decimal AveragePrice()
    {
        return books.Any()
            ? books.Average(x => x.Price)
            : 0;
    }

    public Book? MostExpensiveBook()
    {
        return books
            .OrderByDescending(x => x.Price)
            .FirstOrDefault();
    }

    public void ShowBookWithCategory()
    {
        var result = books.Join(
            categories,
            b => b.CategoryId,
            c => c.Id,
            (b, c) => new
            {
                BookName = b.Title,
                CategoryName = c.Name
            });

        foreach (var item in result)
        {
            Console.WriteLine(
                $"{item.BookName} - {item.CategoryName}");
        }
    }
}