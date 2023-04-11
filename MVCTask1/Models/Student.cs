using System;
using System.Collections.Generic;

namespace MVCTask1.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Class { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? MobileNumber { get; set; }
}
