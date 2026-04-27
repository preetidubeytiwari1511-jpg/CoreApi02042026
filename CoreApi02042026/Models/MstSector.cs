using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSector
{
    public int SectorId { get; set; }

    public long? CityCode { get; set; }

    public int? SchCode { get; set; }

    public int? PlotTypeCode { get; set; }

    public int? SectorCodeOdp { get; set; }

    public string? Sector { get; set; }

    public DateOnly? EntryDate { get; set; }

    public long? UserId { get; set; }
}
