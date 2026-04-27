using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstSystemName
{
    public int OrgCode { get; set; }

    public int? CityCode { get; set; }

    public int SystemCode { get; set; }

    public string? SystemName { get; set; }

    public string? OrgSystemIncharg { get; set; }

    public string? OrgSystemInchMobile { get; set; }

    public string? OrgSystemInchEmail { get; set; }

    public string? OdpInchargName { get; set; }

    public string? OdpInchargMobile { get; set; }

    public DateOnly? ActivateDate { get; set; }

    public int? ActiveInd { get; set; }

    public string? SysIcon { get; set; }

    public string? CssStyle { get; set; }

    public string? TargetUrl { get; set; }

    public int? SectionId { get; set; }
}
