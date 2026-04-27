using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstOrganization
{
    public int OrgCode { get; set; }

    public int? OrgCodeOth { get; set; }

    public int? OrgCityCode { get; set; }

    public string? OrgName { get; set; }

    public string? ContactPer1Name { get; set; }

    public string? ContactPer1Mobile { get; set; }

    public string? ContactPer1Email { get; set; }

    public string? ContactPer2Name { get; set; }

    public string? ContactPer2Mobile { get; set; }

    public string? ContactPer2Email { get; set; }

    public DateOnly? ActiveDate { get; set; }

    public string? AgreementNo { get; set; }

    public int? Active { get; set; }
}
