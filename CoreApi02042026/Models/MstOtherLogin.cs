using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstOtherLogin
{
    public decimal RecordNo { get; set; }

    public decimal? UserCode { get; set; }

    public decimal? UserCodeOdp { get; set; }

    public int? InterfaceCode { get; set; }

    public int? LevelCode { get; set; }

    public string? FullName { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public string? AadhaarNo { get; set; }

    public int? CityCode { get; set; }

    public int? OrgCode { get; set; }

    public decimal? EntryUserCode { get; set; }

    public DateOnly? EntryDate { get; set; }

    public TimeOnly? EntryTime { get; set; }
}
