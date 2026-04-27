using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstDeveloper
{
    public int CityCode { get; set; }

    public int DeveloperCode { get; set; }

    public int DevCateCode { get; set; }

    public string DeveloperDescE { get; set; } = null!;

    public string DeveloperDescH { get; set; } = null!;

    public int Active { get; set; }
}
