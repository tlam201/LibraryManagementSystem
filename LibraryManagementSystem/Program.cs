using System.Text;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

LibraryService library = new();
MediaService mediaService = new();

library.AddCategory(new Category { Id = 1, Name = "Tiểu thuyết" });
library.AddCategory(new Category { Id = 2, Name = "Văn học" });

library.AddBook(new Book
{
    Id = 1,
    Title = "Mắt Biết",
    Author = "Nguyễn Nhật Ánh",
    Price = 100000,
    Category = "Tiểu thuyết",
    CategoryId = 1
});

library.AddBook(new Book
{
    Id = 2,
    Title = "Kim Đồng",
    Author = "Tô Hoài",
    Price = 50000,
    Category = "Văn học",
    CategoryId = 2
});

library.AddBook(new Book
{
    Id = 3,
    Title = "Dế mèn phiêu lưu ký",
    Author = "Tô Hoài",
    Price = 85000,
    Category = "Văn học",
    CategoryId = 2
});

mediaService.AddMedia(new Book
{
    Id = 100,
    Title = "OOP C#",
    Author = "Admin",
    Price = 100
});

mediaService.AddMedia(new Magazine
{
    Id = 200,
    Title = "Technology Magazine",
    IssueNumber = 15
});

while (true)
{
    Console.WriteLine("\n===== LIBRARY MANAGEMENT =====");
    Console.WriteLine("1. Hiển thị sách");
    Console.WriteLine("2. Tìm kiếm");
    Console.WriteLine("3. Thêm sách");
    Console.WriteLine("4. Sửa sách");
    Console.WriteLine("5. Xóa sách");
    Console.WriteLine("6. Mượn sách");
    Console.WriteLine("7. Trả sách");
    Console.WriteLine("8. Thống kê");
    Console.WriteLine("9. Sách đắt nhất");
    Console.WriteLine("10. LINQ Join");
    Console.WriteLine("11. Polymorphism");
    Console.WriteLine("0. Thoát");

    Console.Write("Chọn: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            library.DisplayBooks();
            break;

        case 2:
            Console.Write("Từ khóa: ");
            string keyword = Console.ReadLine() ?? "";

            foreach (var book in library.SearchBook(keyword))
            {
                book.DisplayInfo();
            }
            break;

        case 8:
            library.CountByCategory();
            Console.WriteLine($"Tổng tiền: {library.TotalPrice()}");
            Console.WriteLine($"Trung bình: {library.AveragePrice()}");
            break;

        case 9:
            library.MostExpensiveBook()?.DisplayInfo();
            break;

        case 10:
            library.ShowBookWithCategory();
            break;

        case 11:
            mediaService.DisplayAll();
            break;

        case 0:
            return;
    }
}