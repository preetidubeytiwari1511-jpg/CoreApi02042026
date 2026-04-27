using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstDeptWiseDesg
{
    public int DeptCode { get; set; }

    public int DesgCode { get; set; }

    public string? DesgDesc { get; set; }

    public int GroupCode { get; set; }

    public int? SystemCode { get; set; }
}
