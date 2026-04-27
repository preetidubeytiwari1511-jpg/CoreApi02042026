using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSysWiseMainMenu
{
    public int MenuCode { get; set; }

    public int? SystemCode { get; set; }

    public string? MenuDesc { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? EntryUserCode { get; set; }

    public int? MenuOrderCd { get; set; }

    public string? Icon { get; set; }

    public int? ActiveMenuInd { get; set; }
}
