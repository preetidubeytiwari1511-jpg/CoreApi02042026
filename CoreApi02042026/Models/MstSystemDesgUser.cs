using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSystemDesgUser
{
    public int MapCode { get; set; }

    public int? SystemCode { get; set; }

    public int? DepartCode { get; set; }

    public string DepartName { get; set; } = null!;

    public int? DesgCode { get; set; }

    public string DesgName { get; set; } = null!;

    public int? EmployeeCode { get; set; }

    public string? EmployeeName { get; set; }

    public DateOnly? ApproveFromDate { get; set; }

    public DateOnly? ApproveToDate { get; set; }

    public int? ActiveInd { get; set; }

    public int? UserCode { get; set; }

    public string? ShortDesgName { get; set; }
}
