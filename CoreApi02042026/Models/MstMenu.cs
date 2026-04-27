using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstMenu
{
    public int MenuCode { get; set; }

    public int? CityCode { get; set; }

    public int? OrgCode { get; set; }

    public int? Systemcode { get; set; }

    public string? MenuName { get; set; }

    public string? LinkUrl { get; set; }
}
