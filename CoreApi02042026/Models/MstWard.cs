using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstWard
{
    public int WardCode { get; set; }

    public string WardNameE { get; set; } = null!;

    public string WardNameH { get; set; } = null!;

    public int CityCode { get; set; }

    public int Active { get; set; }
}
