using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstLoginDesignation
{
    public int DesgCode { get; set; }

    public string? DesgDesc { get; set; }

    public int? DeptCode { get; set; }

    public string? Deptdesc { get; set; }

    public int? SectionCode { get; set; }
}
