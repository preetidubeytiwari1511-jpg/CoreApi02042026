using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MastDept
{
    public string CoCode { get; set; } = null!;

    public short DeptCode { get; set; }

    public string DeptName { get; set; } = null!;

    public string Hname { get; set; } = null!;

    public int? Deptofficercode { get; set; }

    public string? DeptofficerName { get; set; }
}
