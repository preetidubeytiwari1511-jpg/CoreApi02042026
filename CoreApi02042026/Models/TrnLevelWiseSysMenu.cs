using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class TrnLevelWiseSysMenu
{
    public int LevelSysAssignCd { get; set; }

    public int? OrgCode { get; set; }

    public int? CityCode { get; set; }

    public DateOnly? CreateDate { get; set; }

    public int? LevelCode { get; set; }

    public int? SystemCode { get; set; }

    public string? MenusHtml { get; set; }

    public int? EntryUserCode { get; set; }

    public DateOnly? EntryDate { get; set; }
}
