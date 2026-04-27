using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstPlotSituation
{
    public int PlotSituationCode { get; set; }

    public string? PlotSituationE { get; set; }

    public string? PlotSituationH { get; set; }

    public int? Active { get; set; }
}
