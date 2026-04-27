using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class TblFailedLoginAttemp
{
    public int Recordno { get; set; }

    public string? MobileNo { get; set; }

    public DateOnly? EntryDate { get; set; }
}
