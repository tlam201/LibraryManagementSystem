using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models;

public class Magazine : Media
{
    public int IssueNumber { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"{Id} | {Title} | Số phát hành: {IssueNumber}");
    }
}
