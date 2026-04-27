using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstUseType
{
    public int UseCode { get; set; }

    public string? UseDescE { get; set; }

    public string? UseDescH { get; set; }

    public string? UseShortName { get; set; }

    public int? Active { get; set; }
}
