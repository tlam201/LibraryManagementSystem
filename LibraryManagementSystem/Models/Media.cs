using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models;

public abstract class Media
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public decimal Price { get; set; }

    public string Category { get; set; } = "";

    public abstract void DisplayInfo();
}
