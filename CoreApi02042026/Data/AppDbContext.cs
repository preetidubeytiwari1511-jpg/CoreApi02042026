using System;
using System.Collections.Generic;
using CoreApi02042026.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreApi02042026.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<CccodeSheet> CccodeSheets { get; set; }

    public virtual DbSet<MastDept> MastDepts { get; set; }

    public virtual DbSet<MastSubDept> MastSubDepts { get; set; }

    public virtual DbSet<MstBdasection> MstBdasections { get; set; }

    public virtual DbSet<MstCity> MstCities { get; set; }

    public virtual DbSet<MstDeptWiseDesg> MstDeptWiseDesgs { get; set; }

    public virtual DbSet<MstDeveloper> MstDevelopers { get; set; }

    public virtual DbSet<MstDeveloperCate> MstDeveloperCates { get; set; }

    public virtual DbSet<MstInterface> MstInterfaces { get; set; }

    public virtual DbSet<MstLevel> MstLevels { get; set; }

    public virtual DbSet<MstLogin> MstLogins { get; set; }

    public virtual DbSet<MstLoginDesignation> MstLoginDesignations { get; set; }

    public virtual DbSet<MstMenu> MstMenus { get; set; }

    public virtual DbSet<MstOrganization> MstOrganizations { get; set; }

    public virtual DbSet<MstOtherLogin> MstOtherLogins { get; set; }

    public virtual DbSet<MstOtp> MstOtps { get; set; }

    public virtual DbSet<MstPlotSituation> MstPlotSituations { get; set; }

    public virtual DbSet<MstPlotType> MstPlotTypes { get; set; }

    public virtual DbSet<MstSchFacilityArea> MstSchFacilityAreas { get; set; }

    public virtual DbSet<MstSchOtherfacility> MstSchOtherfacilities { get; set; }

    public virtual DbSet<MstSchPlotDetail> MstSchPlotDetails { get; set; }

    public virtual DbSet<MstSchPlotTypeAssign> MstSchPlotTypeAssigns { get; set; }

    public virtual DbSet<MstSchSector> MstSchSectors { get; set; }

    public virtual DbSet<MstSchWisePlotFeature> MstSchWisePlotFeatures { get; set; }

    public virtual DbSet<MstSchWisePlotNoAssign> MstSchWisePlotNoAssigns { get; set; }

    public virtual DbSet<MstScheme> MstSchemes { get; set; }

    public virtual DbSet<MstSchemeBak> MstSchemeBaks { get; set; }

    public virtual DbSet<MstSchemeOld> MstSchemeOlds { get; set; }

    public virtual DbSet<MstSector> MstSectors { get; set; }

    public virtual DbSet<MstSociety> MstSocieties { get; set; }

    public virtual DbSet<MstSubMenuL1> MstSubMenuL1s { get; set; }

    public virtual DbSet<MstSubMenuL2> MstSubMenuL2s { get; set; }

    public virtual DbSet<MstSubScheme> MstSubSchemes { get; set; }

    public virtual DbSet<MstSubSystem> MstSubSystems { get; set; }

    public virtual DbSet<MstSubTransaction> MstSubTransactions { get; set; }

    public virtual DbSet<MstSysWiseMainMenu> MstSysWiseMainMenus { get; set; }

    public virtual DbSet<MstSysWiseSubMenu> MstSysWiseSubMenus { get; set; }

    public virtual DbSet<MstSysWiseSubMenu23012024> MstSysWiseSubMenu23012024s { get; set; }

    public virtual DbSet<MstSystemDesgUser> MstSystemDesgUsers { get; set; }

    public virtual DbSet<MstSystemName> MstSystemNames { get; set; }

    public virtual DbSet<MstUseType> MstUseTypes { get; set; }

    public virtual DbSet<MstUser> MstUsers { get; set; }

    public virtual DbSet<MstUserLevel> MstUserLevels { get; set; }

    public virtual DbSet<MstUserWiseMenu> MstUserWiseMenus { get; set; }

    public virtual DbSet<MstUserWiseMenuTemp> MstUserWiseMenuTemps { get; set; }

    public virtual DbSet<MstUserWiseSystem> MstUserWiseSystems { get; set; }

    public virtual DbSet<MstUserlog> MstUserlogs { get; set; }

    public virtual DbSet<MstWard> MstWards { get; set; }

    public virtual DbSet<MstZone> MstZones { get; set; }

    public virtual DbSet<Mstsociety13022019> Mstsociety13022019s { get; set; }

    public virtual DbSet<ProjectMaster> ProjectMasters { get; set; }

    public virtual DbSet<Sheet1> Sheet1s { get; set; }

    public virtual DbSet<TblFailedLoginAttemp> TblFailedLoginAttemps { get; set; }

    public virtual DbSet<TrnLevelWiseSysMenu> TrnLevelWiseSysMenus { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<CccodeSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CCCodeSheet");

            entity.Property(e => e.BudgetCostCenter).HasColumnName("Budget cost center");
            entity.Property(e => e.F3).HasMaxLength(255);
            entity.Property(e => e.F5).HasMaxLength(255);
            entity.Property(e => e.F6).HasMaxLength(255);
            entity.Property(e => e.F7).HasMaxLength(255);
            entity.Property(e => e.SchemeInDemandSystemBhopal).HasColumnName("Scheme in demand system bhopal");
        });

        modelBuilder.Entity<MastDept>(entity =>
        {
            entity.HasKey(e => e.DeptCode);

            entity.ToTable("mastDept");

            entity.Property(e => e.DeptCode).ValueGeneratedNever();
            entity.Property(e => e.CoCode)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeptofficerName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("deptofficerName");
            entity.Property(e => e.Deptofficercode)
                .HasDefaultValue(0)
                .HasColumnName("deptofficercode");
            entity.Property(e => e.Hname)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("HName");
        });

        modelBuilder.Entity<MastSubDept>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mastSubDept");

            entity.Property(e => e.Cccode).HasColumnName("CCCode");
            entity.Property(e => e.Ccname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCName");
            entity.Property(e => e.CoCode)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Hccname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HCCName");
            entity.Property(e => e.SubDeptCode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstBdasection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstBDAsection");

            entity.Property(e => e.SectionCode).ValueGeneratedOnAdd();
            entity.Property(e => e.SectionName)
                .HasMaxLength(70)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstCity>(entity =>
        {
            entity.HasKey(e => e.CityCode);

            entity.ToTable("MstCity");

            entity.Property(e => e.CityDesc)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CityRemark)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstDeptWiseDesg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstDeptWiseDesg");

            entity.Property(e => e.DesgCode).ValueGeneratedOnAdd();
            entity.Property(e => e.DesgDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SystemCode).HasDefaultValue(0);
        });

        modelBuilder.Entity<MstDeveloper>(entity =>
        {
            entity.HasKey(e => e.DeveloperCode);

            entity.ToTable("MstDeveloper");

            entity.Property(e => e.Active).HasDefaultValue(1);
            entity.Property(e => e.DeveloperDescE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.DeveloperDescH)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<MstDeveloperCate>(entity =>
        {
            entity.HasKey(e => e.DevCateCode);

            entity.ToTable("MstDeveloperCate");

            entity.Property(e => e.Active).HasDefaultValue(1);
            entity.Property(e => e.DevCateDescE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.DevCateDescH)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<MstInterface>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstInterface");

            entity.Property(e => e.InterfaceCode).ValueGeneratedOnAdd();
            entity.Property(e => e.InterfaceDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstLevel");

            entity.Property(e => e.LevelCode).ValueGeneratedOnAdd();
            entity.Property(e => e.LevelDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstLogin");

            entity.Property(e => e.LoginId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LoginID");
            entity.Property(e => e.LoginPass)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserCode)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UserCodeOdp).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<MstLoginDesignation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mstLoginDesignation");

            entity.Property(e => e.Deptdesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DesgCode).ValueGeneratedOnAdd();
            entity.Property(e => e.DesgDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectionCode).HasDefaultValue(0);
        });

        modelBuilder.Entity<MstMenu>(entity =>
        {
            entity.HasKey(e => e.MenuCode).HasName("PK__MstMenu__868A3A72E9F78B6F");

            entity.ToTable("MstMenu");

            entity.Property(e => e.LinkUrl)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.MenuName)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstOrganization>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstOrganization");

            entity.Property(e => e.AgreementNo)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ContactPer1Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ContactPer1Mobile)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ContactPer1Name)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ContactPer2Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ContactPer2Mobile)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ContactPer2Name)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.OrgCode).ValueGeneratedOnAdd();
            entity.Property(e => e.OrgName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstOtherLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstOtherLogin");

            entity.Property(e => e.AadhaarNo)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.EmailId)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("EmailID");
            entity.Property(e => e.EntryUserCode).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RecordNo)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UserCode).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UserCodeOdp).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<MstOtp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstOTP");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Otp).HasColumnName("OTP");
            entity.Property(e => e.RecordNo).ValueGeneratedOnAdd();
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstPlotSituation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstPlotSituation");

            entity.Property(e => e.Active).HasDefaultValue(1);
            entity.Property(e => e.PlotSituationCode).ValueGeneratedOnAdd();
            entity.Property(e => e.PlotSituationE)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PlotSituationH).HasMaxLength(70);
        });

        modelBuilder.Entity<MstPlotType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstPlotType");

            entity.Property(e => e.PlotTypeDesc)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.PlotTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PlotTypeID");
            entity.Property(e => e.PlotTypeShortDesc)
                .HasMaxLength(70)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstSchFacilityArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSchFacilityArea");

            entity.Property(e => e.FacilityAreaSqMeter).HasColumnType("money");
            entity.Property(e => e.FacilityAreaSqYard).HasColumnType("money");
            entity.Property(e => e.FacilityAreaString)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FacilityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FacilityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<MstSchOtherfacility>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSchOtherfacility");

            entity.Property(e => e.Active).HasDefaultValue(1);
            entity.Property(e => e.OtherfacilityDescE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherfacilityDescH).HasMaxLength(100);
            entity.Property(e => e.OtherfacilityInd).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstSchPlotDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSchPlotDetail");

            entity.Property(e => e.PlotAreaSqMeter).HasColumnType("money");
            entity.Property(e => e.PlotAreaSqyard).HasColumnType("money");
            entity.Property(e => e.PlotAreaString)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PlotDetailCode).ValueGeneratedOnAdd();
            entity.Property(e => e.PlotLength).HasColumnType("money");
            entity.Property(e => e.PlotSize)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.PlotWidth).HasColumnType("money");
        });

        modelBuilder.Entity<MstSchPlotTypeAssign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSchPlotTypeAssign");

            entity.Property(e => e.AssignCode).ValueGeneratedOnAdd();
            entity.Property(e => e.PlotTypeId).HasColumnName("PlotTypeID");
        });

        modelBuilder.Entity<MstSchSector>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSchSector");

            entity.Property(e => e.SectorDesc)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SectorId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SectorID");
        });

        modelBuilder.Entity<MstSchWisePlotFeature>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSchWisePlotFeature");

            entity.Property(e => e.PlotFeatureRecNo).ValueGeneratedOnAdd();
            entity.Property(e => e.PlotNo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstSchWisePlotNoAssign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSchWisePlotNoAssign");

            entity.Property(e => e.PlotAssignCode).ValueGeneratedOnAdd();
            entity.Property(e => e.PlotNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PlotSize)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.PlotSizeSqMeter).HasColumnType("money");
            entity.Property(e => e.PlotSizeSqYard).HasColumnType("money");
        });

        modelBuilder.Entity<MstScheme>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstScheme");

            entity.Property(e => e.AprName)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Aprno)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BdaschemeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BDASchemeCode");
            entity.Property(e => e.Cccode)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CCCode");
            entity.Property(e => e.DevCtyId).HasColumnName("DevCtyID");
            entity.Property(e => e.DevloperId).HasColumnName("DevloperID");
            entity.Property(e => e.EntryUserDesc)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");
            entity.Property(e => e.IdaschNo).HasColumnName("IDASchNo");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchCodeOdp).ValueGeneratedOnAdd();
            entity.Property(e => e.SchGroupId).HasColumnName("SchGroupID");
            entity.Property(e => e.SchGroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchNameE)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.SchNameH).HasMaxLength(200);
            entity.Property(e => e.SchNoDesc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TotalPlotingAreaSqMeter).HasColumnType("money");
            entity.Property(e => e.TotalPlotingAreaSqyard).HasColumnType("money");
            entity.Property(e => e.TotalPlotingAreaString)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalSchAreaSqMeter).HasColumnType("money");
            entity.Property(e => e.TotalSchAreaSqYard).HasColumnType("money");
            entity.Property(e => e.TotalSchAreaString)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstSchemeBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstScheme_Bak");

            entity.Property(e => e.AprName)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Aprno)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DevCtyId).HasColumnName("DevCtyID");
            entity.Property(e => e.DevloperId).HasColumnName("DevloperID");
            entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");
            entity.Property(e => e.IdaschNo).HasColumnName("IDASchNo");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchCodeOdp).ValueGeneratedOnAdd();
            entity.Property(e => e.SchNameE)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.SchNameH).HasMaxLength(200);
            entity.Property(e => e.SchNoDesc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TotalPlotingAreaSqMeter).HasColumnType("money");
            entity.Property(e => e.TotalPlotingAreaSqyard).HasColumnType("money");
            entity.Property(e => e.TotalPlotingAreaString)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalSchAreaSqMeter).HasColumnType("money");
            entity.Property(e => e.TotalSchAreaSqYard).HasColumnType("money");
            entity.Property(e => e.TotalSchAreaString)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstSchemeOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstScheme_old");

            entity.Property(e => e.AprName)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Aprno)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DevCtyId).HasColumnName("DevCtyID");
            entity.Property(e => e.DevloperId).HasColumnName("DevloperID");
            entity.Property(e => e.EntryUserId)
                .HasDefaultValue(0)
                .HasColumnName("EntryUserID");
            entity.Property(e => e.IdaschNo)
                .HasDefaultValue(0)
                .HasColumnName("IDASchNo");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchCode).HasDefaultValue(0);
            entity.Property(e => e.SchCodeOdp).ValueGeneratedOnAdd();
            entity.Property(e => e.SchNameE)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.SchNameH).HasMaxLength(200);
            entity.Property(e => e.SchNoDesc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TotalPlotingAreaSqMeter).HasColumnType("money");
            entity.Property(e => e.TotalPlotingAreaSqyard).HasColumnType("money");
            entity.Property(e => e.TotalPlotingAreaString)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalSchAreaSqMeter).HasColumnType("money");
            entity.Property(e => e.TotalSchAreaSqYard).HasColumnType("money");
            entity.Property(e => e.TotalSchAreaString)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstSector>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSector");

            entity.Property(e => e.Sector)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SectorId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SectorID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<MstSociety>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSociety");

            entity.Property(e => e.SocietyId).ValueGeneratedOnAdd();
            entity.Property(e => e.SocietyName)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.SocietyNameH).HasMaxLength(1000);
        });

        modelBuilder.Entity<MstSubMenuL1>(entity =>
        {
            entity.HasKey(e => e.SubMenuL1code).HasName("PK__MstSubMe__C40548952665EA8D");

            entity.ToTable("MstSubMenuL1");

            entity.Property(e => e.SubMenuL1code).HasColumnName("SubMenuL1Code");
            entity.Property(e => e.LinkUrl)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.SubMenuL1name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SubMenuL1Name");
        });

        modelBuilder.Entity<MstSubMenuL2>(entity =>
        {
            entity.HasKey(e => e.SubMenuL2code).HasName("PK__MstSubMe__C6C3A8459C04934C");

            entity.ToTable("MstSubMenuL2");

            entity.Property(e => e.SubMenuL2code).HasColumnName("SubMenuL2Code");
            entity.Property(e => e.LinkUrl)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.SubMenuL1code).HasColumnName("SubMenuL1Code");
            entity.Property(e => e.SubMenuL2name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SubMenuL2Name");
        });

        modelBuilder.Entity<MstSubScheme>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSubScheme");

            entity.Property(e => e.RecordNo).ValueGeneratedOnAdd();
            entity.Property(e => e.SubSchemeNm)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstSubSystem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSubSystem");

            entity.Property(e => e.SubSystemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserControl)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstSubTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSubTransaction");

            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.RecordNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstSysWiseMainMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSysWiseMainMenu");

            entity.Property(e => e.Icon)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.MenuCode).ValueGeneratedOnAdd();
            entity.Property(e => e.MenuDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MenuOrderCd).HasColumnName("MenuOrderCD");
        });

        modelBuilder.Entity<MstSysWiseSubMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSysWiseSubMenu");

            entity.Property(e => e.FormUrl)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Icon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubMenuDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubMenuorderCd).HasColumnName("SubMenuorderCD");
            entity.Property(e => e.Submenucode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstSysWiseSubMenu23012024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSysWiseSubMenu_23012024");

            entity.Property(e => e.FormUrl)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Icon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubMenuDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubMenuorderCd).HasColumnName("SubMenuorderCD");
            entity.Property(e => e.Submenucode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstSystemDesgUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSystemDesgUser");

            entity.Property(e => e.ActiveInd).HasDefaultValue(1);
            entity.Property(e => e.DepartName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DesgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MapCode).ValueGeneratedOnAdd();
            entity.Property(e => e.ShortDesgName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstSystemName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstSystemName");

            entity.Property(e => e.CssStyle)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("Css_Style");
            entity.Property(e => e.OdpInchargMobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.OdpInchargName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgSystemInchEmail)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.OrgSystemInchMobile)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OrgSystemIncharg)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectionId)
                .HasDefaultValue(0)
                .HasColumnName("SectionID");
            entity.Property(e => e.SysIcon)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.SystemCode).ValueGeneratedOnAdd();
            entity.Property(e => e.SystemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TargetUrl)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstUseType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstUseType");

            entity.Property(e => e.Active).HasDefaultValue(1);
            entity.Property(e => e.UseCode).ValueGeneratedOnAdd();
            entity.Property(e => e.UseDescE)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UseDescH).HasMaxLength(100);
            entity.Property(e => e.UseShortName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstUser");

            entity.Property(e => e.AadhaarNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DeptCode).HasDefaultValue(0);
            entity.Property(e => e.Desgcode).HasDefaultValue(0);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Emptype)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Panno)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SubDeptCode).HasDefaultValue(0);
            entity.Property(e => e.UserCode).ValueGeneratedOnAdd();
            entity.Property(e => e.UserLoginId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserLoginPass)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserSubLevelCode).HasDefaultValue(0);
        });

        modelBuilder.Entity<MstUserLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstUserLevel");

            entity.Property(e => e.LevelDesc)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LevelId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstUserWiseMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstUserWiseMenu");

            entity.Property(e => e.ActiveInd).HasDefaultValue(1);
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.UserMenuCode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstUserWiseMenuTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstUserWiseMenuTemp");

            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.UserMenuCode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstUserWiseSystem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstUserWiseSystem");

            entity.Property(e => e.RecordNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstUserlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstUserlog");

            entity.Property(e => e.ActiveDateTime).HasColumnType("datetime");
            entity.Property(e => e.Recordno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstWard>(entity =>
        {
            entity.HasKey(e => e.WardCode);

            entity.ToTable("MstWard");

            entity.Property(e => e.Active).HasDefaultValue(1);
            entity.Property(e => e.WardNameE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WardNameH)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<MstZone>(entity =>
        {
            entity.HasKey(e => e.ZoneCode);

            entity.ToTable("MstZone");

            entity.Property(e => e.Active).HasDefaultValue(1);
            entity.Property(e => e.ZoneNameE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ZoneNameH)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Mstsociety13022019>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mstsociety_13022019");

            entity.Property(e => e.SocietyId).ValueGeneratedOnAdd();
            entity.Property(e => e.SocietyName)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.SocietyNameH).HasMaxLength(1000);
        });

        modelBuilder.Entity<ProjectMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'Project Master$'");

            entity.Property(e => e.Cc).HasColumnName("CC");
            entity.Property(e => e.EntryDt)
                .HasMaxLength(255)
                .HasColumnName("entry_dt");
            entity.Property(e => e.F2).HasMaxLength(255);
            entity.Property(e => e.HprojDesc)
                .HasMaxLength(255)
                .HasColumnName("hproj_desc");
            entity.Property(e => e.ProjCode)
                .HasMaxLength(255)
                .HasColumnName("proj_code");
            entity.Property(e => e.ProjDesc)
                .HasMaxLength(255)
                .HasColumnName("proj_desc");
            entity.Property(e => e.UserCd)
                .HasMaxLength(255)
                .HasColumnName("user_cd");
            entity.Property(e => e.Xx).HasColumnName("XX");
        });

        modelBuilder.Entity<Sheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sheet1");
        });

        modelBuilder.Entity<TblFailedLoginAttemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblFailedLoginAttemp");

            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Recordno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TrnLevelWiseSysMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TrnLevelWiseSysMenu");

            entity.Property(e => e.LevelSysAssignCd)
                .ValueGeneratedOnAdd()
                .HasColumnName("LevelSysAssignCD");
            entity.Property(e => e.MenusHtml).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
