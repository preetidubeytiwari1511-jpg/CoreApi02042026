using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstUserlog
{
    public int? ActiveInd { get; set; }

    public DateTime? ActiveDateTime { get; set; }

    public int? ActiveUserCode { get; set; }

    public int? UserCode { get; set; }

    public int? UserCodeOdp { get; set; }

    public int Recordno { get; set; }
}
