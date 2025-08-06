using System;
using System.Collections.Generic;

namespace ReverseDbOperations;

public partial class StudentDetail
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;
}
