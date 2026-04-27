using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstLevel
{
    public int LevelCode { get; set; }

    public int? InterfaceCode { get; set; }

    public string? LevelDesc { get; set; }

    public int? ActiveInd { get; set; }
}
