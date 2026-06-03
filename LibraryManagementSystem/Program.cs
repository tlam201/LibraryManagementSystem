using System.Text;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

LibraryService library = new();
MediaService mediaService = new();

library.AddCategory(new Category
{
    Id = 1,
    Name = "Tiểu thuyết"
});

library.AddCategory(new Category
{
    Id = 2,
    Name = "Văn học"
});

library.AddCategory(new Category
{
    Id = 3,
    Name = "Công nghệ thông tin"
});

library.AddBook(new Book
{
    Id = 1,
    Title = "Mắt Biếc",
    Author = "Nguyễn Nhật Ánh",
    Price = 100000,
    Category = "Tiểu thuyết",
    CategoryId = 1
});

library.AddBook(new Book
{
    Id = 2,
    Title = "Cho Tôi Xin Một Vé Đi Tuổi Thơ",
    Author = "Nguyễn Nhật Ánh",
    Price = 120000,
    Category = "Tiểu thuyết",
    CategoryId = 1
});

library.AddBook(new Book
{
    Id = 3,
    Title = "Dế Mèn Phiêu Lưu Ký",
    Author = "Tô Hoài",
    Price = 85000,
    Category = "Văn học",
    CategoryId = 2
});

library.AddBook(new Book
{
    Id = 4,
    Title = "Lão Hạc",
    Author = "Nam Cao",
    Price = 70000,
    Category = "Văn học",
    CategoryId = 2
});

library.AddBook(new Book
{
    Id = 5,
    Title = "Lập Trình C# Cơ Bản",
    Author = "Microsoft Press",
    Price = 250000,
    Category = "Công nghệ thông tin",
    CategoryId = 3
});

library.AddBook(new Book
{
    Id = 6,
    Title = "ASP.NET Core Thực Chiến",
    Author = "Microsoft",
    Price = 300000,
    Category = "Công nghệ thông tin",
    CategoryId = 3
});

mediaService.AddMedia(new Book
{
    Id = 100,
    Title = "Lập Trình Hướng Đối Tượng",
    Author = "Admin",
    Price = 200000,
    Category = "Công nghệ thông tin"
});

mediaService.AddMedia(new Magazine
{
    Id = 200,
    Title = "Tạp Chí Công Nghệ",
    IssueNumber = 15
});

while (true)
{
    Console.WriteLine("\n===== LIBRARY MANAGEMENT =====");

    Console.WriteLine("1. Hiển thị sách");
    Console.WriteLine("2. Thêm sách");
    Console.WriteLine("3. Tìm kiếm sách");
    Console.WriteLine("4. Cập nhật sách");
    Console.WriteLine("5. Xóa sách");
    Console.WriteLine("6. Mượn sách");
    Console.WriteLine("7. Trả sách");
    Console.WriteLine("8. Thống kê");
    Console.WriteLine("9. Sách đắt nhất");
    Console.WriteLine("10. LINQ Join");
    Console.WriteLine("11. Polymorphism");
    Console.WriteLine("0. Thoát");

    Console.Write("Chọn chức năng: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            library.DisplayBooks();
            break;

        case 2:
            library.AddBookFromKeyboard();
            break;

        case 3:
            {
                Console.Write("Nhập từ khóa: ");

                string keyword =
                    Console.ReadLine() ?? "";

                var result =
                    library.SearchBook(keyword);

                foreach (var book in result)
                {
                    book.DisplayInfo();
                }

                break;
            }

        case 4:
            {
                Console.Write("ID cần sửa: ");

                int id =
                    Convert.ToInt32(Console.ReadLine());

                library.UpdateBook(id);

                break;
            }

        case 5:
            {
                Console.Write("ID cần xóa: ");

                int id =
                    Convert.ToInt32(Console.ReadLine());

                library.DeleteBook(id);

                break;
            }

        case 6:
            {
                Console.Write("ID sách: ");

                int id =
                    Convert.ToInt32(Console.ReadLine());

                library.BorrowBook(id);

                break;
            }

        case 7:
            {
                Console.Write("ID sách: ");

                int id =
                    Convert.ToInt32(Console.ReadLine());

                library.ReturnBook(id);

                break;
            }

        case 8:
            {
                Console.WriteLine("\nTHỐNG KÊ");

                library.CountByCategory();

                Console.WriteLine(
                    $"Tổng giá trị sách: {library.TotalPrice()}");

                Console.WriteLine(
                    $"Giá trung bình: {library.AveragePrice()}");

                break;
            }

        case 9:
            {
                Console.WriteLine("\nSÁCH ĐẮT NHẤT");

                var book =
                    library.MostExpensiveBook();

                if (book != null)
                {
                    book.DisplayInfo();
                }

                break;
            }

        case 10:
            library.ShowBookWithCategory();
            break;

        case 11:
            mediaService.DisplayAll();
            break;

        case 0:
            return;

        default:
            Console.WriteLine("Lựa chọn không hợp lệ!");
            break;
    }
}