using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSchPlotTypeAssign
{
    public int AssignCode { get; set; }

    public int? SchCode { get; set; }

    public int? PlotTypeId { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? EntryUser { get; set; }
}
