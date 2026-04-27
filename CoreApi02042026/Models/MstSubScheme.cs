using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSubScheme
{
    public int RecordNo { get; set; }

    public int? SubSchCode { get; set; }

    public int SchCode { get; set; }

    public int IdaSchCode { get; set; }

    public string SubSchemeNm { get; set; } = null!;
}
