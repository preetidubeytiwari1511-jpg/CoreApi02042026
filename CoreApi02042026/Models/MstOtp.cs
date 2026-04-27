using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstOtp
{
    public int RecordNo { get; set; }

    public string? MobileNo { get; set; }

    public int? Otp { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? UserName { get; set; }

    public bool? TokenUsed { get; set; }

    public Guid? VerificationToken { get; set; }
}
