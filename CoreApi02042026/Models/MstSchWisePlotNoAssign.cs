using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSchWisePlotNoAssign
{
    public int PlotAssignCode { get; set; }

    public int? SchCode { get; set; }

    public int? SectorCode { get; set; }

    public int? PlotTypeCode { get; set; }

    public string? PlotSize { get; set; }

    public decimal? PlotSizeSqYard { get; set; }

    public decimal? PlotSizeSqMeter { get; set; }

    public string? PlotNo { get; set; }

    public DateOnly? Entrydate { get; set; }

    public int? EntryUserCode { get; set; }
}
