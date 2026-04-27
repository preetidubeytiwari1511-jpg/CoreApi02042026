using System;
using System.Collections.Generic;

namespace CoreApi02042026.Models;

public partial class MstScheme
{
    public int? CityCode { get; set; }

    public int? SchCode { get; set; }

    public int SchCodeOdp { get; set; }

    public string? SchNameE { get; set; }

    public string? SchNameH { get; set; }

    public string? Location { get; set; }

    public int? SchUseCode { get; set; }

    public string? SchNoDesc { get; set; }

    public int? DevCtyId { get; set; }

    public int? DevloperId { get; set; }

    public string? Aprno { get; set; }

    public DateOnly? AprDate { get; set; }

    public string? AprName { get; set; }

    public int? ActiveInd { get; set; }

    public DateOnly? Entrydate { get; set; }

    public int? EntryUserId { get; set; }

    public decimal? TotalSchAreaSqYard { get; set; }

    public decimal? TotalSchAreaSqMeter { get; set; }

    public string? TotalSchAreaString { get; set; }

    public decimal? TotalPlotingAreaSqyard { get; set; }

    public decimal? TotalPlotingAreaSqMeter { get; set; }

    public string? TotalPlotingAreaString { get; set; }

    public int SectorAvalInd { get; set; }

    public int PlotCateTypeInd { get; set; }

    public long GlCode { get; set; }

    public int? IdaschNo { get; set; }

    public int? SahmatiInd { get; set; }

    public string? EntryUserDesc { get; set; }

    public string? BdaschemeCode { get; set; }

    public int? SchGroupId { get; set; }

    public string? SchGroupName { get; set; }

    public int? PropertySchCode { get; set; }

    public decimal? Cccode { get; set; }
}
