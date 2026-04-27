using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstUserWiseSystem
{
    public int RecordNo { get; set; }

    public int? UserCode { get; set; }

    public int? UserCodeOdp { get; set; }

    public int? SystemCode { get; set; }

    public int? OrgCode { get; set; }

    public int? CityCode { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? EntryUserCode { get; set; }
}
