using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstPlotType
{
    public int PlotTypeId { get; set; }

    public string? PlotTypeDesc { get; set; }

    public string? PlotTypeShortDesc { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? ActiveInd { get; set; }
}
