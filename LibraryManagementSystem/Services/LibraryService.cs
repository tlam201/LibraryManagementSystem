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

    public void AddBookFromKeyboard()
    {
        Console.Write("ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Tên sách: ");
        string title = Console.ReadLine() ?? "";

        Console.Write("Tác giả: ");
        string author = Console.ReadLine() ?? "";

        Console.Write("Giá: ");
        decimal price = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Thể loại: ");
        string category = Console.ReadLine() ?? "";

        Console.Write("Category ID: ");
        int categoryId = Convert.ToInt32(Console.ReadLine());

        books.Add(new Book
        {
            Id = id,
            Title = title,
            Author = author,
            Price = price,
            Category = category,
            CategoryId = categoryId
        });

        Console.WriteLine("Thêm sách thành công!");
    }

    public void DisplayBooks()
    {
        if (!books.Any())
        {
            Console.WriteLine("Danh sách trống!");
            return;
        }

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
        book.Price = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Cập nhật thành công!");
    }

    public void DeleteBook(int id)
    {
        var book = books.FirstOrDefault(x => x.Id == id);

        if (book == null)
        {
            Console.WriteLine("Không tìm thấy sách!");
            return;
        }

        books.Remove(book);

        Console.WriteLine("Xóa thành công!");
    }

    public void BorrowBook(int id)
    {
        var book = books.FirstOrDefault(x => x.Id == id);

        if (book == null)
        {
            Console.WriteLine("Không tìm thấy sách!");
            return;
        }

        book.Borrow();

        Console.WriteLine("Mượn sách thành công!");
    }

    public void ReturnBook(int id)
    {
        var book = books.FirstOrDefault(x => x.Id == id);

        if (book == null)
        {
            Console.WriteLine("Không tìm thấy sách!");
            return;
        }

        book.Return();

        Console.WriteLine("Trả sách thành công!");
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
        if (!books.Any())
            return 0;

        return books.Average(x => x.Price);
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
            book => book.CategoryId,
            category => category.Id,
            (book, category) => new
            {
                BookName = book.Title,
                CategoryName = category.Name
            });

        foreach (var item in result)
        {
            Console.WriteLine(
                $"{item.BookName} - {item.CategoryName}");
        }
    }
}