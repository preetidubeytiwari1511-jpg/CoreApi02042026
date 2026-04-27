using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSubTransaction
{
    public int? SystemCode { get; set; }

    public int? SubSystemCode { get; set; }

    public int? UserCode { get; set; }

    public int? LevelId { get; set; }

    public int RecordNo { get; set; }

    public int? UserCodeOdp { get; set; }
}
