using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSchWisePlotFeature
{
    public int PlotFeatureRecNo { get; set; }

    public int? PlotAssignCode { get; set; }

    public string? PlotNo { get; set; }

    public int? PlotFeatureCode { get; set; }

    public DateOnly? Entryate { get; set; }

    public int? EntryuserCode { get; set; }
}
