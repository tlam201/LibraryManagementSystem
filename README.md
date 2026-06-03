# 📚 Library Management System

## Giới thiệu

Library Management System là ứng dụng quản lý thư viện được xây dựng bằng C# Console App trên nền tảng .NET 9.

Dự án được phát triển nhằm thực hành các kiến thức:

- Lập trình hướng đối tượng (OOP)
- Interface và Abstract Class
- LINQ nâng cao
- CRUD (Create, Read, Update, Delete)
- Git và GitHub
- Clean Code

---

# Chức năng

## Quản lý sách

- Hiển thị danh sách sách
- Thêm sách mới
- Tìm kiếm sách theo tên
- Cập nhật thông tin sách
- Xóa sách

## Quản lý mượn trả

- Mượn sách
- Trả sách

## Thống kê

- Thống kê số lượng sách theo thể loại
- Tính tổng giá trị tất cả sách
- Tính giá trung bình của sách
- Tìm sách có giá cao nhất

## LINQ

- Where
- GroupBy
- Join
- Sum
- Count
- Average
- OrderByDescending

---

# Menu chương trình

```text
1. Hiển thị sách
2. Thêm sách
3. Tìm kiếm sách
4. Cập nhật sách
5. Xóa sách
6. Mượn sách
7. Trả sách
8. Thống kê
9. Sách đắt nhất
10. LINQ Join
11. Polymorphism
0. Thoát
```

---

# Cấu trúc dự án

```text
LibraryManagementSystem
│
├── Interfaces
│   └── IBorrowable.cs
│
├── Models
│   ├── Media.cs
│   ├── Book.cs
│   ├── Magazine.cs
│   └── Category.cs
│
├── Services
│   ├── LibraryService.cs
│   └── MediaService.cs
│
├── Program.cs
│
└── README.md
```

---

# Kiến thức OOP áp dụng

## 1. Encapsulation (Đóng gói)

```csharp
private bool isBorrowed;
```

Dữ liệu được bảo vệ bên trong lớp và chỉ truy cập thông qua các phương thức.

---

## 2. Inheritance (Kế thừa)

```csharp
public class Book : Media
```

Lớp Book kế thừa từ lớp Media.

---

## 3. Polymorphism (Đa hình)

```csharp
public override void DisplayInfo()
```

Các lớp con cài đặt phương thức DisplayInfo() theo cách riêng.

---

## 4. Abstraction (Trừu tượng)

```csharp
public abstract class Media
```

Media là lớp trừu tượng làm nền tảng cho các loại tài liệu.

---

## 5. Interface

```csharp
public interface IBorrowable
```

Định nghĩa các hành động:

```csharp
Borrow();
Return();
```

---

# LINQ được sử dụng

## Tìm kiếm sách

```csharp
books.Where(...)
```

## Thống kê theo thể loại

```csharp
books.GroupBy(...)
```

## Nối dữ liệu sách và thể loại

```csharp
books.Join(...)
```

## Tính tổng giá trị sách

```csharp
books.Sum(...)
```

## Đếm số lượng sách

```csharp
group.Count()
```

## Tính giá trung bình

```csharp
books.Average(...)
```

## Tìm sách đắt nhất

```csharp
books.OrderByDescending(...)
```

---

# Dữ liệu mẫu

| ID | Tên sách | Tác giả | Giá |
|----|-----------|----------|----------|
| 1 | Mắt Biếc | Nguyễn Nhật Ánh | 100000 |
| 2 | Cho Tôi Xin Một Vé Đi Tuổi Thơ | Nguyễn Nhật Ánh | 120000 |
| 3 | Dế Mèn Phiêu Lưu Ký | Tô Hoài | 85000 |
| 4 | Lão Hạc | Nam Cao | 70000 |
| 5 | Lập Trình C# Cơ Bản | Microsoft Press | 250000 |
| 6 | ASP.NET Core Thực Chiến | Microsoft | 300000 |

---

# Công nghệ sử dụng

- C#
- .NET 9
- LINQ
- Git
- GitHub
- Visual Studio 2022

---

# Cách chạy chương trình

## Clone dự án

```bash
git clone https://github.com/USERNAME/LibraryManagementSystem.git
```

## Mở dự án

```text
Visual Studio 2022
→ Open Project/Solution
→ LibraryManagementSystem.sln
```

## Chạy chương trình

```text
Ctrl + F5
```

hoặc

```text
F5
```

---

# Kết quả đạt được

✅ Xây dựng ứng dụng Console App hoàn chỉnh

✅ Áp dụng đầy đủ 4 tính chất OOP

✅ Áp dụng Interface và Abstract Class

✅ Thực hiện CRUD hoàn chỉnh

✅ Thực hành LINQ nâng cao

✅ Quản lý mã nguồn bằng GitHub

✅ Tuân thủ nguyên tắc tổ chức mã nguồn theo Models - Services - Interfaces

---

# Tác giả

**Ngô Tường Lâm**

Dự án thực hành môn Lập trình C# - OOP và LINQ.
