using System;
using System.Collections.Generic;

namespace BLL.DAL;

public partial class student
{
    public int id { get; set; }

    public string name { get; set; } = null!;

    public string surname { get; set; } = null!;

    public DateTime? birthdate { get; set; }

    public decimal? gpa { get; set; }
}
