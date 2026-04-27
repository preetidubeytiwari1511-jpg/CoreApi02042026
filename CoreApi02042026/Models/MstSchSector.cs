using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSchSector
{
    public int SectorId { get; set; }

    public int? SchCode { get; set; }

    public string? SectorDesc { get; set; }

    public int? ActiveInd { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? EntryUser { get; set; }
}
