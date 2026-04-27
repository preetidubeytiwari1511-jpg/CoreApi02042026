using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstUserWiseMenuTemp
{
    public int UserMenuCode { get; set; }

    public int? UserCode { get; set; }

    public int? SystemCode { get; set; }

    public int? MenuCode { get; set; }

    public int? SubMenuCode { get; set; }

    public int? ActiveInd { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? EntryUserCode { get; set; }

    public int? SectionId { get; set; }
}
