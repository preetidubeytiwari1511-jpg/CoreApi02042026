using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSchPlotDetail
{
    public int PlotDetailCode { get; set; }

    public int? SchCode { get; set; }

    public int SectorCode { get; set; }

    public int PlotTypeCode { get; set; }

    public int? PlotUseCode { get; set; }

    public decimal? PlotWidth { get; set; }

    public decimal? PlotLength { get; set; }

    public decimal? PlotAreaSqyard { get; set; }

    public decimal? PlotAreaSqMeter { get; set; }

    public string? PlotAreaString { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? EntryUserCode { get; set; }

    public string? PlotSize { get; set; }

    public long? TotalPlot { get; set; }
}
