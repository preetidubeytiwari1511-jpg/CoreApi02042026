using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstDeveloperCate
{
    public int CityCode { get; set; }

    public int DevCateCode { get; set; }

    public string DevCateDescE { get; set; } = null!;

    public string DevCateDescH { get; set; } = null!;

    public int Active { get; set; }
}
