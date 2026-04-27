using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstUser
{
    public int UserCode { get; set; }


    public string OrgName { get; set; }

    public int? UserLevel { get; set; }

    public string? UserLoginId { get; set; }

    public string? UserLoginPass { get; set; }

    public int? UserEmpCode { get; set; }

    public int? OrgCode { get; set; }

    public int? CityCode { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? EntryUserCode { get; set; }

    public int? UserSubLevelCode { get; set; }

    public string? UserName { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public string? AadhaarNo { get; set; }

    public int? DeptCode { get; set; }

    public int? SubDeptCode { get; set; }

    public int? Desgcode { get; set; }

    public int? SectionId { get; set; }

    public string? FatherName { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Address { get; set; }

    public string? Emptype { get; set; }

    public string? Panno { get; set; }
}
