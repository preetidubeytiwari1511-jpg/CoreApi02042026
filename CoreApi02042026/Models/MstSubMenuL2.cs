using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSubMenuL2
{
    public int SubMenuL2code { get; set; }

    public int? SubMenuL1code { get; set; }

    public int? MenuCode { get; set; }

    public int? CityCode { get; set; }

    public int? OrgCode { get; set; }

    public int? Systemcode { get; set; }

    public string? SubMenuL2name { get; set; }

    public string? LinkUrl { get; set; }
}
