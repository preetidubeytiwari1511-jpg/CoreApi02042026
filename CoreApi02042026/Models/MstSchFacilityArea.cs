using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSchFacilityArea
{
    public long? CityCode { get; set; }

    public long FacilityId { get; set; }

    public int? SchCode { get; set; }

    public int? SchCodeOdp { get; set; }

    public int? FacilityCode { get; set; }

    public decimal? FacilityAreaSqYard { get; set; }

    public decimal? FacilityAreaSqMeter { get; set; }

    public string? FacilityAreaString { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? UserId { get; set; }
}
