using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstUserLevel
{
    public int LevelId { get; set; }

    public string? LevelDesc { get; set; }

    public int? OrgCode { get; set; }

    public int? CityCode { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? EntryUserCode { get; set; }
}
