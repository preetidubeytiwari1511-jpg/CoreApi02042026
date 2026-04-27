using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstLogin
{
    public decimal UserCode { get; set; }

    public decimal? UserCodeOdp { get; set; }

    public int? InterfaceCode { get; set; }

    public int? LevelCode { get; set; }

    public string? LoginId { get; set; }

    public string? LoginPass { get; set; }

    public DateOnly? EntryDate { get; set; }

    public TimeOnly? EntryTime { get; set; }
}
