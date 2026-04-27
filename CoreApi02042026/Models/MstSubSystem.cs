using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSubSystem
{
    public int SystemCode { get; set; }

    public int? SubSystemCode { get; set; }

    public string? SubSystemName { get; set; }

    public string? UserControl { get; set; }
}
