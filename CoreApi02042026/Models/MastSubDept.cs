using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MastSubDept
{
    public string? CoCode { get; set; }

    public short Cccode { get; set; }

    public string? Ccname { get; set; }

    public string? Hccname { get; set; }

    public short? DeptCode { get; set; }

    public short? ZoneCode { get; set; }

    public byte? GrCode { get; set; }

    public byte? ZoneInd { get; set; }

    public int SubDeptCode { get; set; }
}
