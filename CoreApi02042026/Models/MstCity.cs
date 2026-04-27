using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstCity
{
    public int CityCode { get; set; }

    public int? CityCodeOther { get; set; }

    public string? CityDesc { get; set; }

    public string? CityRemark { get; set; }
}
