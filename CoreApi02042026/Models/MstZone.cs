using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstZone
{
    public int ZoneCode { get; set; }

    public int CityCode { get; set; }

    public string ZoneNameE { get; set; } = null!;

    public string ZoneNameH { get; set; } = null!;

    public int Active { get; set; }
}
