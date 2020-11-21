using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BigData.Models
{
    public partial class jv_edm_dbContext : DbContext
    {
        public jv_edm_dbContext()
        {
        }

        public jv_edm_dbContext(DbContextOptions<jv_edm_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CdAssemblyCompT> CdAssemblyCompT { get; set; }
        public virtual DbSet<CdAssemblyDetailT> CdAssemblyDetailT { get; set; }
        public virtual DbSet<CdAssemblyT> CdAssemblyT { get; set; }
        public virtual DbSet<CdBhaCompBitT> CdBhaCompBitT { get; set; }
        public virtual DbSet<CdCementFluidScheduleT> CdCementFluidScheduleT { get; set; }
        public virtual DbSet<CdCementFluidT> CdCementFluidT { get; set; }
        public virtual DbSet<CdCementJobT> CdCementJobT { get; set; }
        public virtual DbSet<CdCementPlugStatusT> CdCementPlugStatusT { get; set; }
        public virtual DbSet<CdCementStageT> CdCementStageT { get; set; }
        public virtual DbSet<CdDatumT> CdDatumT { get; set; }
        public virtual DbSet<CdDefinitiveSurveyHeaderT> CdDefinitiveSurveyHeaderT { get; set; }
        public virtual DbSet<CdFluidT> CdFluidT { get; set; }
        public virtual DbSet<CdHoleSectGroupT> CdHoleSectGroupT { get; set; }
        public virtual DbSet<CdHoleSectT> CdHoleSectT { get; set; }
        public virtual DbSet<CdPerforateT> CdPerforateT { get; set; }
        public virtual DbSet<CdPolicy> CdPolicy { get; set; }
        public virtual DbSet<CdProjectSource> CdProjectSource { get; set; }
        public virtual DbSet<CdRig> CdRig { get; set; }
        public virtual DbSet<CdRigAnchor> CdRigAnchor { get; set; }
        public virtual DbSet<CdRigCentrifuge> CdRigCentrifuge { get; set; }
        public virtual DbSet<CdRigHydroclone> CdRigHydroclone { get; set; }
        public virtual DbSet<CdRigPump> CdRigPump { get; set; }
        public virtual DbSet<CdRigShaker> CdRigShaker { get; set; }
        public virtual DbSet<CdSiteSource> CdSiteSource { get; set; }
        public virtual DbSet<CdSurveyHeaderT> CdSurveyHeaderT { get; set; }
        public virtual DbSet<CdSurveyStationT> CdSurveyStationT { get; set; }
        public virtual DbSet<CdVgMeterT> CdVgMeterT { get; set; }
        public virtual DbSet<CdWellSource> CdWellSource { get; set; }
        public virtual DbSet<CdWellStatusT> CdWellStatusT { get; set; }
        public virtual DbSet<CdWellboreFormationT> CdWellboreFormationT { get; set; }
        public virtual DbSet<CdWellboreT> CdWellboreT { get; set; }
        public virtual DbSet<DmActivityT> DmActivityT { get; set; }
        public virtual DbSet<DmAfe> DmAfe { get; set; }
        public virtual DbSet<DmAfeSupp> DmAfeSupp { get; set; }
        public virtual DbSet<DmAnchorOpT> DmAnchorOpT { get; set; }
        public virtual DbSet<DmBhaOpT> DmBhaOpT { get; set; }
        public virtual DbSet<DmBhaRunT> DmBhaRunT { get; set; }
        public virtual DbSet<DmBitOpT> DmBitOpT { get; set; }
        public virtual DbSet<DmBulkT> DmBulkT { get; set; }
        public virtual DbSet<DmBulkTranT> DmBulkTranT { get; set; }
        public virtual DbSet<DmCentrifugeOpT> DmCentrifugeOpT { get; set; }
        public virtual DbSet<DmCompanyDailyT> DmCompanyDailyT { get; set; }
        public virtual DbSet<DmCompanyT> DmCompanyT { get; set; }
        public virtual DbSet<DmCrCleanupT> DmCrCleanupT { get; set; }
        public virtual DbSet<DmCrMudAdditiveT> DmCrMudAdditiveT { get; set; }
        public virtual DbSet<DmDailyDitchMagnetT> DmDailyDitchMagnetT { get; set; }
        public virtual DbSet<DmDailyNotificationT> DmDailyNotificationT { get; set; }
        public virtual DbSet<DmDailyT> DmDailyT { get; set; }
        public virtual DbSet<DmEnvironmentalT> DmEnvironmentalT { get; set; }
        public virtual DbSet<DmEventT> DmEventT { get; set; }
        public virtual DbSet<DmHydrocloneOpT> DmHydrocloneOpT { get; set; }
        public virtual DbSet<DmMudProductT> DmMudProductT { get; set; }
        public virtual DbSet<DmMudProductTranT> DmMudProductTranT { get; set; }
        public virtual DbSet<DmMudVolumeT> DmMudVolumeT { get; set; }
        public virtual DbSet<DmOperEquipFailT> DmOperEquipFailT { get; set; }
        public virtual DbSet<DmPersonnelDailyT> DmPersonnelDailyT { get; set; }
        public virtual DbSet<DmPersonnelT> DmPersonnelT { get; set; }
        public virtual DbSet<DmPitOpT> DmPitOpT { get; set; }
        public virtual DbSet<DmPumpOpT> DmPumpOpT { get; set; }
        public virtual DbSet<DmReportJournal> DmReportJournal { get; set; }
        public virtual DbSet<DmRigDecklogT> DmRigDecklogT { get; set; }
        public virtual DbSet<DmRigOperation> DmRigOperation { get; set; }
        public virtual DbSet<DmRiser> DmRiser { get; set; }
        public virtual DbSet<DmRiserOpT> DmRiserOpT { get; set; }
        public virtual DbSet<DmSafetyT> DmSafetyT { get; set; }
        public virtual DbSet<DmShakerOpT> DmShakerOpT { get; set; }
        public virtual DbSet<DmShakerscreen> DmShakerscreen { get; set; }
        public virtual DbSet<DmSupportVesselDailyT> DmSupportVesselDailyT { get; set; }
        public virtual DbSet<DmSupportVesselT> DmSupportVesselT { get; set; }
        public virtual DbSet<DmWeatherCheckT> DmWeatherCheckT { get; set; }
        public virtual DbSet<DmWellboreIntegT> DmWellboreIntegT { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-6OUJI5R\\SQLEXPRESS;Database=jv_edm_db;Trusted_Connection=True;Connect timeout=100; MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CdAssemblyCompT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.AssemblyId, e.AssemblyCompId })
                    .HasName("XPKCD_ASSEMBLY_COMP");

                entity.ToTable("CD_ASSEMBLY_COMP_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyId)
                    .HasColumnName("assembly_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyCompId)
                    .HasColumnName("assembly_comp_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnisotropicHoop).HasColumnName("anisotropic_hoop");

                entity.Property(e => e.AnisotropicRadial).HasColumnName("anisotropic_radial");

                entity.Property(e => e.AnnularFlowArea).HasColumnName("annular_flow_area");

                entity.Property(e => e.ApproximateWeight).HasColumnName("approximate_weight");

                entity.Property(e => e.AreaOpeningInternal).HasColumnName("area_opening_internal");

                entity.Property(e => e.AuditRemarks)
                    .HasColumnName("audit_remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.AverageJointLength).HasColumnName("average_joint_length");

                entity.Property(e => e.AxialRating).HasColumnName("axial_rating");

                entity.Property(e => e.BitflowRate).HasColumnName("bitflow_rate");

                entity.Property(e => e.BladeLength).HasColumnName("blade_length");

                entity.Property(e => e.BotConnLength).HasColumnName("bot_conn_length");

                entity.Property(e => e.BotConnOd).HasColumnName("bot_conn_od");

                entity.Property(e => e.BotConnType)
                    .HasColumnName("bot_conn_type")
                    .HasMaxLength(50);

                entity.Property(e => e.BoxPinConfig)
                    .HasColumnName("box_pin_config")
                    .HasMaxLength(20);

                entity.Property(e => e.CatalogId)
                    .HasColumnName("catalog_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CatalogItemId)
                    .HasColumnName("catalog_item_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CatalogKeyDesc)
                    .HasColumnName("catalog_key_desc")
                    .HasMaxLength(255);

                entity.Property(e => e.CatalogName)
                    .HasColumnName("catalog_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Centers).HasColumnName("centers");

                entity.Property(e => e.ClosedEndDisplacement).HasColumnName("closed_end_displacement");

                entity.Property(e => e.Coating)
                    .HasColumnName("coating")
                    .HasMaxLength(50);

                entity.Property(e => e.CompCost).HasColumnName("comp_cost");

                entity.Property(e => e.CompGroup)
                    .HasColumnName("comp_group")
                    .HasMaxLength(50);

                entity.Property(e => e.CompName)
                    .HasColumnName("comp_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CompTypeCode)
                    .HasColumnName("comp_type_code")
                    .HasMaxLength(6);

                entity.Property(e => e.Condition)
                    .HasColumnName("condition")
                    .HasMaxLength(32);

                entity.Property(e => e.Conductivity).HasColumnName("conductivity");

                entity.Property(e => e.ConnectionGrade)
                    .HasColumnName("connection_grade")
                    .HasMaxLength(60);

                entity.Property(e => e.ConnectionName)
                    .HasColumnName("connection_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ConnectionTorsionalYield).HasColumnName("connection_torsional_yield");

                entity.Property(e => e.ConnectionType)
                    .HasColumnName("connection_type")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactLength).HasColumnName("contact_length");

                entity.Property(e => e.CoringMode)
                    .HasColumnName("coring_mode")
                    .HasMaxLength(1);

                entity.Property(e => e.CorrectionFactor).HasColumnName("correction_factor");

                entity.Property(e => e.CostPerLength).HasColumnName("cost_per_length");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.CriticalPercentAxial).HasColumnName("critical_percent_axial");

                entity.Property(e => e.CriticalPercentCollapse).HasColumnName("critical_percent_collapse");

                entity.Property(e => e.CriticalPercentTriaxial).HasColumnName("critical_percent_triaxial");

                entity.Property(e => e.CriticalPercentTriaxialHoop).HasColumnName("critical_percent_triaxial_hoop");

                entity.Property(e => e.CsgCompGroupCode)
                    .HasColumnName("csg_comp_group_code")
                    .HasMaxLength(6);

                entity.Property(e => e.Density).HasColumnName("density");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Displacement).HasColumnName("displacement");

                entity.Property(e => e.DistanceFromBit).HasColumnName("distance_from_bit");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExternalCompAccId)
                    .HasColumnName("external_comp_acc_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExternalPressureTest).HasColumnName("external_pressure_test");

                entity.Property(e => e.FatigueEnduranceLimit).HasColumnName("fatigue_endurance_limit");

                entity.Property(e => e.FishNeckType)
                    .HasColumnName("fish_neck_type")
                    .HasMaxLength(32);

                entity.Property(e => e.FishneckLength).HasColumnName("fishneck_length");

                entity.Property(e => e.FishneckOd).HasColumnName("fishneck_od");

                entity.Property(e => e.FloatId).HasColumnName("float_id");

                entity.Property(e => e.FrictionCoeff).HasColumnName("friction_coeff");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(60);

                entity.Property(e => e.GradeId)
                    .HasColumnName("grade_id")
                    .HasMaxLength(10);

                entity.Property(e => e.HangerSize).HasColumnName("hanger_size");

                entity.Property(e => e.IdBody).HasColumnName("id_body");

                entity.Property(e => e.IdConnection).HasColumnName("id_connection");

                entity.Property(e => e.IdCoupling).HasColumnName("id_coupling");

                entity.Property(e => e.IdDrift).HasColumnName("id_drift");

                entity.Property(e => e.IdMin).HasColumnName("id_min");

                entity.Property(e => e.IdSleeve).HasColumnName("id_sleeve");

                entity.Property(e => e.InternalPressureTest).HasColumnName("internal_pressure_test");

                entity.Property(e => e.InternalRef)
                    .HasColumnName("internal_ref")
                    .HasMaxLength(16);

                entity.Property(e => e.IsBitFlow)
                    .HasColumnName("is_bit_flow")
                    .HasMaxLength(1);

                entity.Property(e => e.IsFlowOut)
                    .HasColumnName("is_flow_out")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPortOpen)
                    .HasColumnName("is_port_open")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSlotRound)
                    .HasColumnName("is_slot_round")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSlotted)
                    .HasColumnName("is_slotted")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSpiral)
                    .HasColumnName("is_spiral")
                    .HasMaxLength(1);

                entity.Property(e => e.IsThreadlockUsed)
                    .HasColumnName("is_threadlock_used")
                    .HasMaxLength(1);

                entity.Property(e => e.IsUserDefined)
                    .HasColumnName("is_user_defined")
                    .HasMaxLength(1);

                entity.Property(e => e.JointCost).HasColumnName("joint_cost");

                entity.Property(e => e.JointStrength).HasColumnName("joint_strength");

                entity.Property(e => e.JointStrengthCompression).HasColumnName("joint_strength_compression");

                entity.Property(e => e.Joints).HasColumnName("joints");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.LengthInsideCoupling).HasColumnName("length_inside_coupling");

                entity.Property(e => e.LengthOutsideCoupling).HasColumnName("length_outside_coupling");

                entity.Property(e => e.LengthToolJoint).HasColumnName("length_tool_joint");

                entity.Property(e => e.LengthToolJointInside).HasColumnName("length_tool_joint_inside");

                entity.Property(e => e.LinearCapacity).HasColumnName("linear_capacity");

                entity.Property(e => e.MakeupTorque).HasColumnName("makeup_torque");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(60);

                entity.Property(e => e.ManufacturerId)
                    .HasColumnName("manufacturer_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(32);

                entity.Property(e => e.MaterialId)
                    .HasColumnName("material_id")
                    .HasMaxLength(10);

                entity.Property(e => e.MaterialNum)
                    .HasColumnName("material_num")
                    .HasMaxLength(16);

                entity.Property(e => e.MaxBend).HasColumnName("max_bend");

                entity.Property(e => e.MaxHoleSize).HasColumnName("max_hole_size");

                entity.Property(e => e.MaxRecFlowRate).HasColumnName("max_rec_flow_rate");

                entity.Property(e => e.MaxSealPressure).HasColumnName("max_seal_pressure");

                entity.Property(e => e.MaxSlipOd).HasColumnName("max_slip_od");

                entity.Property(e => e.MdBase).HasColumnName("md_base");

                entity.Property(e => e.MdTop).HasColumnName("md_top");

                entity.Property(e => e.MinId).HasColumnName("min_id");

                entity.Property(e => e.MinOpPressure).HasColumnName("min_op_pressure");

                entity.Property(e => e.MinSlipOd).HasColumnName("min_slip_od");

                entity.Property(e => e.MinYieldStress).HasColumnName("min_yield_stress");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(30);

                entity.Property(e => e.NominalSize)
                    .HasColumnName("nominal_size")
                    .HasMaxLength(18);

                entity.Property(e => e.NominalWeight)
                    .HasColumnName("nominal_weight")
                    .HasMaxLength(12);

                entity.Property(e => e.NominalWeightMeasure).HasColumnName("nominal_weight_measure");

                entity.Property(e => e.NumRows).HasColumnName("num_rows");

                entity.Property(e => e.NumberSlots).HasColumnName("number_slots");

                entity.Property(e => e.OdAverage).HasColumnName("od_average");

                entity.Property(e => e.OdBody).HasColumnName("od_body");

                entity.Property(e => e.OdConnection).HasColumnName("od_connection");

                entity.Property(e => e.OdExtended).HasColumnName("od_extended");

                entity.Property(e => e.OdMax).HasColumnName("od_max");

                entity.Property(e => e.OdRetracted).HasColumnName("od_retracted");

                entity.Property(e => e.OdSleeve).HasColumnName("od_sleeve");

                entity.Property(e => e.PercAreaOpen).HasColumnName("perc_area_open");

                entity.Property(e => e.PercentPlugged).HasColumnName("percent_plugged");

                entity.Property(e => e.PerfDensity).HasColumnName("perf_density");

                entity.Property(e => e.PerfHoleDiameter).HasColumnName("perf_hole_diameter");

                entity.Property(e => e.PilotHoleSize).HasColumnName("pilot_hole_size");

                entity.Property(e => e.PipeDataId)
                    .HasColumnName("pipe_data_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PipePressureBurst).HasColumnName("pipe_pressure_burst");

                entity.Property(e => e.PipeRunId)
                    .HasColumnName("pipe_run_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PipeType)
                    .HasColumnName("pipe_type")
                    .HasMaxLength(8);

                entity.Property(e => e.PlainEndCost).HasColumnName("plain_end_cost");

                entity.Property(e => e.PocketSize).HasColumnName("pocket_size");

                entity.Property(e => e.PocketType)
                    .HasColumnName("pocket_type")
                    .HasMaxLength(32);

                entity.Property(e => e.PoissonsRatio).HasColumnName("poissons_ratio");

                entity.Property(e => e.PressRatingBot).HasColumnName("press_rating_bot");

                entity.Property(e => e.PressRatingTop).HasColumnName("press_rating_top");

                entity.Property(e => e.PressureBurst).HasColumnName("pressure_burst");

                entity.Property(e => e.PressureCollapse).HasColumnName("pressure_collapse");

                entity.Property(e => e.ProfileType)
                    .HasColumnName("profile_type")
                    .HasMaxLength(32);

                entity.Property(e => e.PropConnectCatalogId)
                    .HasColumnName("prop_connect_catalog_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PropConnectCatalogItemId)
                    .HasColumnName("prop_connect_catalog_item_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Range)
                    .HasColumnName("range")
                    .HasMaxLength(1);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.SafetyFactor).HasColumnName("safety_factor");

                entity.Property(e => e.ScreenLength).HasColumnName("screen_length");

                entity.Property(e => e.SealType)
                    .HasColumnName("seal_type")
                    .HasMaxLength(32);

                entity.Property(e => e.SectTypeCode)
                    .HasColumnName("sect_type_code")
                    .HasMaxLength(6);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("serial_no")
                    .HasMaxLength(25);

                entity.Property(e => e.ServiceClass)
                    .HasColumnName("service_class")
                    .HasMaxLength(4);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(25);

                entity.Property(e => e.SleeveLength).HasColumnName("sleeve_length");

                entity.Property(e => e.SlipFrictionFactor).HasColumnName("slip_friction_factor");

                entity.Property(e => e.SlipLength).HasColumnName("slip_length");

                entity.Property(e => e.SlipTaperAngle).HasColumnName("slip_taper_angle");

                entity.Property(e => e.SlotBottomMd).HasColumnName("slot_bottom_md");

                entity.Property(e => e.SlotLength).HasColumnName("slot_length");

                entity.Property(e => e.SlotTopMd).HasColumnName("slot_top_md");

                entity.Property(e => e.SlotType)
                    .HasColumnName("slot_type")
                    .HasMaxLength(32);

                entity.Property(e => e.SlotWidth).HasColumnName("slot_width");

                entity.Property(e => e.SubAssemblyCompId)
                    .HasColumnName("sub_assembly_comp_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubAssemblyId)
                    .HasColumnName("sub_assembly_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supplier)
                    .HasColumnName("supplier")
                    .HasMaxLength(60);

                entity.Property(e => e.Tfa).HasColumnName("tfa");

                entity.Property(e => e.ThermalExpansionCoef).HasColumnName("thermal_expansion_coef");

                entity.Property(e => e.ThreadType)
                    .HasColumnName("thread_type")
                    .HasMaxLength(25);

                entity.Property(e => e.TopConnLength).HasColumnName("top_conn_length");

                entity.Property(e => e.TopConnOd).HasColumnName("top_conn_od");

                entity.Property(e => e.TopConnType)
                    .HasColumnName("top_conn_type")
                    .HasMaxLength(50);

                entity.Property(e => e.TorqueMax).HasColumnName("torque_max");

                entity.Property(e => e.TorqueMin).HasColumnName("torque_min");

                entity.Property(e => e.UltimateTensileStrength).HasColumnName("ultimate_tensile_strength");

                entity.Property(e => e.UndercutAngle).HasColumnName("undercut_angle");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.WallThickness).HasColumnName("wall_thickness");

                entity.Property(e => e.WallThicknessPercent).HasColumnName("wall_thickness_percent");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.Property(e => e.WlBoreSize).HasColumnName("wl_bore_size");

                entity.Property(e => e.WorkingPress).HasColumnName("working_press");

                entity.Property(e => e.YieldWeightBody).HasColumnName("yield_weight_body");

                entity.Property(e => e.YieldWeightConn).HasColumnName("yield_weight_conn");

                entity.Property(e => e.YoungsModulus).HasColumnName("youngs_modulus");

                entity.HasOne(d => d.CdAssemblyT)
                    .WithMany(p => p.CdAssemblyCompT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId, d.AssemblyId })
                    .HasConstraintName("R_831");
            });

            modelBuilder.Entity<CdAssemblyDetailT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.AssemblyId, e.AssemblyDetailId })
                    .HasName("XPKCD_ASSEMBLY_DETAIL_T");

                entity.ToTable("CD_ASSEMBLY_DETAIL_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyId)
                    .HasColumnName("assembly_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyDetailId)
                    .HasColumnName("assembly_detail_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApproximateWeight).HasColumnName("approximate_weight");

                entity.Property(e => e.Comments1)
                    .HasColumnName("comments_1")
                    .HasMaxLength(1000);

                entity.Property(e => e.Comments2)
                    .HasColumnName("comments_2")
                    .HasMaxLength(1000);

                entity.Property(e => e.ConnectionName)
                    .HasColumnName("connection_name")
                    .HasMaxLength(50);

                entity.Property(e => e.GradeId)
                    .HasColumnName("grade_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdBody).HasColumnName("id_body");

                entity.Property(e => e.IdConnection).HasColumnName("id_connection");

                entity.Property(e => e.IdDrift).HasColumnName("id_drift");

                entity.Property(e => e.LinearCapacity).HasColumnName("linear_capacity");

                entity.Property(e => e.MdBase).HasColumnName("md_base");

                entity.Property(e => e.MdTop).HasColumnName("md_top");

                entity.Property(e => e.OdBody).HasColumnName("od_body");

                entity.Property(e => e.OdConnection).HasColumnName("od_connection");

                entity.Property(e => e.PressureBurst).HasColumnName("pressure_burst");

                entity.Property(e => e.PressureCollapse).HasColumnName("pressure_collapse");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.TubingDesc)
                    .HasColumnName("tubing_desc")
                    .HasMaxLength(128);

                entity.Property(e => e.YieldStrength).HasColumnName("yield_strength");

                entity.HasOne(d => d.CdAssemblyT)
                    .WithMany(p => p.CdAssemblyDetailT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId, d.AssemblyId })
                    .HasConstraintName("CD_ASSEMBLY_DETAIL_PARENT");
            });

            modelBuilder.Entity<CdAssemblyT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.AssemblyId })
                    .HasName("XPKCD_ASSEMBLY");

                entity.ToTable("CD_ASSEMBLY_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyId)
                    .HasColumnName("assembly_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyName)
                    .HasColumnName("assembly_name")
                    .HasMaxLength(50);

                entity.Property(e => e.AssemblyNo)
                    .HasColumnName("assembly_no")
                    .HasMaxLength(20);

                entity.Property(e => e.AssemblySize).HasColumnName("assembly_size");

                entity.Property(e => e.AssemblyType)
                    .HasColumnName("assembly_type")
                    .HasMaxLength(50);

                entity.Property(e => e.CasingCutOff).HasColumnName("casing_cut_off");

                entity.Property(e => e.CementDayNo).HasColumnName("cement_day_no");

                entity.Property(e => e.ConcentricAssemblyId)
                    .HasColumnName("concentric_assembly_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConcentricAssemblyWbId)
                    .HasColumnName("concentric_assembly_wb_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateReport)
                    .HasColumnName("date_report")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesignLife)
                    .HasColumnName("design_life")
                    .HasMaxLength(6);

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoleSize).HasColumnName("hole_size");

                entity.Property(e => e.IdMin).HasColumnName("id_min");

                entity.Property(e => e.IsCasingLiner)
                    .HasColumnName("is_casing_liner")
                    .HasMaxLength(1);

                entity.Property(e => e.IsParallel)
                    .HasColumnName("is_parallel")
                    .HasMaxLength(1);

                entity.Property(e => e.IsTopDown)
                    .HasColumnName("is_top_down")
                    .HasMaxLength(1);

                entity.Property(e => e.LengthTotal).HasColumnName("length_total");

                entity.Property(e => e.MdAssemblyBase).HasColumnName("md_assembly_base");

                entity.Property(e => e.MdAssemblyTop).HasColumnName("md_assembly_top");

                entity.Property(e => e.MdSetDepthCorrection).HasColumnName("md_set_depth_correction");

                entity.Property(e => e.MdToc).HasColumnName("md_toc");

                entity.Property(e => e.MudDensityShoe).HasColumnName("mud_density_shoe");

                entity.Property(e => e.NoCompletionTrips).HasColumnName("no_completion_trips");

                entity.Property(e => e.OdMax).HasColumnName("od_max");

                entity.Property(e => e.Overlap).HasColumnName("overlap");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(10);

                entity.Property(e => e.PilotHoleSize).HasColumnName("pilot_hole_size");

                entity.Property(e => e.PipeRunId)
                    .HasColumnName("pipe_run_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlanDepthType).HasColumnName("plan_depth_type");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.ReportJournalId)
                    .HasColumnName("report_journal_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RodLoadFactor).HasColumnName("rod_load_factor");

                entity.Property(e => e.RodSvcFactor).HasColumnName("rod_svc_factor");

                entity.Property(e => e.SandControlEquipment)
                    .HasColumnName("sand_control_equipment")
                    .HasMaxLength(1);

                entity.Property(e => e.SetDayNo).HasColumnName("set_day_no");

                entity.Property(e => e.StringClass)
                    .HasColumnName("string_class")
                    .HasMaxLength(16);

                entity.Property(e => e.StringType)
                    .HasColumnName("string_type")
                    .HasMaxLength(20);

                entity.Property(e => e.SuspPoint)
                    .HasColumnName("susp_point")
                    .HasMaxLength(50);

                entity.Property(e => e.SuspPointCorrection).HasColumnName("susp_point_correction");

                entity.Property(e => e.TvdAssemblyBase).HasColumnName("tvd_assembly_base");

                entity.Property(e => e.TvdAssemblyTop).HasColumnName("tvd_assembly_top");

                entity.Property(e => e.TvdToc).HasColumnName("tvd_toc");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.WeightAboveJars).HasColumnName("weight_above_jars");

                entity.Property(e => e.WeightBelowJars).HasColumnName("weight_below_jars");

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.CdAssemblyT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId })
                    .HasConstraintName("R_537");
            });

            modelBuilder.Entity<CdBhaCompBitT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.AssemblyId, e.AssemblyCompId })
                    .HasName("XPKCD_BHA_COMP_BIT");

                entity.ToTable("CD_BHA_COMP_BIT_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyId)
                    .HasColumnName("assembly_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyCompId)
                    .HasColumnName("assembly_comp_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BitClass)
                    .HasColumnName("bit_class")
                    .HasMaxLength(20);

                entity.Property(e => e.BitDrive)
                    .HasColumnName("bit_drive")
                    .HasMaxLength(8);

                entity.Property(e => e.BitGroup)
                    .HasColumnName("bit_group")
                    .HasMaxLength(20);

                entity.Property(e => e.BitNo)
                    .HasColumnName("bit_no")
                    .HasMaxLength(20);

                entity.Property(e => e.BitSize).HasColumnName("bit_size");

                entity.Property(e => e.BitSizePassThrough).HasColumnName("bit_size_pass_through");

                entity.Property(e => e.BitSizePilot).HasColumnName("bit_size_pilot");

                entity.Property(e => e.CurrencyUsed)
                    .HasColumnName("currency_used")
                    .HasMaxLength(3);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.HoursOnBit).HasColumnName("hours_on_bit");

                entity.Property(e => e.IadcBearing)
                    .HasColumnName("iadc_bearing")
                    .HasMaxLength(1);

                entity.Property(e => e.IadcCode)
                    .HasColumnName("iadc_code")
                    .HasMaxLength(10);

                entity.Property(e => e.IadcDull)
                    .HasColumnName("iadc_dull")
                    .HasMaxLength(2);

                entity.Property(e => e.IadcGauge)
                    .HasColumnName("iadc_gauge")
                    .HasMaxLength(2);

                entity.Property(e => e.IadcInner)
                    .HasColumnName("iadc_inner")
                    .HasMaxLength(2);

                entity.Property(e => e.IadcLocation)
                    .HasColumnName("iadc_location")
                    .HasMaxLength(4);

                entity.Property(e => e.IadcOther)
                    .HasColumnName("iadc_other")
                    .HasMaxLength(2);

                entity.Property(e => e.IadcOuter)
                    .HasColumnName("iadc_outer")
                    .HasMaxLength(2);

                entity.Property(e => e.IadcReasonPulled)
                    .HasColumnName("iadc_reason_pulled")
                    .HasMaxLength(3);

                entity.Property(e => e.IsLeftInWell)
                    .HasColumnName("is_left_in_well")
                    .HasMaxLength(1);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.RerunNo)
                    .HasColumnName("rerun_no")
                    .HasMaxLength(20);

                entity.HasOne(d => d.CdAssemblyCompT)
                    .WithOne(p => p.CdBhaCompBitT)
                    .HasForeignKey<CdBhaCompBitT>(d => new { d.WellId, d.WellboreId, d.AssemblyId, d.AssemblyCompId })
                    .HasConstraintName("R_2108");
            });

            modelBuilder.Entity<CdCementFluidScheduleT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.CementJobId, e.CementStageId, e.FluidScheduleId })
                    .HasName("XPKCD_CEMENT_FLUID_SCHEDULE");

                entity.ToTable("CD_CEMENT_FLUID_SCHEDULE_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CementJobId)
                    .HasColumnName("cement_job_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CementStageId)
                    .HasColumnName("cement_stage_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FluidScheduleId)
                    .HasColumnName("fluid_schedule_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BhCircTemp).HasColumnName("bh_circ_temp");

                entity.Property(e => e.BhStaticTemp).HasColumnName("bh_static_temp");

                entity.Property(e => e.BulkCement).HasColumnName("bulk_cement");

                entity.Property(e => e.CdrmFoamDensity).HasColumnName("cdrm_foam_density");

                entity.Property(e => e.CdrmRatioFinal).HasColumnName("cdrm_ratio_final");

                entity.Property(e => e.CdrmRatioInitial).HasColumnName("cdrm_ratio_initial");

                entity.Property(e => e.CementFluidId)
                    .HasColumnName("cement_fluid_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CgrmFoamDensityAvg).HasColumnName("cgrm_foam_density_avg");

                entity.Property(e => e.CgrmGlRatio).HasColumnName("cgrm_gl_ratio");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEndPumping)
                    .HasColumnName("date_end_pumping")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStartDisplace)
                    .HasColumnName("date_start_displace")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStartMixing)
                    .HasColumnName("date_start_mixing")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStartSlurry)
                    .HasColumnName("date_start_slurry")
                    .HasColumnType("datetime");

                entity.Property(e => e.Density).HasColumnName("density");

                entity.Property(e => e.DispPressureFinal).HasColumnName("disp_pressure_final");

                entity.Property(e => e.DispRateAvg).HasColumnName("disp_rate_avg");

                entity.Property(e => e.FlowlineTemp).HasColumnName("flowline_temp");

                entity.Property(e => e.FoamGasType)
                    .HasColumnName("foam_gas_type")
                    .HasMaxLength(20);

                entity.Property(e => e.FoamGasVolUsed).HasColumnName("foam_gas_vol_used");

                entity.Property(e => e.GasRateNumber).HasColumnName("gas_rate_number");

                entity.Property(e => e.IsFoamCgrm)
                    .HasColumnName("is_foam_cgrm")
                    .HasMaxLength(1);

                entity.Property(e => e.IsFoamJob)
                    .HasColumnName("is_foam_job")
                    .HasMaxLength(1);

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.MdBase).HasColumnName("md_base");

                entity.Property(e => e.MdTop).HasColumnName("md_top");

                entity.Property(e => e.MixingRate).HasColumnName("mixing_rate");

                entity.Property(e => e.Operation)
                    .HasColumnName("operation")
                    .HasMaxLength(50);

                entity.Property(e => e.OverflushVol).HasColumnName("overflush_vol");

                entity.Property(e => e.PlacementMethod)
                    .HasColumnName("placement_method")
                    .HasMaxLength(50);

                entity.Property(e => e.PreflushVol).HasColumnName("preflush_vol");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.RateFinal).HasColumnName("rate_final");

                entity.Property(e => e.RateMax).HasColumnName("rate_max");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.ShutdownTime).HasColumnName("shutdown_time");

                entity.Property(e => e.StrokeRate).HasColumnName("stroke_rate");

                entity.Property(e => e.Strokes).HasColumnName("strokes");

                entity.Property(e => e.SurfaceMixTemp).HasColumnName("surface_mix_temp");

                entity.Property(e => e.TopOfFluid).HasColumnName("top_of_fluid");

                entity.Property(e => e.TopOfFluidTvd).HasColumnName("top_of_fluid_tvd");

                entity.Property(e => e.VolBackWash).HasColumnName("vol_back_wash");

                entity.Property(e => e.Volume).HasColumnName("volume");

                entity.HasOne(d => d.CdCementStageT)
                    .WithMany(p => p.CdCementFluidScheduleT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId, d.CementJobId, d.CementStageId })
                    .HasConstraintName("R_2283");
            });

            modelBuilder.Entity<CdCementFluidT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.CementJobId, e.CementFluidId })
                    .HasName("XPKCD_CEMENT_FLUID");

                entity.ToTable("CD_CEMENT_FLUID_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CementJobId)
                    .HasColumnName("cement_job_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CementFluidId)
                    .HasColumnName("cement_fluid_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cc30Min).HasColumnName("cc_30_min");

                entity.Property(e => e.Deflection).HasColumnName("deflection");

                entity.Property(e => e.Density).HasColumnName("density");

                entity.Property(e => e.DensityAtPress).HasColumnName("density_at_press");

                entity.Property(e => e.DensityMethod)
                    .HasColumnName("density_method")
                    .HasMaxLength(10);

                entity.Property(e => e.ExcessMeasType)
                    .HasColumnName("excess_meas_type")
                    .HasMaxLength(16);

                entity.Property(e => e.ExcessSlurryPercent).HasColumnName("excess_slurry_percent");

                entity.Property(e => e.ExcessSlurryVol).HasColumnName("excess_slurry_vol");

                entity.Property(e => e.FluidName)
                    .HasColumnName("fluid_name")
                    .HasMaxLength(80);

                entity.Property(e => e.FluidType)
                    .HasColumnName("fluid_type")
                    .HasMaxLength(32);

                entity.Property(e => e.GaugedAnnularVol).HasColumnName("gauged_annular_vol");

                entity.Property(e => e.Gels10Min).HasColumnName("gels_10_min");

                entity.Property(e => e.Gels10Sec).HasColumnName("gels_10_sec");

                entity.Property(e => e.Gels30Min).HasColumnName("gels_30_min");

                entity.Property(e => e.MixWaterRatio).HasColumnName("mix_water_ratio");

                entity.Property(e => e.MudType)
                    .HasColumnName("mud_type")
                    .HasMaxLength(32);

                entity.Property(e => e.PressMeasDens).HasColumnName("press_meas_dens");

                entity.Property(e => e.Pv).HasColumnName("pv");

                entity.Property(e => e.Rpm).HasColumnName("rpm");

                entity.Property(e => e.SackSize).HasColumnName("sack_size");

                entity.Property(e => e.SacksCalculated).HasColumnName("sacks_calculated");

                entity.Property(e => e.SacksUsed).HasColumnName("sacks_used");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.SlurryBaseTvd).HasColumnName("slurry_base_tvd");

                entity.Property(e => e.SlurryClass)
                    .HasColumnName("slurry_class")
                    .HasMaxLength(10);

                entity.Property(e => e.SlurryDensity).HasColumnName("slurry_density");

                entity.Property(e => e.SlurryDesc)
                    .HasColumnName("slurry_desc")
                    .HasMaxLength(25);

                entity.Property(e => e.SlurryMixMethod)
                    .HasColumnName("slurry_mix_method")
                    .HasMaxLength(10);

                entity.Property(e => e.SlurryPurpose)
                    .HasColumnName("slurry_purpose")
                    .HasMaxLength(20);

                entity.Property(e => e.SlurryTopTvd).HasColumnName("slurry_top_tvd");

                entity.Property(e => e.SlurryType)
                    .HasColumnName("slurry_type")
                    .HasMaxLength(32);

                entity.Property(e => e.SlurryYield).HasColumnName("slurry_yield");

                entity.Property(e => e.SourceWater)
                    .HasColumnName("source_water")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceWaterTemp).HasColumnName("source_water_temp");

                entity.Property(e => e.TempDensity).HasColumnName("temp_density");

                entity.Property(e => e.TempRheology).HasColumnName("temp_rheology");

                entity.Property(e => e.Viscosity).HasColumnName("viscosity");

                entity.Property(e => e.VolCementUsed).HasColumnName("vol_cement_used");

                entity.Property(e => e.VolOtherUsed).HasColumnName("vol_other_used");

                entity.Property(e => e.VolSlurry).HasColumnName("vol_slurry");

                entity.Property(e => e.VolSlurryInWell).HasColumnName("vol_slurry_in_well");

                entity.Property(e => e.VolWaterUsed).HasColumnName("vol_water_used");

                entity.Property(e => e.Yp).HasColumnName("yp");

                entity.HasOne(d => d.CdCementJobT)
                    .WithMany(p => p.CdCementFluidT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId, d.CementJobId })
                    .HasConstraintName("R_2234");
            });

            modelBuilder.Entity<CdCementJobT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.CementJobId })
                    .HasName("XPKCD_CEMENT_JOB");

                entity.ToTable("CD_CEMENT_JOB_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CementJobId)
                    .HasColumnName("cement_job_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActivityPhase)
                    .HasColumnName("activity_phase")
                    .HasMaxLength(20);

                entity.Property(e => e.AssemblyId)
                    .HasColumnName("assembly_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyWbId)
                    .HasColumnName("assembly_wb_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BottomHoleTemperature).HasColumnName("bottom_hole_temperature");

                entity.Property(e => e.CasingTestDuration).HasColumnName("casing_test_duration");

                entity.Property(e => e.CasingTestPress).HasColumnName("casing_test_press");

                entity.Property(e => e.CblPress).HasColumnName("cbl_press");

                entity.Property(e => e.CblQuality)
                    .HasColumnName("cbl_quality")
                    .HasMaxLength(10);

                entity.Property(e => e.CementJobNote)
                    .HasColumnName("cement_job_note")
                    .HasColumnType("ntext");

                entity.Property(e => e.CetQuality)
                    .HasColumnName("cet_quality")
                    .HasMaxLength(10);

                entity.Property(e => e.Contractor)
                    .HasColumnName("contractor")
                    .HasMaxLength(60);

                entity.Property(e => e.ContractorArrivalDate)
                    .HasColumnName("contractor_arrival_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractorForeman)
                    .HasColumnName("contractor_foreman")
                    .HasMaxLength(60);

                entity.Property(e => e.DateReport)
                    .HasColumnName("date_report")
                    .HasColumnType("datetime");

                entity.Property(e => e.DayNo)
                    .HasColumnName("day_no")
                    .HasMaxLength(4);

                entity.Property(e => e.DetectionIndicator)
                    .HasColumnName("detection_indicator")
                    .HasMaxLength(10);

                entity.Property(e => e.DrilledOutDate)
                    .HasColumnName("drilled_out_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FluidDensity).HasColumnName("fluid_density");

                entity.Property(e => e.GeothermalGradient).HasColumnName("geothermal_gradient");

                entity.Property(e => e.IsBhtLogRun)
                    .HasColumnName("is_bht_log_run")
                    .HasMaxLength(1);

                entity.Property(e => e.IsCblRun)
                    .HasColumnName("is_cbl_run")
                    .HasMaxLength(1);

                entity.Property(e => e.IsCementFound)
                    .HasColumnName("is_cement_found")
                    .HasMaxLength(1);

                entity.Property(e => e.IsCementFoundLiner)
                    .HasColumnName("is_cement_found_liner")
                    .HasMaxLength(1);

                entity.Property(e => e.IsCetRun)
                    .HasColumnName("is_cet_run")
                    .HasMaxLength(1);

                entity.Property(e => e.IsCo2Used)
                    .HasColumnName("is_co2_used")
                    .HasMaxLength(1);

                entity.Property(e => e.IsDrilledOut)
                    .HasColumnName("is_drilled_out")
                    .HasMaxLength(1);

                entity.Property(e => e.IsLinerNegTestTool)
                    .HasColumnName("is_liner_neg_test_tool")
                    .HasMaxLength(1);

                entity.Property(e => e.IsLinerPosTestTool)
                    .HasColumnName("is_liner_pos_test_tool")
                    .HasMaxLength(1);

                entity.Property(e => e.IsN2Used)
                    .HasColumnName("is_n2_used")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPipePulledWet)
                    .HasColumnName("is_pipe_pulled_wet")
                    .HasMaxLength(1);

                entity.Property(e => e.IsRemCementRequired)
                    .HasColumnName("is_rem_cement_required")
                    .HasMaxLength(1);

                entity.Property(e => e.IsShoeTestToolUsed)
                    .HasColumnName("is_shoe_test_tool_used")
                    .HasMaxLength(1);

                entity.Property(e => e.IsTocSufficient)
                    .HasColumnName("is_toc_sufficient")
                    .HasMaxLength(1);

                entity.Property(e => e.IsZoneIsolated)
                    .HasColumnName("is_zone_isolated")
                    .HasMaxLength(1);

                entity.Property(e => e.JobDesc)
                    .HasColumnName("job_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.JobEndDate)
                    .HasColumnName("job_end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobRating)
                    .HasColumnName("job_rating")
                    .HasMaxLength(10);

                entity.Property(e => e.JobStartDate)
                    .HasColumnName("job_start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobType)
                    .HasColumnName("job_type")
                    .HasMaxLength(50);

                entity.Property(e => e.LinerEmwNegTest).HasColumnName("liner_emw_neg_test");

                entity.Property(e => e.LinerEmwPosTest).HasColumnName("liner_emw_pos_test");

                entity.Property(e => e.LinerOverlap).HasColumnName("liner_overlap");

                entity.Property(e => e.LogInterpretation)
                    .HasColumnName("log_interpretation")
                    .HasColumnType("ntext");

                entity.Property(e => e.LogInterpreter)
                    .HasColumnName("log_interpreter")
                    .HasMaxLength(64);

                entity.Property(e => e.MdFloat).HasColumnName("md_float");

                entity.Property(e => e.NumSqueezes).HasColumnName("num_squeezes");

                entity.Property(e => e.PackerMd).HasColumnName("packer_md");

                entity.Property(e => e.PackerTvd).HasColumnName("packer_tvd");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(10);

                entity.Property(e => e.PipeMovementDesc)
                    .HasColumnName("pipe_movement_desc")
                    .HasMaxLength(20);

                entity.Property(e => e.PipePullRate).HasColumnName("pipe_pull_rate");

                entity.Property(e => e.PlugMdBase).HasColumnName("plug_md_base");

                entity.Property(e => e.PlugMdTop).HasColumnName("plug_md_top");

                entity.Property(e => e.PlugTvdBase).HasColumnName("plug_tvd_base");

                entity.Property(e => e.PlugTvdTop).HasColumnName("plug_tvd_top");

                entity.Property(e => e.PlugType)
                    .HasColumnName("plug_type")
                    .HasMaxLength(16);

                entity.Property(e => e.PressTestDate)
                    .HasColumnName("press_test_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RatHoleLength).HasColumnName("rat_hole_length");

                entity.Property(e => e.RecipDragDown).HasColumnName("recip_drag_down");

                entity.Property(e => e.RecipDragUp).HasColumnName("recip_drag_up");

                entity.Property(e => e.RecipFinishTime)
                    .HasColumnName("recip_finish_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecipSpm).HasColumnName("recip_spm");

                entity.Property(e => e.RecipStartTime)
                    .HasColumnName("recip_start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecipStrokeLength).HasColumnName("recip_stroke_length");

                entity.Property(e => e.ReportJournalId)
                    .HasColumnName("report_journal_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RotatingFinishTime)
                    .HasColumnName("rotating_finish_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RotatingRpm).HasColumnName("rotating_rpm");

                entity.Property(e => e.RotatingStartTime)
                    .HasColumnName("rotating_start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RotatingTorqueAvg).HasColumnName("rotating_torque_avg");

                entity.Property(e => e.RotatingTorqueInitial).HasColumnName("rotating_torque_initial");

                entity.Property(e => e.RotatingTorqueMax).HasColumnName("rotating_torque_max");

                entity.Property(e => e.ScenarioId)
                    .HasColumnName("scenario_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeabedTemp).HasColumnName("seabed_temp");

                entity.Property(e => e.ShoeTestOpenHole).HasColumnName("shoe_test_open_hole");

                entity.Property(e => e.ShoeTestPress).HasColumnName("shoe_test_press");

                entity.Property(e => e.ShoetrackDrillDate)
                    .HasColumnName("shoetrack_drill_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShoetrackDrillDistance).HasColumnName("shoetrack_drill_distance");

                entity.Property(e => e.ShoetrackDrillMd).HasColumnName("shoetrack_drill_md");

                entity.Property(e => e.ShoetrackDrillTvd).HasColumnName("shoetrack_drill_tvd");

                entity.Property(e => e.ShoetrackTopMd).HasColumnName("shoetrack_top_md");

                entity.Property(e => e.ShoetrackTopTvd).HasColumnName("shoetrack_top_tvd");

                entity.Property(e => e.SqueezeDate)
                    .HasColumnName("squeeze_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SqueezeDepth).HasColumnName("squeeze_depth");

                entity.Property(e => e.SqueezeTvd).HasColumnName("squeeze_tvd");

                entity.Property(e => e.SqueezeType)
                    .HasColumnName("squeeze_type")
                    .HasMaxLength(16);

                entity.Property(e => e.SurfaceAirTemp).HasColumnName("surface_air_temp");

                entity.Property(e => e.SurfaceAnnulusTemp).HasColumnName("surface_annulus_temp");

                entity.Property(e => e.SurfaceGroundTemp).HasColumnName("surface_ground_temp");

                entity.Property(e => e.TestComments)
                    .HasColumnName("test_comments")
                    .HasColumnType("ntext");

                entity.Property(e => e.TestSectionMdBase).HasColumnName("test_section_md_base");

                entity.Property(e => e.TestSectionMdTop).HasColumnName("test_section_md_top");

                entity.Property(e => e.TestSectionTvdBase).HasColumnName("test_section_tvd_base");

                entity.Property(e => e.TestSectionTvdTop).HasColumnName("test_section_tvd_top");

                entity.Property(e => e.TimeBeforeLinerTest).HasColumnName("time_before_liner_test");

                entity.Property(e => e.TimeBeforeLogging).HasColumnName("time_before_logging");

                entity.Property(e => e.TimeBeforeShoeTest).HasColumnName("time_before_shoe_test");

                entity.Property(e => e.TocLocateMethod)
                    .HasColumnName("toc_locate_method")
                    .HasMaxLength(20);

                entity.Property(e => e.TocMd).HasColumnName("toc_md");

                entity.Property(e => e.TocTvd).HasColumnName("toc_tvd");

                entity.Property(e => e.TvdFloat).HasColumnName("tvd_float");

                entity.Property(e => e.WellboreOpeningId)
                    .HasColumnName("wellbore_opening_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Woc).HasColumnName("woc");

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.CdCementJobT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId })
                    .HasConstraintName("R_2278");
            });

            modelBuilder.Entity<CdCementPlugStatusT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.CementJobId, e.CementStageId, e.CementPlugStatusId })
                    .HasName("XPKCD_CEMENT_PLUG_STATUS");

                entity.ToTable("CD_CEMENT_PLUG_STATUS_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CementJobId)
                    .HasColumnName("cement_job_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CementStageId)
                    .HasColumnName("cement_stage_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CementPlugStatusId)
                    .HasColumnName("cement_plug_status_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MdBase).HasColumnName("md_base");

                entity.Property(e => e.MdTop).HasColumnName("md_top");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(32);

                entity.Property(e => e.StatusDate)
                    .HasColumnName("status_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TvdBase).HasColumnName("tvd_base");

                entity.Property(e => e.TvdTop).HasColumnName("tvd_top");

                entity.HasOne(d => d.CdCementStageT)
                    .WithMany(p => p.CdCementPlugStatusT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId, d.CementJobId, d.CementStageId })
                    .HasConstraintName("R_2236");
            });

            modelBuilder.Entity<CdCementStageT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.CementJobId, e.CementStageId })
                    .HasName("XPKCD_CEMENT_STAGE");

                entity.ToTable("CD_CEMENT_STAGE_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CementJobId)
                    .HasColumnName("cement_job_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CementStageId)
                    .HasColumnName("cement_stage_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CasingPressureFinal).HasColumnName("casing_pressure_final");

                entity.Property(e => e.CasingPressureInitial).HasColumnName("casing_pressure_initial");

                entity.Property(e => e.CementToolContractor)
                    .HasColumnName("cement_tool_contractor")
                    .HasMaxLength(60);

                entity.Property(e => e.CementToolDesc)
                    .HasColumnName("cement_tool_desc")
                    .HasMaxLength(25);

                entity.Property(e => e.CementedWellboreId)
                    .HasColumnName("cemented_wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CircDurationBefore).HasColumnName("circ_duration_before");

                entity.Property(e => e.CircFlowrate).HasColumnName("circ_flowrate");

                entity.Property(e => e.CircPress).HasColumnName("circ_press");

                entity.Property(e => e.CtuPressFinal).HasColumnName("ctu_press_final");

                entity.Property(e => e.CtuPressInitial).HasColumnName("ctu_press_initial");

                entity.Property(e => e.ExcessPercent).HasColumnName("excess_percent");

                entity.Property(e => e.ExcessVolume).HasColumnName("excess_volume");

                entity.Property(e => e.FloatHeldDate)
                    .HasColumnName("float_held_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HesitationReason)
                    .HasColumnName("hesitation_reason")
                    .HasMaxLength(255);

                entity.Property(e => e.HoleSize).HasColumnName("hole_size");

                entity.Property(e => e.IsAnnPressHeld)
                    .HasColumnName("is_ann_press_held")
                    .HasMaxLength(1);

                entity.Property(e => e.IsBottomPlugUsed)
                    .HasColumnName("is_bottom_plug_used")
                    .HasMaxLength(1);

                entity.Property(e => e.IsCoilTubingUsed)
                    .HasColumnName("is_coil_tubing_used")
                    .HasMaxLength(1);

                entity.Property(e => e.IsHesitation)
                    .HasColumnName("is_hesitation")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPillBelowPlug)
                    .HasColumnName("is_pill_below_plug")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPlugBumped)
                    .HasColumnName("is_plug_bumped")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPlugCatcherUsed)
                    .HasColumnName("is_plug_catcher_used")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPrimaryAnnularFlow)
                    .HasColumnName("is_primary_annular_flow")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPrimaryFloatHeld)
                    .HasColumnName("is_primary_float_held")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSqueezeGood)
                    .HasColumnName("is_squeeze_good")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSqueezePressHeld)
                    .HasColumnName("is_squeeze_press_held")
                    .HasMaxLength(1);

                entity.Property(e => e.IsTailPipePerfed)
                    .HasColumnName("is_tail_pipe_perfed")
                    .HasMaxLength(1);

                entity.Property(e => e.IsTailPipeUsed)
                    .HasColumnName("is_tail_pipe_used")
                    .HasMaxLength(1);

                entity.Property(e => e.IsTopPlugUsed)
                    .HasColumnName("is_top_plug_used")
                    .HasMaxLength(1);

                entity.Property(e => e.MdBase).HasColumnName("md_base");

                entity.Property(e => e.MdCementTool).HasColumnName("md_cement_tool");

                entity.Property(e => e.MdCtu).HasColumnName("md_ctu");

                entity.Property(e => e.MdPlugCirc).HasColumnName("md_plug_circ");

                entity.Property(e => e.MdStageTool).HasColumnName("md_stage_tool");

                entity.Property(e => e.MdTop).HasColumnName("md_top");

                entity.Property(e => e.PlugBumpedDate)
                    .HasColumnName("plug_bumped_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PressureHeld).HasColumnName("pressure_held");

                entity.Property(e => e.PressureRemaining).HasColumnName("pressure_remaining");

                entity.Property(e => e.PrimaryPressureBump).HasColumnName("primary_pressure_bump");

                entity.Property(e => e.PrimaryPressurePriorBump).HasColumnName("primary_pressure_prior_bump");

                entity.Property(e => e.PrimaryReturnsSacks).HasColumnName("primary_returns_sacks");

                entity.Property(e => e.PrimaryVolumeReturns).HasColumnName("primary_volume_returns");

                entity.Property(e => e.Returns)
                    .HasColumnName("returns")
                    .HasMaxLength(16);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.SqueezeBreakPress).HasColumnName("squeeze_break_press");

                entity.Property(e => e.SqueezeBreakRate).HasColumnName("squeeze_break_rate");

                entity.Property(e => e.SqueezeObjective)
                    .HasColumnName("squeeze_objective")
                    .HasMaxLength(16);

                entity.Property(e => e.SqueezePressAvg).HasColumnName("squeeze_press_avg");

                entity.Property(e => e.SqueezePressFinal).HasColumnName("squeeze_press_final");

                entity.Property(e => e.SqueezePressHeldTime).HasColumnName("squeeze_press_held_time");

                entity.Property(e => e.SqueezePumpRateAvg).HasColumnName("squeeze_pump_rate_avg");

                entity.Property(e => e.SqueezePumpRateFinal).HasColumnName("squeeze_pump_rate_final");

                entity.Property(e => e.SqueezePumpRateInitial).HasColumnName("squeeze_pump_rate_initial");

                entity.Property(e => e.SqueezePumpRateMax).HasColumnName("squeeze_pump_rate_max");

                entity.Property(e => e.SqueezeToolMd).HasColumnName("squeeze_tool_md");

                entity.Property(e => e.SqueezeToolTvd).HasColumnName("squeeze_tool_tvd");

                entity.Property(e => e.SqueezeVolInCasing).HasColumnName("squeeze_vol_in_casing");

                entity.Property(e => e.SqueezeVolOutCasing).HasColumnName("squeeze_vol_out_casing");

                entity.Property(e => e.SqueezeVolReversed).HasColumnName("squeeze_vol_reversed");

                entity.Property(e => e.SqueezeWorkstringDepth).HasColumnName("squeeze_workstring_depth");

                entity.Property(e => e.SqueezeWorkstringTvd).HasColumnName("squeeze_workstring_tvd");

                entity.Property(e => e.StageNo).HasColumnName("stage_no");

                entity.Property(e => e.StageToolDesc)
                    .HasColumnName("stage_tool_desc")
                    .HasMaxLength(25);

                entity.Property(e => e.StageType)
                    .HasColumnName("stage_type")
                    .HasMaxLength(20);

                entity.Property(e => e.TailPipeSize).HasColumnName("tail_pipe_size");

                entity.Property(e => e.TimePressureHeld).HasColumnName("time_pressure_held");

                entity.Property(e => e.TubingPressFinal).HasColumnName("tubing_press_final");

                entity.Property(e => e.TubingPressInitial).HasColumnName("tubing_press_initial");

                entity.Property(e => e.TvdBase).HasColumnName("tvd_base");

                entity.Property(e => e.TvdCementTool).HasColumnName("tvd_cement_tool");

                entity.Property(e => e.TvdCtu).HasColumnName("tvd_ctu");

                entity.Property(e => e.TvdPlugCirc).HasColumnName("tvd_plug_circ");

                entity.Property(e => e.TvdStageTool).HasColumnName("tvd_stage_tool");

                entity.Property(e => e.TvdTop).HasColumnName("tvd_top");

                entity.Property(e => e.VolLost).HasColumnName("vol_lost");

                entity.Property(e => e.WocTime).HasColumnName("woc_time");

                entity.HasOne(d => d.CdCementJobT)
                    .WithMany(p => p.CdCementStageT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId, d.CementJobId })
                    .HasConstraintName("R_379");
            });

            modelBuilder.Entity<CdDatumT>(entity =>
            {
                entity.HasKey(e => new { e.DatumId, e.WellId })
                    .HasName("XPKCD_DATUM");

                entity.ToTable("CD_DATUM_T");

                entity.Property(e => e.DatumId)
                    .HasColumnName("datum_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContractorId)
                    .HasColumnName("contractor_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateEstablished)
                    .HasColumnName("date_established")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatumDescription)
                    .HasColumnName("datum_description")
                    .HasMaxLength(60);

                entity.Property(e => e.DatumElevation).HasColumnName("datum_elevation");

                entity.Property(e => e.DatumError).HasColumnName("datum_error");

                entity.Property(e => e.DatumName)
                    .HasColumnName("datum_name")
                    .HasMaxLength(60);

                entity.Property(e => e.DatumType).HasColumnName("datum_type");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("is_default")
                    .HasMaxLength(1);

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(10);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.CdDatumT)
                    .HasForeignKey(d => d.WellId)
                    .HasConstraintName("R_312");
            });

            modelBuilder.Entity<CdDefinitiveSurveyHeaderT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.DefSurveyHeaderId })
                    .HasName("XPKCD_DEFINITIVE_SURVEY_HEADER");

                entity.ToTable("CD_DEFINITIVE_SURVEY_HEADER_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefSurveyHeaderId)
                    .HasColumnName("def_survey_header_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AcscanMdMax).HasColumnName("acscan_md_max");

                entity.Property(e => e.AcscanMdMin).HasColumnName("acscan_md_min");

                entity.Property(e => e.AcscanRadiusMax).HasColumnName("acscan_radius_max");

                entity.Property(e => e.AcscanRatioMax).HasColumnName("acscan_ratio_max");

                entity.Property(e => e.AverageDogleg).HasColumnName("average_dogleg");

                entity.Property(e => e.BInterp)
                    .HasColumnName("b_interp")
                    .HasMaxLength(1);

                entity.Property(e => e.BRange)
                    .HasColumnName("b_range")
                    .HasMaxLength(1);

                entity.Property(e => e.BRatio)
                    .HasColumnName("b_ratio")
                    .HasMaxLength(1);

                entity.Property(e => e.BhMd).HasColumnName("bh_md");

                entity.Property(e => e.BhTvd).HasColumnName("bh_tvd");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DefinitivePath).HasColumnName("definitive_path");

                entity.Property(e => e.DefinitiveVersion).HasColumnName("definitive_version");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.DirectionalDifficultyIndex).HasColumnName("directional_difficulty_index");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("effective_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinalEast).HasColumnName("final_east");

                entity.Property(e => e.FinalError).HasColumnName("final_error");

                entity.Property(e => e.FinalNorth).HasColumnName("final_north");

                entity.Property(e => e.Interpolate)
                    .HasColumnName("interpolate")
                    .HasMaxLength(1);

                entity.Property(e => e.InterpolationInterval).HasColumnName("interpolation_interval");

                entity.Property(e => e.IsDefinitive)
                    .HasColumnName("is_definitive")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSurveyProgramReadOnly)
                    .HasColumnName("is_survey_program_read_only")
                    .HasMaxLength(1);

                entity.Property(e => e.KoEast).HasColumnName("ko_east");

                entity.Property(e => e.KoMd).HasColumnName("ko_md");

                entity.Property(e => e.KoNorth).HasColumnName("ko_north");

                entity.Property(e => e.KoTvd).HasColumnName("ko_tvd");

                entity.Property(e => e.MaximumDlsDepth).HasColumnName("maximum_dls_depth");

                entity.Property(e => e.MaximumDlsValue).HasColumnName("maximum_dls_value");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30);

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(10);

                entity.Property(e => e.PlannedAzimuth).HasColumnName("planned_azimuth");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.Tortuosity).HasColumnName("tortuosity");

                entity.Property(e => e.TortuosityPeriod).HasColumnName("tortuosity_period");

                entity.Property(e => e.TortuosityType).HasColumnName("tortuosity_type");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.UseActualData)
                    .HasColumnName("use_actual_data")
                    .HasMaxLength(1);

                entity.Property(e => e.UsePlannedProgram)
                    .HasColumnName("use_planned_program")
                    .HasMaxLength(1);

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(20);

                entity.Property(e => e.VsEast).HasColumnName("vs_east");

                entity.Property(e => e.VsNorth).HasColumnName("vs_north");

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.CdDefinitiveSurveyHeaderT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId })
                    .HasConstraintName("R_1469");
            });

            modelBuilder.Entity<CdFluidT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.FluidId })
                    .HasName("XPKCD_FLUID");

                entity.ToTable("CD_FLUID_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FluidId)
                    .HasColumnName("fluid_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Act).HasColumnName("act");

                entity.Property(e => e.Agno3).HasColumnName("agno3");

                entity.Property(e => e.AlkalinityPoint1).HasColumnName("alkalinity_point1");

                entity.Property(e => e.AlkalinityPoint2).HasColumnName("alkalinity_point2");

                entity.Property(e => e.ApiWaterLoss).HasColumnName("api_water_loss");

                entity.Property(e => e.Barite).HasColumnName("barite");

                entity.Property(e => e.BrineIronConc).HasColumnName("brine_iron_conc");

                entity.Property(e => e.BrineSg).HasColumnName("brine_sg");

                entity.Property(e => e.BrineSgTemp).HasColumnName("brine_sg_temp");

                entity.Property(e => e.BrineTurbidity).HasColumnName("brine_turbidity");

                entity.Property(e => e.BrineType)
                    .HasColumnName("brine_type")
                    .HasMaxLength(64);

                entity.Property(e => e.BrineTypeCode)
                    .HasColumnName("brine_type_code")
                    .HasMaxLength(20);

                entity.Property(e => e.CecShale).HasColumnName("cec_shale");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasMaxLength(20);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(60);

                entity.Property(e => e.ConcBicarbonate).HasColumnName("conc_bicarbonate");

                entity.Property(e => e.ConcCa).HasColumnName("conc_ca");

                entity.Property(e => e.ConcCaWholeMud).HasColumnName("conc_ca_whole_mud");

                entity.Property(e => e.ConcCacl).HasColumnName("conc_cacl");

                entity.Property(e => e.ConcCarbonate).HasColumnName("conc_carbonate");

                entity.Property(e => e.ConcCl).HasColumnName("conc_cl");

                entity.Property(e => e.ConcClWholeMud).HasColumnName("conc_cl_whole_mud");

                entity.Property(e => e.ConcExcessLime).HasColumnName("conc_excess_lime");

                entity.Property(e => e.ConcH2s).HasColumnName("conc_h2s");

                entity.Property(e => e.ConcHighGravitySolids).HasColumnName("conc_high_gravity_solids");

                entity.Property(e => e.ConcLostCirculationMaterial).HasColumnName("conc_lost_circulation_material");

                entity.Property(e => e.ConcLowGravitySolids).HasColumnName("conc_low_gravity_solids");

                entity.Property(e => e.ConcLowGravitySolidsCorr).HasColumnName("conc_low_gravity_solids_corr");

                entity.Property(e => e.ConcMagnesium).HasColumnName("conc_magnesium");

                entity.Property(e => e.ConcNacl).HasColumnName("conc_nacl");

                entity.Property(e => e.ConcPolymer).HasColumnName("conc_polymer");

                entity.Property(e => e.ConcPotassium).HasColumnName("conc_potassium");

                entity.Property(e => e.ConcSand).HasColumnName("conc_sand");

                entity.Property(e => e.ConcSulfides).HasColumnName("conc_sulfides");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.CumMudAge).HasColumnName("cum_mud_age");

                entity.Property(e => e.CustomBaseFluid)
                    .HasColumnName("custom_base_fluid")
                    .HasMaxLength(80);

                entity.Property(e => e.CustomLabel1)
                    .HasColumnName("custom_label_1")
                    .HasMaxLength(30);

                entity.Property(e => e.CustomLabel2)
                    .HasColumnName("custom_label_2")
                    .HasMaxLength(30);

                entity.Property(e => e.CustomValue1).HasColumnName("custom_value_1");

                entity.Property(e => e.CustomValue2).HasColumnName("custom_value_2");

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Density).HasColumnName("density");

                entity.Property(e => e.Ecd).HasColumnName("ecd");

                entity.Property(e => e.Edta).HasColumnName("edta");

                entity.Property(e => e.ElectrostaticStability).HasColumnName("electrostatic_stability");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FannDataSource).HasColumnName("fann_data_source");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(50);

                entity.Property(e => e.FilterCake).HasColumnName("filter_cake");

                entity.Property(e => e.FiltrateMethylEndPoint).HasColumnName("filtrate_methyl_end_point");

                entity.Property(e => e.FluidExpansion).HasColumnName("fluid_expansion");

                entity.Property(e => e.FluidName)
                    .HasColumnName("fluid_name")
                    .HasMaxLength(80);

                entity.Property(e => e.Gels0Sec).HasColumnName("gels_0_sec");

                entity.Property(e => e.Gels10Min).HasColumnName("gels_10_min");

                entity.Property(e => e.Gels10Sec).HasColumnName("gels_10_sec");

                entity.Property(e => e.Gels30Min).HasColumnName("gels_30_min");

                entity.Property(e => e.H2so4).HasColumnName("h2so4");

                entity.Property(e => e.HardnessTotal).HasColumnName("hardness_total");

                entity.Property(e => e.HthpFilterCake).HasColumnName("hthp_filter_cake");

                entity.Property(e => e.HthpTemp).HasColumnName("hthp_temp");

                entity.Property(e => e.HthpWaterLoss).HasColumnName("hthp_water_loss");

                entity.Property(e => e.HthpWlPress).HasColumnName("hthp_wl_press");

                entity.Property(e => e.InsolubleNacl).HasColumnName("insoluble_nacl");

                entity.Property(e => e.IsArtesianAquifer)
                    .HasColumnName("is_artesian_aquifer")
                    .HasMaxLength(1);

                entity.Property(e => e.IsCement)
                    .HasColumnName("is_cement")
                    .HasMaxLength(1);

                entity.Property(e => e.IsDesign)
                    .HasColumnName("is_design")
                    .HasMaxLength(1);

                entity.Property(e => e.IsFoamed)
                    .HasColumnName("is_foamed")
                    .HasMaxLength(1);

                entity.Property(e => e.IsMudChanged)
                    .HasColumnName("is_mud_changed")
                    .HasMaxLength(1);

                entity.Property(e => e.IsRecalcRequired)
                    .HasColumnName("is_recalc_required")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSaltZone)
                    .HasColumnName("is_salt_zone")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSpacerFluid).HasColumnName("is_spacer_fluid");

                entity.Property(e => e.IsUnderbalanced)
                    .HasColumnName("is_underbalanced")
                    .HasMaxLength(1);

                entity.Property(e => e.KPrimeParameter).HasColumnName("k_prime_parameter");

                entity.Property(e => e.Lsrv1).HasColumnName("lsrv1");

                entity.Property(e => e.Lsrv2).HasColumnName("lsrv2");

                entity.Property(e => e.Lsrv3).HasColumnName("lsrv3");

                entity.Property(e => e.Mbt).HasColumnName("mbt");

                entity.Property(e => e.MdMudSample).HasColumnName("md_mud_sample");

                entity.Property(e => e.MdOilCuttings).HasColumnName("md_oil_cuttings");

                entity.Property(e => e.Method).HasColumnName("method");

                entity.Property(e => e.MixwaterDensity).HasColumnName("mixwater_density");

                entity.Property(e => e.MudEngineer)
                    .HasColumnName("mud_engineer")
                    .HasMaxLength(60);

                entity.Property(e => e.MudSupplier)
                    .HasColumnName("mud_supplier")
                    .HasMaxLength(60);

                entity.Property(e => e.MudbaseDensity).HasColumnName("mudbase_density");

                entity.Property(e => e.MudbaseType).HasColumnName("mudbase_type");

                entity.Property(e => e.NPrimeParameter).HasColumnName("n_prime_parameter");

                entity.Property(e => e.OwrOil).HasColumnName("owr_oil");

                entity.Property(e => e.OwrWater).HasColumnName("owr_water");

                entity.Property(e => e.Pct).HasColumnName("pct");

                entity.Property(e => e.PercentHighGravitySolids).HasColumnName("percent_high_gravity_solids");

                entity.Property(e => e.PercentLowGravitySolids).HasColumnName("percent_low_gravity_solids");

                entity.Property(e => e.PercentLubricant).HasColumnName("percent_lubricant");

                entity.Property(e => e.PercentOil).HasColumnName("percent_oil");

                entity.Property(e => e.PercentOilOnCuttings).HasColumnName("percent_oil_on_cuttings");

                entity.Property(e => e.PercentSolidsCorrCl).HasColumnName("percent_solids_corr_cl");

                entity.Property(e => e.PercentWater).HasColumnName("percent_water");

                entity.Property(e => e.PfEndPoint).HasColumnName("pf_end_point");

                entity.Property(e => e.Ph).HasColumnName("ph");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(10);

                entity.Property(e => e.PlasticViscosity).HasColumnName("plastic_viscosity");

                entity.Property(e => e.Pm).HasColumnName("pm");

                entity.Property(e => e.Pom).HasColumnName("pom");

                entity.Property(e => e.PorePressure).HasColumnName("pore_pressure");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.ResistivityMud).HasColumnName("resistivity_mud");

                entity.Property(e => e.ResistivityMudCake).HasColumnName("resistivity_mud_cake");

                entity.Property(e => e.ResistivityMudCakeTemp).HasColumnName("resistivity_mud_cake_temp");

                entity.Property(e => e.ResistivityMudFiltrate).HasColumnName("resistivity_mud_filtrate");

                entity.Property(e => e.ResistivityMudFiltrateTemp).HasColumnName("resistivity_mud_filtrate_temp");

                entity.Property(e => e.ResistivityMudTemp).HasColumnName("resistivity_mud_temp");

                entity.Property(e => e.RheologyModel).HasColumnName("rheology_model");

                entity.Property(e => e.SampleSource)
                    .HasColumnName("sample_source")
                    .HasMaxLength(30);

                entity.Property(e => e.SolidsSgAvg).HasColumnName("solids_sg_avg");

                entity.Property(e => e.SolubleNacl).HasColumnName("soluble_nacl");

                entity.Property(e => e.Tct).HasColumnName("tct");

                entity.Property(e => e.TempDensity).HasColumnName("temp_density");

                entity.Property(e => e.TempFlowline).HasColumnName("temp_flowline");

                entity.Property(e => e.TempRheology).HasColumnName("temp_rheology");

                entity.Property(e => e.TempVgMeter).HasColumnName("temp_vg_meter");

                entity.Property(e => e.TestEquipEfficiency).HasColumnName("test_equip_efficiency");

                entity.Property(e => e.TimeOilCutSample)
                    .HasColumnName("time_oil_cut_sample")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalDissolvedSolids).HasColumnName("total_dissolved_solids");

                entity.Property(e => e.TotalDrillingSolids).HasColumnName("total_drilling_solids");

                entity.Property(e => e.Turbidity).HasColumnName("turbidity");

                entity.Property(e => e.TvdMudSample).HasColumnName("tvd_mud_sample");

                entity.Property(e => e.TvdOilCuttings).HasColumnName("tvd_oil_cuttings");

                entity.Property(e => e.TypeMudSystem)
                    .HasColumnName("type_mud_system")
                    .HasMaxLength(60);

                entity.Property(e => e.TypePolymer)
                    .HasColumnName("type_polymer")
                    .HasMaxLength(30);

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.ViscosityFunnel).HasColumnName("viscosity_funnel");

                entity.Property(e => e.VolBaseMudOil).HasColumnName("vol_base_mud_oil");

                entity.Property(e => e.VolCuttingsOil).HasColumnName("vol_cuttings_oil");

                entity.Property(e => e.VolMudUsed).HasColumnName("vol_mud_used");

                entity.Property(e => e.VolWaterUsed).HasColumnName("vol_water_used");

                entity.Property(e => e.WaterRequirement).HasColumnName("water_requirement");

                entity.Property(e => e.Wps).HasColumnName("wps");

                entity.Property(e => e.Yield).HasColumnName("yield");

                entity.Property(e => e.YieldPoint).HasColumnName("yield_point");

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.CdFluidT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId })
                    .HasConstraintName("R_335");
            });

            modelBuilder.Entity<CdHoleSectGroupT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.HoleSectGroupId })
                    .HasName("XPKCD_HOLE_SECT_GROUP");

                entity.ToTable("CD_HOLE_SECT_GROUP_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoleSectGroupId)
                    .HasColumnName("hole_sect_group_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActivityCsgPhase)
                    .HasColumnName("activity_csg_phase")
                    .HasMaxLength(20);

                entity.Property(e => e.ActivityDrlPhase)
                    .HasColumnName("activity_drl_phase")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateSectEnd)
                    .HasColumnName("date_sect_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateSectStart)
                    .HasColumnName("date_sect_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(60);

                entity.Property(e => e.HoleName)
                    .HasColumnName("hole_name")
                    .HasMaxLength(150);

                entity.Property(e => e.IsLiner)
                    .HasColumnName("is_liner")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPilotHole)
                    .HasColumnName("is_pilot_hole")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.LastCasingBurstPressure).HasColumnName("last_casing_burst_pressure");

                entity.Property(e => e.LastCasingCoupling)
                    .HasColumnName("last_casing_coupling")
                    .HasMaxLength(50);

                entity.Property(e => e.LastCasingId).HasColumnName("last_casing_id");

                entity.Property(e => e.LastCasingOd).HasColumnName("last_casing_od");

                entity.Property(e => e.LastCasingWeight).HasColumnName("last_casing_weight");

                entity.Property(e => e.MdCasingBottom).HasColumnName("md_casing_bottom");

                entity.Property(e => e.MdCasingTop).HasColumnName("md_casing_top");

                entity.Property(e => e.MdHoleSectBase).HasColumnName("md_hole_sect_base");

                entity.Property(e => e.MdHoleSectTop).HasColumnName("md_hole_sect_top");

                entity.Property(e => e.NextCasingOd).HasColumnName("next_casing_od");

                entity.Property(e => e.NextCasingSetMd).HasColumnName("next_casing_set_md");

                entity.Property(e => e.NextCasingSetTvd).HasColumnName("next_casing_set_tvd");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(10);

                entity.Property(e => e.PlanMd).HasColumnName("plan_md");

                entity.Property(e => e.PlanTvd).HasColumnName("plan_tvd");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(4000);

                entity.Property(e => e.TvdCasingBottom).HasColumnName("tvd_casing_bottom");

                entity.Property(e => e.TvdHoleSectBase).HasColumnName("tvd_hole_sect_base");

                entity.Property(e => e.TvdHoleSectTop).HasColumnName("tvd_hole_sect_top");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.CdHoleSectGroupT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId })
                    .HasConstraintName("R_1674");
            });

            modelBuilder.Entity<CdHoleSectT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.HoleSectGroupId, e.HoleSectId })
                    .HasName("XPKCD_HOLE_SECT");

                entity.ToTable("CD_HOLE_SECT_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoleSectGroupId)
                    .HasColumnName("hole_sect_group_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoleSectId)
                    .HasColumnName("hole_sect_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyId)
                    .HasColumnName("assembly_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CatalogKeyDesc)
                    .HasColumnName("catalog_key_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.Cof).HasColumnName("cof");

                entity.Property(e => e.CompTypeCode)
                    .HasColumnName("comp_type_code")
                    .HasMaxLength(6);

                entity.Property(e => e.EffectiveDiameter).HasColumnName("effective_diameter");

                entity.Property(e => e.HoleSize).HasColumnName("hole_size");

                entity.Property(e => e.IdCasing).HasColumnName("id_casing");

                entity.Property(e => e.IdDrift).HasColumnName("id_drift");

                entity.Property(e => e.IsTapered)
                    .HasColumnName("is_tapered")
                    .HasMaxLength(1);

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.LinearCapacity).HasColumnName("linear_capacity");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(60);

                entity.Property(e => e.MdShoe).HasColumnName("md_shoe");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(30);

                entity.Property(e => e.OdCasing).HasColumnName("od_casing");

                entity.Property(e => e.OpenHoleSize).HasColumnName("open_hole_size");

                entity.Property(e => e.SectTypeCode)
                    .HasColumnName("sect_type_code")
                    .HasMaxLength(6);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.VolumeExcess).HasColumnName("volume_excess");

                entity.Property(e => e.WearLimit).HasColumnName("wear_limit");

                entity.HasOne(d => d.CdHoleSectGroupT)
                    .WithMany(p => p.CdHoleSectT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId, d.HoleSectGroupId })
                    .HasConstraintName("R_1677");
            });

            modelBuilder.Entity<CdPerforateT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.PerfId })
                    .HasName("XPKCD_PERFORATE");

                entity.ToTable("CD_PERFORATE_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PerfId)
                    .HasColumnName("perf_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyId)
                    .HasColumnName("assembly_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyName)
                    .HasColumnName("assembly_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BalanceCondition)
                    .HasColumnName("balance_condition")
                    .HasMaxLength(255);

                entity.Property(e => e.CentralizationMethod)
                    .HasColumnName("centralization_method")
                    .HasMaxLength(32);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(255);

                entity.Property(e => e.Contractor)
                    .HasColumnName("contractor")
                    .HasMaxLength(60);

                entity.Property(e => e.ContractorArrival)
                    .HasColumnName("contractor_arrival")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractorRigup)
                    .HasColumnName("contractor_rigup")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractorSupervisor)
                    .HasColumnName("contractor_supervisor")
                    .HasMaxLength(60);

                entity.Property(e => e.DateReport)
                    .HasColumnName("date_report")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTimeFinalPressure)
                    .HasColumnName("date_time_final_pressure")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTimeRefLog)
                    .HasColumnName("date_time_ref_log")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FinalSurfacePressure).HasColumnName("final_surface_pressure");

                entity.Property(e => e.FluidDensity).HasColumnName("fluid_density");

                entity.Property(e => e.FluidHead).HasColumnName("fluid_head");

                entity.Property(e => e.FluidLossAfterPerf).HasColumnName("fluid_loss_after_perf");

                entity.Property(e => e.FluidLossAfterPills).HasColumnName("fluid_loss_after_pills");

                entity.Property(e => e.FluidType)
                    .HasColumnName("fluid_type")
                    .HasMaxLength(25);

                entity.Property(e => e.FormationDepth).HasColumnName("formation_depth");

                entity.Property(e => e.HowGunsConveyed)
                    .HasColumnName("how_guns_conveyed")
                    .HasMaxLength(32);

                entity.Property(e => e.HydrostaticPressure).HasColumnName("hydrostatic_pressure");

                entity.Property(e => e.IntervalType)
                    .HasColumnName("interval_type")
                    .HasMaxLength(25);

                entity.Property(e => e.IsUnderbalanced)
                    .HasColumnName("is_underbalanced")
                    .HasMaxLength(1);

                entity.Property(e => e.JobEnd)
                    .HasColumnName("job_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobStart)
                    .HasColumnName("job_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.MdBottomShot).HasColumnName("md_bottom_shot");

                entity.Property(e => e.MdTopShot).HasColumnName("md_top_shot");

                entity.Property(e => e.MethodPlacing)
                    .HasColumnName("method_placing")
                    .HasMaxLength(32);

                entity.Property(e => e.NumIntervals).HasColumnName("num_intervals");

                entity.Property(e => e.Penetration).HasColumnName("penetration");

                entity.Property(e => e.PerfDiameter).HasColumnName("perf_diameter");

                entity.Property(e => e.PerfLengthGross).HasColumnName("perf_length_gross");

                entity.Property(e => e.PerfLengthNet).HasColumnName("perf_length_net");

                entity.Property(e => e.PerfMethod)
                    .HasColumnName("perf_method")
                    .HasMaxLength(32);

                entity.Property(e => e.PerfNote)
                    .HasColumnName("perf_note")
                    .HasColumnType("ntext");

                entity.Property(e => e.PillsSpottedType)
                    .HasColumnName("pills_spotted_type")
                    .HasMaxLength(32);

                entity.Property(e => e.PillsSpottedVolume).HasColumnName("pills_spotted_volume");

                entity.Property(e => e.PressureDifference).HasColumnName("pressure_difference");

                entity.Property(e => e.RefLogDescription)
                    .HasColumnName("ref_log_description")
                    .HasMaxLength(100);

                entity.Property(e => e.RefLogId)
                    .HasColumnName("ref_log_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReportJournalId)
                    .HasColumnName("report_journal_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReportNo)
                    .HasColumnName("report_no")
                    .HasMaxLength(4);

                entity.Property(e => e.ReservoirPressureEst).HasColumnName("reservoir_pressure_est");

                entity.Property(e => e.ShotDensityAverage).HasColumnName("shot_density_average");

                entity.Property(e => e.SurfacePressure).HasColumnName("surface_pressure");

                entity.Property(e => e.TotalShots).HasColumnName("total_shots");

                entity.Property(e => e.TvdFluidTop).HasColumnName("tvd_fluid_top");

                entity.Property(e => e.TvdReservoir).HasColumnName("tvd_reservoir");

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.CdPerforateT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId })
                    .HasConstraintName("R_1253");
            });

            modelBuilder.Entity<CdPolicy>(entity =>
            {
                entity.HasKey(e => e.PolicyId)
                    .HasName("XPKCD_POLICY");

                entity.ToTable("CD_POLICY");

                entity.Property(e => e.PolicyId)
                    .HasColumnName("policy_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AttachmentJournalId)
                    .HasColumnName("attachment_journal_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BaCode)
                    .HasColumnName("ba_code")
                    .HasMaxLength(6);

                entity.Property(e => e.ChecksumValue).HasColumnName("checksum_value");

                entity.Property(e => e.ContingencyCodes)
                    .HasColumnName("contingency_codes")
                    .HasMaxLength(100);

                entity.Property(e => e.ContingencyInfo)
                    .HasColumnName("contingency_info")
                    .HasMaxLength(200);

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerAddress)
                    .HasColumnName("customer_address")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerDivision)
                    .HasColumnName("customer_division")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerGroup)
                    .HasColumnName("customer_group")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerRepresentative)
                    .HasColumnName("customer_representative")
                    .HasMaxLength(60);

                entity.Property(e => e.CustomerTelephone)
                    .HasColumnName("customer_telephone")
                    .HasMaxLength(50);

                entity.Property(e => e.ErrorLevel).HasColumnName("error_level");

                entity.Property(e => e.ErrorModel).HasColumnName("error_model");

                entity.Property(e => e.ErrorOutputLevel).HasColumnName("error_output_level");

                entity.Property(e => e.ErrorSurface).HasColumnName("error_surface");

                entity.Property(e => e.IsContingencyCalc)
                    .HasColumnName("is_contingency_calc")
                    .HasMaxLength(1);

                entity.Property(e => e.IsDualCurrency)
                    .HasColumnName("is_dual_currency")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.NotifyCone).HasColumnName("notify_cone");

                entity.Property(e => e.NotifyMinimumSeparation).HasColumnName("notify_minimum_separation");

                entity.Property(e => e.NotifyOffsetScope).HasColumnName("notify_offset_scope");

                entity.Property(e => e.NotifyOffsetSidetrack)
                    .HasColumnName("notify_offset_sidetrack")
                    .HasMaxLength(1);

                entity.Property(e => e.NotifyProjectionLength).HasColumnName("notify_projection_length");

                entity.Property(e => e.NotifyProjectionType).HasColumnName("notify_projection_type");

                entity.Property(e => e.Password1)
                    .HasColumnName("password_1")
                    .HasMaxLength(8);

                entity.Property(e => e.Password2)
                    .HasColumnName("password_2")
                    .HasMaxLength(8);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.ReportingStandard).HasColumnName("reporting_standard");

                entity.Property(e => e.ReportingTime)
                    .HasColumnName("reporting_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScanMethod).HasColumnName("scan_method");

                entity.Property(e => e.SurveyCalc).HasColumnName("survey_calc");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.UseCasing).HasColumnName("use_casing");

                entity.Property(e => e.UseSurfaceAnticollisionRule)
                    .HasColumnName("use_surface_anticollision_rule")
                    .HasMaxLength(1);

                entity.Property(e => e.VsOrigin).HasColumnName("vs_origin");

                entity.Property(e => e.WalkType).HasColumnName("walk_type");

                entity.Property(e => e.WarningMethod).HasColumnName("warning_method");
            });

            modelBuilder.Entity<CdProjectSource>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("XPKCD_PROJECT");

                entity.ToTable("CD_PROJECT_SOURCE");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActiveUiUnitsysId).HasColumnName("active_ui_unitsys_id");

                entity.Property(e => e.BasinName)
                    .HasColumnName("basin_name")
                    .HasMaxLength(32);

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DefMagModel)
                    .HasColumnName("def_mag_model")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.DescriptionSupplement)
                    .HasColumnName("description_supplement")
                    .HasMaxLength(50);

                entity.Property(e => e.FieldNo).HasColumnName("field_no");

                entity.Property(e => e.GeoDatumId)
                    .HasColumnName("geo_datum_id")
                    .HasMaxLength(40);

                entity.Property(e => e.GeoSystemId)
                    .HasColumnName("geo_system_id")
                    .HasMaxLength(32);

                entity.Property(e => e.GeoZoneId)
                    .HasColumnName("geo_zone_id")
                    .HasMaxLength(32);

                entity.Property(e => e.IsFacility)
                    .HasColumnName("is_facility")
                    .HasMaxLength(1);

                entity.Property(e => e.IsProjectReadonly)
                    .HasColumnName("is_project_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.LocalCoordOrigin).HasColumnName("local_coord_origin");

                entity.Property(e => e.MagCalcModel)
                    .HasColumnName("mag_calc_model")
                    .HasMaxLength(20);

                entity.Property(e => e.PolicyId)
                    .HasColumnName("policy_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("project_code")
                    .HasMaxLength(16);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("project_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectPassword)
                    .HasColumnName("project_password")
                    .HasMaxLength(8);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.RiskDepth).HasColumnName("risk_depth");

                entity.Property(e => e.RiskFactor).HasColumnName("risk_factor");

                entity.Property(e => e.StateNo)
                    .HasColumnName("state_no")
                    .HasMaxLength(12);

                entity.Property(e => e.SystemDatumDesc)
                    .HasColumnName("system_datum_desc")
                    .HasMaxLength(32);

                entity.Property(e => e.SystemDatumOffset).HasColumnName("system_datum_offset");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TightGroupId)
                    .HasColumnName("tight_group_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TimeZone).HasColumnName("time_zone");

                entity.Property(e => e.TimeZoneDescription)
                    .HasColumnName("time_zone_description")
                    .HasMaxLength(80);

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.UseLocalScaleFactor).HasColumnName("use_local_scale_factor");

                entity.Property(e => e.UseRisk)
                    .HasColumnName("use_risk")
                    .HasMaxLength(1);

                entity.Property(e => e.UseVariableConvergence)
                    .HasColumnName("use_variable_convergence")
                    .HasMaxLength(1);

                entity.Property(e => e.VerticalCoordOrigin).HasColumnName("vertical_coord_origin");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.CdProjectSource)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("R_2314");
            });

            modelBuilder.Entity<CdRig>(entity =>
            {
                entity.HasKey(e => e.RigId)
                    .HasName("XPKCD_RIG");

                entity.ToTable("CD_RIG");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AirGap).HasColumnName("air_gap");

                entity.Property(e => e.Approvals)
                    .HasColumnName("approvals")
                    .HasMaxLength(100);

                entity.Property(e => e.BlockRating).HasColumnName("block_rating");

                entity.Property(e => e.BlockWeight).HasColumnName("block_weight");

                entity.Property(e => e.BopPressRating).HasColumnName("bop_press_rating");

                entity.Property(e => e.BopSystemSize)
                    .HasColumnName("bop_system_size")
                    .HasMaxLength(50);

                entity.Property(e => e.BrakeDescription)
                    .HasColumnName("brake_description")
                    .HasMaxLength(32);

                entity.Property(e => e.BulkCementCapacity).HasColumnName("bulk_cement_capacity");

                entity.Property(e => e.BulkMudCap).HasColumnName("bulk_mud_cap");

                entity.Property(e => e.CementUnit)
                    .HasColumnName("cement_unit")
                    .HasMaxLength(32);

                entity.Property(e => e.ContractorId)
                    .HasColumnName("contractor_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CraneType)
                    .HasColumnName("crane_type")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DefaultElevName)
                    .HasColumnName("default_elev_name")
                    .HasMaxLength(60);

                entity.Property(e => e.DefaultElevation).HasColumnName("default_elevation");

                entity.Property(e => e.DerrickHeight).HasColumnName("derrick_height");

                entity.Property(e => e.DerrickRating).HasColumnName("derrick_rating");

                entity.Property(e => e.DerrickType)
                    .HasColumnName("derrick_type")
                    .HasMaxLength(50);

                entity.Property(e => e.DerrickWindCapacity).HasColumnName("derrick_wind_capacity");

                entity.Property(e => e.DrawWorksMotor)
                    .HasColumnName("draw_works_motor")
                    .HasMaxLength(32);

                entity.Property(e => e.DrawWorksPower).HasColumnName("draw_works_power");

                entity.Property(e => e.DrawWorksType)
                    .HasColumnName("draw_works_type")
                    .HasMaxLength(50);

                entity.Property(e => e.DrillDepthRating).HasColumnName("drill_depth_rating");

                entity.Property(e => e.DrillLineRating).HasColumnName("drill_line_rating");

                entity.Property(e => e.DrillLineSize).HasColumnName("drill_line_size");

                entity.Property(e => e.DrillWaterCap).HasColumnName("drill_water_cap");

                entity.Property(e => e.DriveType)
                    .HasColumnName("drive_type")
                    .HasMaxLength(32);

                entity.Property(e => e.DriveTypeDescription)
                    .HasColumnName("drive_type_description")
                    .HasMaxLength(80);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlareDescription)
                    .HasColumnName("flare_description")
                    .HasMaxLength(80);

                entity.Property(e => e.FuelCap).HasColumnName("fuel_cap");

                entity.Property(e => e.GantryDescription)
                    .HasColumnName("gantry_description")
                    .HasMaxLength(80);

                entity.Property(e => e.Generator)
                    .HasColumnName("generator")
                    .HasMaxLength(80);

                entity.Property(e => e.HeaveMax).HasColumnName("heave_max");

                entity.Property(e => e.HookRating).HasColumnName("hook_rating");

                entity.Property(e => e.HookType)
                    .HasColumnName("hook_type")
                    .HasMaxLength(32);

                entity.Property(e => e.IsAzimuthing)
                    .HasColumnName("is_azimuthing")
                    .HasMaxLength(1);

                entity.Property(e => e.IsOffshore)
                    .HasColumnName("is_offshore")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.LiquidMudCap).HasColumnName("liquid_mud_cap");

                entity.Property(e => e.MainEngine)
                    .HasColumnName("main_engine")
                    .HasMaxLength(80);

                entity.Property(e => e.MaxHookLoad).HasColumnName("max_hook_load");

                entity.Property(e => e.MooringSystem)
                    .HasColumnName("mooring_system")
                    .HasMaxLength(32);

                entity.Property(e => e.MooringSystemCode)
                    .HasColumnName("mooring_system_code")
                    .HasMaxLength(2);

                entity.Property(e => e.MotionCompensationMax).HasColumnName("motion_compensation_max");

                entity.Property(e => e.MotionCompensationMin).HasColumnName("motion_compensation_min");

                entity.Property(e => e.MotionCompensationStroke).HasColumnName("motion_compensation_stroke");

                entity.Property(e => e.NumBlockLines).HasColumnName("num_block_lines");

                entity.Property(e => e.NumCranes).HasColumnName("num_cranes");

                entity.Property(e => e.NumDerricks).HasColumnName("num_derricks");

                entity.Property(e => e.NumThrusters).HasColumnName("num_thrusters");

                entity.Property(e => e.PipeHandlingSystem)
                    .HasColumnName("pipe_handling_system")
                    .HasMaxLength(32);

                entity.Property(e => e.PipeStandLength).HasColumnName("pipe_stand_length");

                entity.Property(e => e.PotableWaterCap).HasColumnName("potable_water_cap");

                entity.Property(e => e.Registration)
                    .HasColumnName("registration")
                    .HasMaxLength(60);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.RigClass)
                    .HasColumnName("rig_class")
                    .HasMaxLength(100);

                entity.Property(e => e.RigManufacturer)
                    .HasColumnName("rig_manufacturer")
                    .HasMaxLength(32);

                entity.Property(e => e.RigMooringSystem)
                    .HasColumnName("rig_mooring_system")
                    .HasMaxLength(32);

                entity.Property(e => e.RigName)
                    .HasColumnName("rig_name")
                    .HasMaxLength(60);

                entity.Property(e => e.RigNo)
                    .HasColumnName("rig_no")
                    .HasMaxLength(5);

                entity.Property(e => e.RigOwner)
                    .HasColumnName("rig_owner")
                    .HasMaxLength(60);

                entity.Property(e => e.RigType)
                    .HasColumnName("rig_type")
                    .HasMaxLength(50);

                entity.Property(e => e.RigTypeCode)
                    .HasColumnName("rig_type_code")
                    .HasMaxLength(6);

                entity.Property(e => e.RigYear)
                    .HasColumnName("rig_year")
                    .HasMaxLength(4);

                entity.Property(e => e.RotarySystemMake)
                    .HasColumnName("rotary_system_make")
                    .HasMaxLength(50);

                entity.Property(e => e.RotarySystemModel)
                    .HasColumnName("rotary_system_model")
                    .HasMaxLength(30);

                entity.Property(e => e.RotarySystemOpeningSize).HasColumnName("rotary_system_opening_size");

                entity.Property(e => e.RotarySystemRating).HasColumnName("rotary_system_rating");

                entity.Property(e => e.RotarySystemTorque).HasColumnName("rotary_system_torque");

                entity.Property(e => e.RotarySystemType)
                    .HasColumnName("rotary_system_type")
                    .HasMaxLength(16);

                entity.Property(e => e.ScrSystem)
                    .HasColumnName("scr_system")
                    .HasMaxLength(32);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SwivelRating).HasColumnName("swivel_rating");

                entity.Property(e => e.SwivelType)
                    .HasColumnName("swivel_type")
                    .HasMaxLength(32);

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.VdlMax).HasColumnName("vdl_max");

                entity.Property(e => e.VdlStorm).HasColumnName("vdl_storm");

                entity.Property(e => e.WaterDepthRating).HasColumnName("water_depth_rating");

                entity.Property(e => e.WellsDrilled).HasColumnName("wells_drilled");
            });

            modelBuilder.Entity<CdRigAnchor>(entity =>
            {
                entity.HasKey(e => new { e.AnchorId, e.RigId })
                    .HasName("XPKCD_RIG_ANCHOR");

                entity.ToTable("CD_RIG_ANCHOR");

                entity.Property(e => e.AnchorId)
                    .HasColumnName("anchor_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnchorLocation)
                    .HasColumnName("anchor_location")
                    .HasMaxLength(50);

                entity.Property(e => e.AnchorNo)
                    .HasColumnName("anchor_no")
                    .HasMaxLength(10);

                entity.Property(e => e.AnchorRating).HasColumnName("anchor_rating");

                entity.Property(e => e.AnchorType)
                    .HasColumnName("anchor_type")
                    .HasMaxLength(50);

                entity.Property(e => e.ChainRating).HasColumnName("chain_rating");

                entity.Property(e => e.CouplingRating).HasColumnName("coupling_rating");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.IsInUse)
                    .HasColumnName("is_in_use")
                    .HasMaxLength(1);

                entity.Property(e => e.LineRating).HasColumnName("line_rating");

                entity.Property(e => e.Make)
                    .HasColumnName("make")
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(30);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Rig)
                    .WithMany(p => p.CdRigAnchor)
                    .HasForeignKey(d => d.RigId)
                    .HasConstraintName("R_237");
            });

            modelBuilder.Entity<CdRigCentrifuge>(entity =>
            {
                entity.HasKey(e => new { e.CentrifugeId, e.RigId })
                    .HasName("XPKCD_RIG_CENTRIFUGE");

                entity.ToTable("CD_RIG_CENTRIFUGE");

                entity.Property(e => e.CentrifugeId)
                    .HasColumnName("centrifuge_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CentrifugeNo)
                    .HasColumnName("centrifuge_no")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateInstalled)
                    .HasColumnName("date_installed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRemoved)
                    .HasColumnName("date_removed")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlowCapacity).HasColumnName("flow_capacity");

                entity.Property(e => e.Make)
                    .HasColumnName("make")
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(30);

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(60);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.SolidsCapacity).HasColumnName("solids_capacity");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Rig)
                    .WithMany(p => p.CdRigCentrifuge)
                    .HasForeignKey(d => d.RigId)
                    .HasConstraintName("R_51");
            });

            modelBuilder.Entity<CdRigHydroclone>(entity =>
            {
                entity.HasKey(e => new { e.RigId, e.HydrocloneId })
                    .HasName("XPKCD_RIG_HYDROCLONE");

                entity.ToTable("CD_RIG_HYDROCLONE");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HydrocloneId)
                    .HasColumnName("hydroclone_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConeSize).HasColumnName("cone_size");

                entity.Property(e => e.ConeType)
                    .HasColumnName("cone_type")
                    .HasMaxLength(50);

                entity.Property(e => e.ConesNo).HasColumnName("cones_no");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateInstalled)
                    .HasColumnName("date_installed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRemoved)
                    .HasColumnName("date_removed")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlowCapacity).HasColumnName("flow_capacity");

                entity.Property(e => e.HydrocloneNo)
                    .HasColumnName("hydroclone_no")
                    .HasMaxLength(20);

                entity.Property(e => e.HydrocloneType)
                    .HasColumnName("hydroclone_type")
                    .HasMaxLength(50);

                entity.Property(e => e.IsMudCleaner)
                    .HasColumnName("is_mud_cleaner")
                    .HasMaxLength(1);

                entity.Property(e => e.Make)
                    .HasColumnName("make")
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(30);

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(60);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Rig)
                    .WithMany(p => p.CdRigHydroclone)
                    .HasForeignKey(d => d.RigId)
                    .HasConstraintName("R_53");
            });

            modelBuilder.Entity<CdRigPump>(entity =>
            {
                entity.HasKey(e => new { e.RigId, e.PumpId })
                    .HasName("XPKCD_RIG_PUMP");

                entity.ToTable("CD_RIG_PUMP");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PumpId)
                    .HasColumnName("pump_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DampenerPressure).HasColumnName("dampener_pressure");

                entity.Property(e => e.DateInstalled)
                    .HasColumnName("date_installed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRemoved)
                    .HasColumnName("date_removed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Efficiency).HasColumnName("efficiency");

                entity.Property(e => e.IdLiner).HasColumnName("id_liner");

                entity.Property(e => e.IsDoubleActing)
                    .HasColumnName("is_double_acting")
                    .HasMaxLength(1);

                entity.Property(e => e.Make)
                    .HasColumnName("make")
                    .HasMaxLength(50);

                entity.Property(e => e.MaxPower).HasColumnName("max_power");

                entity.Property(e => e.MaxPressure).HasColumnName("max_pressure");

                entity.Property(e => e.MaxSpm).HasColumnName("max_spm");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(30);

                entity.Property(e => e.MotorId)
                    .HasColumnName("motor_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCylinders).HasColumnName("num_cylinders");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(60);

                entity.Property(e => e.PumpNo)
                    .HasColumnName("pump_no")
                    .HasMaxLength(20);

                entity.Property(e => e.Purpose)
                    .HasColumnName("purpose")
                    .HasMaxLength(16);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.RodOd).HasColumnName("rod_od");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.StrokeDisplacement).HasColumnName("stroke_displacement");

                entity.Property(e => e.StrokeLength).HasColumnName("stroke_length");

                entity.Property(e => e.SuperchargerMake)
                    .HasColumnName("supercharger_make")
                    .HasMaxLength(60);

                entity.Property(e => e.SuperchargerModel)
                    .HasColumnName("supercharger_model")
                    .HasMaxLength(30);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Rig)
                    .WithMany(p => p.CdRigPump)
                    .HasForeignKey(d => d.RigId)
                    .HasConstraintName("R_198");
            });

            modelBuilder.Entity<CdRigShaker>(entity =>
            {
                entity.HasKey(e => new { e.RigId, e.ShakerId })
                    .HasName("XPKCD_RIG_SHAKER");

                entity.ToTable("CD_RIG_SHAKER");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShakerId)
                    .HasColumnName("shaker_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CascadeLevel).HasColumnName("cascade_level");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateInstalled)
                    .HasColumnName("date_installed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRemoved)
                    .HasColumnName("date_removed")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstallLocation)
                    .HasColumnName("install_location")
                    .HasMaxLength(30);

                entity.Property(e => e.IsMudCleaner)
                    .HasColumnName("is_mud_cleaner")
                    .HasMaxLength(1);

                entity.Property(e => e.Make)
                    .HasColumnName("make")
                    .HasMaxLength(50);

                entity.Property(e => e.MaxFlow).HasColumnName("max_flow");

                entity.Property(e => e.MinMeshSize).HasColumnName("min_mesh_size");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(30);

                entity.Property(e => e.NumberOfDecks).HasColumnName("number_of_decks");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(60);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.ShakerNo)
                    .HasColumnName("shaker_no")
                    .HasMaxLength(20);

                entity.Property(e => e.ShakerType)
                    .HasColumnName("shaker_type")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Rig)
                    .WithMany(p => p.CdRigShaker)
                    .HasForeignKey(d => d.RigId)
                    .HasConstraintName("R_200");
            });

            modelBuilder.Entity<CdSiteSource>(entity =>
            {
                entity.HasKey(e => e.SiteId)
                    .HasName("XPKCD_SITE");

                entity.ToTable("CD_SITE_SOURCE");

                entity.Property(e => e.SiteId)
                    .HasColumnName("site_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlockName)
                    .HasColumnName("block_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Convergence).HasColumnName("convergence");

                entity.Property(e => e.CoordType).HasColumnName("coord_type");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DefaultRigElevation).HasColumnName("default_rig_elevation");

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ForesightError).HasColumnName("foresight_error");

                entity.Property(e => e.GeoLatitude).HasColumnName("geo_latitude");

                entity.Property(e => e.GeoLongitude).HasColumnName("geo_longitude");

                entity.Property(e => e.GeoMapEasting).HasColumnName("geo_map_easting");

                entity.Property(e => e.GeoMapNorthing).HasColumnName("geo_map_northing");

                entity.Property(e => e.GeoOffsetEastLeaseLine).HasColumnName("geo_offset_east_lease_line");

                entity.Property(e => e.GeoOffsetNorthLeaseLine).HasColumnName("geo_offset_north_lease_line");

                entity.Property(e => e.IsFacility)
                    .HasColumnName("is_facility")
                    .HasMaxLength(1);

                entity.Property(e => e.IsFieldCenter)
                    .HasColumnName("is_field_center")
                    .HasMaxLength(1);

                entity.Property(e => e.IsProjectReadonly)
                    .HasColumnName("is_project_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.LateralError).HasColumnName("lateral_error");

                entity.Property(e => e.LocCountry)
                    .HasColumnName("loc_country")
                    .HasMaxLength(30);

                entity.Property(e => e.LocCounty)
                    .HasColumnName("loc_county")
                    .HasMaxLength(40);

                entity.Property(e => e.LocDivision)
                    .HasColumnName("loc_division")
                    .HasMaxLength(30);

                entity.Property(e => e.LocFedLeaseNo)
                    .HasColumnName("loc_fed_lease_no")
                    .HasMaxLength(40);

                entity.Property(e => e.LocLeaseCode)
                    .HasColumnName("loc_lease_code")
                    .HasMaxLength(40);

                entity.Property(e => e.LocRegion)
                    .HasColumnName("loc_region")
                    .HasMaxLength(32);

                entity.Property(e => e.LocState)
                    .HasColumnName("loc_state")
                    .HasMaxLength(40);

                entity.Property(e => e.LocationId)
                    .HasColumnName("location_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MagCrustalDec).HasColumnName("mag_crustal_dec");

                entity.Property(e => e.MagCrustalDip).HasColumnName("mag_crustal_dip");

                entity.Property(e => e.MagCrustalTotal).HasColumnName("mag_crustal_total");

                entity.Property(e => e.MagTimeDec).HasColumnName("mag_time_dec");

                entity.Property(e => e.MagTimeDip).HasColumnName("mag_time_dip");

                entity.Property(e => e.MagTimeTotal).HasColumnName("mag_time_total");

                entity.Property(e => e.NorthType).HasColumnName("north_type");

                entity.Property(e => e.PermafrostThickness).HasColumnName("permafrost_thickness");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.RoadDescription)
                    .HasColumnName("road_description")
                    .HasMaxLength(255);

                entity.Property(e => e.ScaleFactor).HasColumnName("scale_factor");

                entity.Property(e => e.SiteLocDesc)
                    .HasColumnName("site_loc_desc")
                    .HasMaxLength(8);

                entity.Property(e => e.SiteName)
                    .HasColumnName("site_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SiteType).HasColumnName("site_type");

                entity.Property(e => e.StateDistrictNo)
                    .HasColumnName("state_district_no")
                    .HasMaxLength(12);

                entity.Property(e => e.TightGroupId)
                    .HasColumnName("tight_group_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TimeZone).HasColumnName("time_zone");

                entity.Property(e => e.TimeZoneDescription)
                    .HasColumnName("time_zone_description")
                    .HasMaxLength(80);

                entity.Property(e => e.TopBoreholeRadius).HasColumnName("top_borehole_radius");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CdSiteSource)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("R_26");
            });

            modelBuilder.Entity<CdSurveyHeaderT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.SurveyHeaderId })
                    .HasName("XPKCD_SURVEY_HEADER");

                entity.ToTable("CD_SURVEY_HEADER_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SurveyHeaderId)
                    .HasColumnName("survey_header_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AverageDogleg).HasColumnName("average_dogleg");

                entity.Property(e => e.AzimuthCorrection).HasColumnName("azimuth_correction");

                entity.Property(e => e.AzimuthReference)
                    .HasColumnName("azimuth_reference")
                    .HasMaxLength(1);

                entity.Property(e => e.BendAngle).HasColumnName("bend_angle");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(60);

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefinitivePlan).HasColumnName("definitive_plan");

                entity.Property(e => e.DepthCorrection).HasColumnName("depth_correction");

                entity.Property(e => e.DepthReference)
                    .HasColumnName("depth_reference")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1024);

                entity.Property(e => e.DirectionalDifficultyIndex).HasColumnName("directional_difficulty_index");

                entity.Property(e => e.Engineer)
                    .HasColumnName("engineer")
                    .HasMaxLength(60);

                entity.Property(e => e.HeaderDate)
                    .HasColumnName("header_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InclinationCorrection).HasColumnName("inclination_correction");

                entity.Property(e => e.InterferenceCorrection).HasColumnName("interference_correction");

                entity.Property(e => e.IsInterferenceApplied)
                    .HasColumnName("is_interference_applied")
                    .HasMaxLength(1);

                entity.Property(e => e.IsMerged)
                    .HasColumnName("is_merged")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSagApplied)
                    .HasColumnName("is_sag_applied")
                    .HasMaxLength(1);

                entity.Property(e => e.IsStretchApplied)
                    .HasColumnName("is_stretch_applied")
                    .HasMaxLength(1);

                entity.Property(e => e.MagneticInterference).HasColumnName("magnetic_interference");

                entity.Property(e => e.MaximumDlsDepth).HasColumnName("maximum_dls_depth");

                entity.Property(e => e.MaximumDlsValue).HasColumnName("maximum_dls_value");

                entity.Property(e => e.MdMax).HasColumnName("md_max");

                entity.Property(e => e.MdMin).HasColumnName("md_min");

                entity.Property(e => e.MergeInterval).HasColumnName("merge_interval");

                entity.Property(e => e.MergeSurveyIds)
                    .HasColumnName("merge_survey_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.MergeToolIds)
                    .HasColumnName("merge_tool_ids")
                    .HasMaxLength(255);

                entity.Property(e => e.NumberMerged).HasColumnName("number_merged");

                entity.Property(e => e.OffsetWellId)
                    .HasColumnName("offset_well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OverrideReason)
                    .HasColumnName("override_reason")
                    .HasMaxLength(50);

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyId)
                    .HasColumnName("policy_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessingOption).HasColumnName("processing_option");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.SagData)
                    .HasColumnName("sag_data")
                    .HasMaxLength(255);

                entity.Property(e => e.ScanOffsetWell)
                    .HasColumnName("scan_offset_well")
                    .HasMaxLength(1);

                entity.Property(e => e.SensorFromBit).HasColumnName("sensor_from_bit");

                entity.Property(e => e.StretchFactor).HasColumnName("stretch_factor");

                entity.Property(e => e.StretchFormula)
                    .HasColumnName("stretch_formula")
                    .HasMaxLength(255);

                entity.Property(e => e.SurveyName)
                    .HasColumnName("survey_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SurveyToolId)
                    .HasColumnName("survey_tool_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SurveyType).HasColumnName("survey_type");

                entity.Property(e => e.TieOnDepth).HasColumnName("tie_on_depth");

                entity.Property(e => e.TieOnType).HasColumnName("tie_on_type");

                entity.Property(e => e.TieSurveyHeaderId)
                    .HasColumnName("tie_survey_header_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TieWellboreId)
                    .HasColumnName("tie_wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolFaceAngle).HasColumnName("tool_face_angle");

                entity.Property(e => e.Tortuosity).HasColumnName("tortuosity");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.VersionNo).HasColumnName("version_no");

                entity.Property(e => e.WellDesc)
                    .HasColumnName("well_desc")
                    .HasMaxLength(80);

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.CdSurveyHeaderT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId })
                    .HasConstraintName("R_340");
            });

            modelBuilder.Entity<CdSurveyStationT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.SurveyHeaderId, e.SurveyId })
                    .HasName("XPKCD_SURVEY_STATION");

                entity.ToTable("CD_SURVEY_STATION_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SurveyHeaderId)
                    .HasColumnName("survey_header_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SurveyId)
                    .HasColumnName("survey_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.BuildRate).HasColumnName("build_rate");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DoglegSeverity).HasColumnName("dogleg_severity");

                entity.Property(e => e.GravAxialRaw).HasColumnName("grav_axial_raw");

                entity.Property(e => e.GravTran1Raw).HasColumnName("grav_tran1_raw");

                entity.Property(e => e.GravTran2Raw).HasColumnName("grav_tran2_raw");

                entity.Property(e => e.Inclination).HasColumnName("inclination");

                entity.Property(e => e.MagAxialRaw).HasColumnName("mag_axial_raw");

                entity.Property(e => e.MagTran1Raw).HasColumnName("mag_tran1_raw");

                entity.Property(e => e.MagTran2Raw).HasColumnName("mag_tran2_raw");

                entity.Property(e => e.Md).HasColumnName("md");

                entity.Property(e => e.OffsetEast).HasColumnName("offset_east");

                entity.Property(e => e.OffsetNorth).HasColumnName("offset_north");

                entity.Property(e => e.PlanMethod).HasColumnName("plan_method");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProjectTargetId)
                    .HasColumnName("project_target_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.StationType).HasColumnName("station_type");

                entity.Property(e => e.SurveyDate)
                    .HasColumnName("survey_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ToolFaceAngle).HasColumnName("tool_face_angle");

                entity.Property(e => e.TurnRate).HasColumnName("turn_rate");

                entity.Property(e => e.Tvd).HasColumnName("tvd");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.VerticalSect).HasColumnName("vertical_sect");

                entity.HasOne(d => d.CdSurveyHeaderT)
                    .WithMany(p => p.CdSurveyStationT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId, d.SurveyHeaderId })
                    .HasConstraintName("R_19");
            });

            modelBuilder.Entity<CdVgMeterT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.VgMeterId, e.FluidId })
                    .HasName("XPKCD_VG_METER");

                entity.ToTable("CD_VG_METER_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VgMeterId)
                    .HasColumnName("vg_meter_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FluidId)
                    .HasColumnName("fluid_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Deflection).HasColumnName("deflection");

                entity.Property(e => e.Rpm).HasColumnName("rpm");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.Temperature).HasColumnName("temperature");

                entity.HasOne(d => d.CdFluidT)
                    .WithMany(p => p.CdVgMeterT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId, d.FluidId })
                    .HasConstraintName("R_66");
            });

            modelBuilder.Entity<CdWellSource>(entity =>
            {
                entity.HasKey(e => e.WellId)
                    .HasName("XPKCD_WELL");

                entity.ToTable("CD_WELL_SOURCE");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActiveUiUnitsysId).HasColumnName("active_ui_unitsys_id");

                entity.Property(e => e.ApiNo)
                    .HasColumnName("api_no")
                    .HasMaxLength(20);

                entity.Property(e => e.Battery)
                    .HasColumnName("battery")
                    .HasMaxLength(60);

                entity.Property(e => e.BatteryDirections)
                    .HasColumnName("battery_directions")
                    .HasMaxLength(255);

                entity.Property(e => e.CompletionWellId)
                    .HasColumnName("completion_well_id")
                    .HasMaxLength(60);

                entity.Property(e => e.ConductorInstallDate)
                    .HasColumnName("conductor_install_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Convergence).HasColumnName("convergence");

                entity.Property(e => e.CoordType).HasColumnName("coord_type");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DatumName)
                    .HasColumnName("datum_name")
                    .HasMaxLength(60);

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(32);

                entity.Property(e => e.FieldNumber)
                    .HasColumnName("field_number")
                    .HasMaxLength(32);

                entity.Property(e => e.GeoDescription)
                    .HasColumnName("geo_description")
                    .HasMaxLength(80);

                entity.Property(e => e.GeoLatitude).HasColumnName("geo_latitude");

                entity.Property(e => e.GeoLongitude).HasColumnName("geo_longitude");

                entity.Property(e => e.GeoOffsetEast).HasColumnName("geo_offset_east");

                entity.Property(e => e.GeoOffsetNorth).HasColumnName("geo_offset_north");

                entity.Property(e => e.GeoOffsetReference)
                    .HasColumnName("geo_offset_reference")
                    .HasMaxLength(80);

                entity.Property(e => e.IsCo2Present)
                    .HasColumnName("is_co2_present")
                    .HasMaxLength(1);

                entity.Property(e => e.IsH2sPresent)
                    .HasColumnName("is_h2s_present")
                    .HasMaxLength(1);

                entity.Property(e => e.IsLakeDrilled)
                    .HasColumnName("is_lake_drilled")
                    .HasMaxLength(1);

                entity.Property(e => e.IsLsaPresent)
                    .HasColumnName("is_lsa_present")
                    .HasMaxLength(1);

                entity.Property(e => e.IsMultilateral)
                    .HasColumnName("is_multilateral")
                    .HasMaxLength(1);

                entity.Property(e => e.IsOffshore)
                    .HasColumnName("is_offshore")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPlatform)
                    .HasColumnName("is_platform")
                    .HasMaxLength(1);

                entity.Property(e => e.IsProjectReadonly)
                    .HasColumnName("is_project_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSubsea)
                    .HasColumnName("is_subsea")
                    .HasMaxLength(1);

                entity.Property(e => e.LaheeClass)
                    .HasColumnName("lahee_class")
                    .HasMaxLength(32);

                entity.Property(e => e.LakeHeight).HasColumnName("lake_height");

                entity.Property(e => e.LeaseType)
                    .HasColumnName("lease_type")
                    .HasMaxLength(32);

                entity.Property(e => e.LocCountry)
                    .HasColumnName("loc_country")
                    .HasMaxLength(30);

                entity.Property(e => e.LocCounty)
                    .HasColumnName("loc_county")
                    .HasMaxLength(40);

                entity.Property(e => e.LocState)
                    .HasColumnName("loc_state")
                    .HasMaxLength(40);

                entity.Property(e => e.MaaspA).HasColumnName("maasp_a");

                entity.Property(e => e.MaaspB).HasColumnName("maasp_b");

                entity.Property(e => e.MaaspC).HasColumnName("maasp_c");

                entity.Property(e => e.MaaspD).HasColumnName("maasp_d");

                entity.Property(e => e.PreviousWellName)
                    .HasColumnName("previous_well_name")
                    .HasMaxLength(80);

                entity.Property(e => e.PumperRoute)
                    .HasColumnName("pumper_route")
                    .HasMaxLength(32);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(30);

                entity.Property(e => e.RedrillNo)
                    .HasColumnName("redrill_no")
                    .HasMaxLength(10);

                entity.Property(e => e.RedrillPrevWellId)
                    .HasColumnName("redrill_prev_well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.RoadDescription)
                    .HasColumnName("road_description")
                    .HasMaxLength(255);

                entity.Property(e => e.ScaleFactor).HasColumnName("scale_factor");

                entity.Property(e => e.SiteId)
                    .HasColumnName("site_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotEw).HasColumnName("slot_ew");

                entity.Property(e => e.SlotName)
                    .HasColumnName("slot_name")
                    .HasMaxLength(30);

                entity.Property(e => e.SlotNs).HasColumnName("slot_ns");

                entity.Property(e => e.SlotRadialError).HasColumnName("slot_radial_error");

                entity.Property(e => e.SpudDate)
                    .HasColumnName("spud_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TargetFormation)
                    .HasColumnName("target_formation")
                    .HasMaxLength(50);

                entity.Property(e => e.TightGroupId)
                    .HasColumnName("tight_group_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnitSetOnCreate)
                    .HasColumnName("unit_set_on_create")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.UseSlotAsReference).HasColumnName("use_slot_as_reference");

                entity.Property(e => e.UserDefined1)
                    .HasColumnName("user_defined_1")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefined10)
                    .HasColumnName("user_defined_10")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefined11)
                    .HasColumnName("user_defined_11")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefined12)
                    .HasColumnName("user_defined_12")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefined2)
                    .HasColumnName("user_defined_2")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefined3)
                    .HasColumnName("user_defined_3")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefined4)
                    .HasColumnName("user_defined_4")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefined5)
                    .HasColumnName("user_defined_5")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefined6)
                    .HasColumnName("user_defined_6")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefined7)
                    .HasColumnName("user_defined_7")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefined8)
                    .HasColumnName("user_defined_8")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefined9)
                    .HasColumnName("user_defined_9")
                    .HasMaxLength(40);

                entity.Property(e => e.UserDefinedDate1)
                    .HasColumnName("user_defined_date_1")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserDefinedDate2)
                    .HasColumnName("user_defined_date_2")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserDefinedDate3)
                    .HasColumnName("user_defined_date_3")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserDefinedDate4)
                    .HasColumnName("user_defined_date_4")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserDefinedDate5)
                    .HasColumnName("user_defined_date_5")
                    .HasColumnType("datetime");

                entity.Property(e => e.WaterDepth).HasColumnName("water_depth");

                entity.Property(e => e.WellCommonName)
                    .HasColumnName("well_common_name")
                    .HasMaxLength(60);

                entity.Property(e => e.WellDesc)
                    .HasColumnName("well_desc")
                    .HasMaxLength(80);

                entity.Property(e => e.WellDescAlternate)
                    .HasColumnName("well_desc_alternate")
                    .HasMaxLength(80);

                entity.Property(e => e.WellDirections)
                    .HasColumnName("well_directions")
                    .HasMaxLength(255);

                entity.Property(e => e.WellGeometry)
                    .HasColumnName("well_geometry")
                    .HasMaxLength(20);

                entity.Property(e => e.WellLegalName)
                    .HasColumnName("well_legal_name")
                    .HasMaxLength(60);

                entity.Property(e => e.WellNetInt).HasColumnName("well_net_int");

                entity.Property(e => e.WellOperator)
                    .HasColumnName("well_operator")
                    .HasMaxLength(60);

                entity.Property(e => e.WellOperatorOriginal)
                    .HasColumnName("well_operator_original")
                    .HasMaxLength(60);

                entity.Property(e => e.WellPurpose)
                    .HasColumnName("well_purpose")
                    .HasMaxLength(40);

                entity.Property(e => e.WellUwi)
                    .HasColumnName("well_uwi")
                    .HasMaxLength(80);

                entity.Property(e => e.WellUwiType)
                    .HasColumnName("well_uwi_type")
                    .HasMaxLength(20);

                entity.Property(e => e.WellWorkingInt).HasColumnName("well_working_int");

                entity.Property(e => e.WellheadDepth).HasColumnName("wellhead_depth");

                entity.Property(e => e.WrpAzimuth).HasColumnName("wrp_azimuth");

                entity.Property(e => e.WrpEw).HasColumnName("wrp_ew");

                entity.Property(e => e.WrpInclination).HasColumnName("wrp_inclination");

                entity.Property(e => e.WrpMd).HasColumnName("wrp_md");

                entity.Property(e => e.WrpNs).HasColumnName("wrp_ns");

                entity.Property(e => e.WrpOffset).HasColumnName("wrp_offset");

                entity.Property(e => e.WrpTvd).HasColumnName("wrp_tvd");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CdWellSource)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("R_305");
            });

            modelBuilder.Entity<CdWellStatusT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellStatusId })
                    .HasName("XPKCD_WELL_STATUS");

                entity.ToTable("CD_WELL_STATUS_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellStatusId)
                    .HasColumnName("well_status_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(100);

                entity.Property(e => e.CompletionType)
                    .HasColumnName("completion_type")
                    .HasMaxLength(32);

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.StatusDate)
                    .HasColumnName("status_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusDesc)
                    .HasColumnName("status_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusType)
                    .HasColumnName("status_type")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.WellType)
                    .HasColumnName("well_type")
                    .HasMaxLength(32);

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.CdWellStatusT)
                    .HasForeignKey(d => d.WellId)
                    .HasConstraintName("R_248");
            });

            modelBuilder.Entity<CdWellboreFormationT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.WellboreFormationId })
                    .HasName("XPKCD_WELLBORE_FORMATION");

                entity.ToTable("CD_WELLBORE_FORMATION_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreFormationId)
                    .HasColumnName("wellbore_formation_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AgeCode)
                    .HasColumnName("age_code")
                    .HasMaxLength(32);

                entity.Property(e => e.BitLife).HasColumnName("bit_life");

                entity.Property(e => e.BitType)
                    .HasColumnName("bit_type")
                    .HasMaxLength(20);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(100);

                entity.Property(e => e.CompetentLayer)
                    .HasColumnName("competent_layer")
                    .HasMaxLength(1);

                entity.Property(e => e.Conductivity).HasColumnName("conductivity");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DiffStickingLimit).HasColumnName("diff_sticking_limit");

                entity.Property(e => e.DipAngle).HasColumnName("dip_angle");

                entity.Property(e => e.DipDirection).HasColumnName("dip_direction");

                entity.Property(e => e.ElasticModulus).HasColumnName("elastic_modulus");

                entity.Property(e => e.EndGeoMapEasting).HasColumnName("end_geo_map_easting");

                entity.Property(e => e.EndGeoMapNorthing).HasColumnName("end_geo_map_northing");

                entity.Property(e => e.FormationDensity).HasColumnName("formation_density");

                entity.Property(e => e.FormationName)
                    .HasColumnName("formation_name")
                    .HasMaxLength(50);

                entity.Property(e => e.FormationNetPay).HasColumnName("formation_net_pay");

                entity.Property(e => e.FrozenConductivity).HasColumnName("frozen_conductivity");

                entity.Property(e => e.FrozenDensity).HasColumnName("frozen_density");

                entity.Property(e => e.HeatOfFusion).HasColumnName("heat_of_fusion");

                entity.Property(e => e.IsPermeable)
                    .HasColumnName("is_permeable")
                    .HasMaxLength(1);

                entity.Property(e => e.LithologyId)
                    .HasColumnName("lithology_id")
                    .HasMaxLength(16);

                entity.Property(e => e.MeltingPoint).HasColumnName("melting_point");

                entity.Property(e => e.OverbalanceMargin).HasColumnName("overbalance_margin");

                entity.Property(e => e.Permeability).HasColumnName("permeability");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(10);

                entity.Property(e => e.PoissonsRatio).HasColumnName("poissons_ratio");

                entity.Property(e => e.Porosity).HasColumnName("porosity");

                entity.Property(e => e.PrognosedBaseMd).HasColumnName("prognosed_base_md");

                entity.Property(e => e.PrognosedBaseMdSubsea).HasColumnName("prognosed_base_md_subsea");

                entity.Property(e => e.PrognosedBaseTvd).HasColumnName("prognosed_base_tvd");

                entity.Property(e => e.PrognosedBaseTvdSubsea).HasColumnName("prognosed_base_tvd_subsea");

                entity.Property(e => e.PrognosedDepthType).HasColumnName("prognosed_depth_type");

                entity.Property(e => e.PrognosedLithology)
                    .HasColumnName("prognosed_lithology")
                    .HasMaxLength(50);

                entity.Property(e => e.PrognosedMd).HasColumnName("prognosed_md");

                entity.Property(e => e.PrognosedMdSubsea).HasColumnName("prognosed_md_subsea");

                entity.Property(e => e.PrognosedTvd).HasColumnName("prognosed_tvd");

                entity.Property(e => e.PrognosedTvdEnd).HasColumnName("prognosed_tvd_end");

                entity.Property(e => e.PrognosedTvdSubsea).HasColumnName("prognosed_tvd_subsea");

                entity.Property(e => e.PrognosedUncertainty).HasColumnName("prognosed_uncertainty");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RateOfPenetration).HasColumnName("rate_of_penetration");

                entity.Property(e => e.ReservoirId)
                    .HasColumnName("reservoir_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.SpecificHeat).HasColumnName("specific_heat");

                entity.Property(e => e.StabilityMinMw).HasColumnName("stability_min_mw");

                entity.Property(e => e.StartGeoMapEasting).HasColumnName("start_geo_map_easting");

                entity.Property(e => e.StartGeoMapNorthing).HasColumnName("start_geo_map_northing");

                entity.Property(e => e.StratUnitId)
                    .HasColumnName("strat_unit_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SurfaceId)
                    .HasColumnName("surface_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.CdWellboreFormationT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId })
                    .HasConstraintName("R_441");
            });

            modelBuilder.Entity<CdWellboreT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId })
                    .HasName("XPKCD_WELLBORE");

                entity.ToTable("CD_WELLBORE_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApiNo)
                    .HasColumnName("api_no")
                    .HasMaxLength(20);

                entity.Property(e => e.ApiSuffix)
                    .HasColumnName("api_suffix")
                    .HasMaxLength(8);

                entity.Property(e => e.AuthorizedMd).HasColumnName("authorized_md");

                entity.Property(e => e.AuthorizedTvd).HasColumnName("authorized_tvd");

                entity.Property(e => e.BRange).HasColumnName("b_range");

                entity.Property(e => e.BRatio).HasColumnName("b_ratio");

                entity.Property(e => e.BatchSetCode)
                    .HasColumnName("batch_set_code")
                    .HasMaxLength(6);

                entity.Property(e => e.BhMd).HasColumnName("bh_md");

                entity.Property(e => e.BhTvd).HasColumnName("bh_tvd");

                entity.Property(e => e.BottomHoleTemp).HasColumnName("bottom_hole_temp");

                entity.Property(e => e.BudgetedMd).HasColumnName("budgeted_md");

                entity.Property(e => e.BudgetedTvd).HasColumnName("budgeted_tvd");

                entity.Property(e => e.ConductorSetByDrillRig)
                    .HasColumnName("conductor_set_by_drill_rig")
                    .HasMaxLength(1);

                entity.Property(e => e.ConnectionId)
                    .HasColumnName("connection_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateTdReached)
                    .HasColumnName("date_td_reached")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultFluidId)
                    .HasColumnName("default_fluid_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndStatus)
                    .HasColumnName("end_status")
                    .HasMaxLength(30);

                entity.Property(e => e.ExternalWellId)
                    .HasColumnName("external_well_id")
                    .HasMaxLength(60);

                entity.Property(e => e.GeoDescriptionBh)
                    .HasColumnName("geo_description_bh")
                    .HasMaxLength(80);

                entity.Property(e => e.GeoDescriptionKo)
                    .HasColumnName("geo_description_ko")
                    .HasMaxLength(80);

                entity.Property(e => e.GeoLatitudeBh).HasColumnName("geo_latitude_bh");

                entity.Property(e => e.GeoLatitudeKo).HasColumnName("geo_latitude_ko");

                entity.Property(e => e.GeoLongitudeBh).HasColumnName("geo_longitude_bh");

                entity.Property(e => e.GeoLongitudeKo).HasColumnName("geo_longitude_ko");

                entity.Property(e => e.GeoOffsetEastBh).HasColumnName("geo_offset_east_bh");

                entity.Property(e => e.GeoOffsetEastKo).HasColumnName("geo_offset_east_ko");

                entity.Property(e => e.GeoOffsetNorthBh).HasColumnName("geo_offset_north_bh");

                entity.Property(e => e.GeoOffsetNorthKo).HasColumnName("geo_offset_north_ko");

                entity.Property(e => e.GeoOffsetReferenceBh)
                    .HasColumnName("geo_offset_reference_bh")
                    .HasMaxLength(80);

                entity.Property(e => e.GeoOffsetReferenceKo)
                    .HasColumnName("geo_offset_reference_ko")
                    .HasMaxLength(80);

                entity.Property(e => e.GeologicalPlay)
                    .HasColumnName("geological_play")
                    .HasMaxLength(50);

                entity.Property(e => e.GovernmentNo)
                    .HasColumnName("government_no")
                    .HasMaxLength(20);

                entity.Property(e => e.HorizontalLength).HasColumnName("horizontal_length");

                entity.Property(e => e.Interpolate)
                    .HasColumnName("interpolate")
                    .HasMaxLength(1);

                entity.Property(e => e.InterpolationInterval).HasColumnName("interpolation_interval");

                entity.Property(e => e.IsComplex)
                    .HasColumnName("is_complex")
                    .HasMaxLength(1);

                entity.Property(e => e.IsContingencySidetrack)
                    .HasColumnName("is_contingency_sidetrack")
                    .HasMaxLength(1);

                entity.Property(e => e.IsDeviated)
                    .HasColumnName("is_deviated")
                    .HasMaxLength(1);

                entity.Property(e => e.IsExceptional)
                    .HasColumnName("is_exceptional")
                    .HasMaxLength(1);

                entity.Property(e => e.IsHighPressure)
                    .HasColumnName("is_high_pressure")
                    .HasMaxLength(1);

                entity.Property(e => e.IsHighTemp)
                    .HasColumnName("is_high_temp")
                    .HasMaxLength(1);

                entity.Property(e => e.IsLocator)
                    .HasColumnName("is_locator")
                    .HasMaxLength(1);

                entity.Property(e => e.IsManagedPressure)
                    .HasColumnName("is_managed_pressure")
                    .HasMaxLength(1);

                entity.Property(e => e.IsMechanicalSidetrack)
                    .HasColumnName("is_mechanical_sidetrack")
                    .HasMaxLength(1);

                entity.Property(e => e.IsOfflineSlotRecovery)
                    .HasColumnName("is_offline_slot_recovery")
                    .HasMaxLength(1);

                entity.Property(e => e.IsProductionCapable)
                    .HasColumnName("is_production_capable")
                    .HasMaxLength(1);

                entity.Property(e => e.IsProjectReadonly)
                    .HasColumnName("is_project_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSubSalt)
                    .HasColumnName("is_sub_salt")
                    .HasMaxLength(1);

                entity.Property(e => e.IsUnderbalanced)
                    .HasColumnName("is_underbalanced")
                    .HasMaxLength(1);

                entity.Property(e => e.KoDate)
                    .HasColumnName("ko_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.KoMd).HasColumnName("ko_md");

                entity.Property(e => e.KoTvd).HasColumnName("ko_tvd");

                entity.Property(e => e.LicenseDate)
                    .HasColumnName("license_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LicenseNo)
                    .HasColumnName("license_no")
                    .HasMaxLength(20);

                entity.Property(e => e.Licensee)
                    .HasColumnName("licensee")
                    .HasMaxLength(60);

                entity.Property(e => e.NewTechniques)
                    .HasColumnName("new_techniques")
                    .HasMaxLength(128);

                entity.Property(e => e.OwWellUwi)
                    .HasColumnName("ow_well_uwi")
                    .HasMaxLength(26);

                entity.Property(e => e.ParentWellboreId)
                    .HasColumnName("parent_wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayType)
                    .HasColumnName("play_type")
                    .HasMaxLength(2);

                entity.Property(e => e.PlugbackMd).HasColumnName("plugback_md");

                entity.Property(e => e.PlugbackTvd).HasColumnName("plugback_tvd");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(30);

                entity.Property(e => e.Redrill)
                    .HasColumnName("redrill")
                    .HasMaxLength(16);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.RigName)
                    .HasColumnName("rig_name")
                    .HasMaxLength(60);

                entity.Property(e => e.RtSampleDepthInterval).HasColumnName("rt_sample_depth_interval");

                entity.Property(e => e.SubSaltBaseTvd).HasColumnName("sub_salt_base_tvd");

                entity.Property(e => e.SubSaltTopTvd).HasColumnName("sub_salt_top_tvd");

                entity.Property(e => e.TamlClass)
                    .HasColumnName("taml_class")
                    .HasMaxLength(6);

                entity.Property(e => e.TightGroupId)
                    .HasColumnName("tight_group_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TypicalSchematicType).HasColumnName("typical_schematic_type");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.UserDefinedDepth1).HasColumnName("user_defined_depth_1");

                entity.Property(e => e.UserDefinedDepth2).HasColumnName("user_defined_depth_2");

                entity.Property(e => e.WellLegalName)
                    .HasColumnName("well_legal_name")
                    .HasMaxLength(60);

                entity.Property(e => e.WellboreLabel)
                    .HasColumnName("wellbore_label")
                    .HasMaxLength(60);

                entity.Property(e => e.WellboreName)
                    .HasColumnName("wellbore_name")
                    .HasMaxLength(60);

                entity.Property(e => e.WellboreNo)
                    .HasColumnName("wellbore_no")
                    .HasMaxLength(2);

                entity.Property(e => e.WellboreTypeId)
                    .HasColumnName("wellbore_type_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreTypePolicyId)
                    .HasColumnName("wellbore_type_policy_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreUwi)
                    .HasColumnName("wellbore_uwi")
                    .HasMaxLength(60);

                entity.Property(e => e.WellpathType).HasColumnName("wellpath_type");

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.CdWellboreT)
                    .HasForeignKey(d => d.WellId)
                    .HasConstraintName("R_315");
            });

            modelBuilder.Entity<DmActivityT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.ActivityId, e.DailyId })
                    .HasName("XPKDM_ACTIVITY");

                entity.ToTable("DM_ACTIVITY_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activity_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActivityAltCode1)
                    .HasColumnName("activity_alt_code1")
                    .HasMaxLength(12);

                entity.Property(e => e.ActivityAltCode2)
                    .HasColumnName("activity_alt_code2")
                    .HasMaxLength(12);

                entity.Property(e => e.ActivityAltCode3)
                    .HasColumnName("activity_alt_code3")
                    .HasMaxLength(12);

                entity.Property(e => e.ActivityClass)
                    .HasColumnName("activity_class")
                    .HasMaxLength(20);

                entity.Property(e => e.ActivityClassDesc)
                    .HasColumnName("activity_class_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.ActivityCode)
                    .HasColumnName("activity_code")
                    .HasMaxLength(20);

                entity.Property(e => e.ActivityCodeDesc)
                    .HasColumnName("activity_code_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.ActivityDuration).HasColumnName("activity_duration");

                entity.Property(e => e.ActivityGroup)
                    .HasColumnName("activity_group")
                    .HasMaxLength(20);

                entity.Property(e => e.ActivityMemo)
                    .HasColumnName("activity_memo")
                    .HasColumnType("ntext");

                entity.Property(e => e.ActivityPhase)
                    .HasColumnName("activity_phase")
                    .HasMaxLength(20);

                entity.Property(e => e.ActivitySubcode)
                    .HasColumnName("activity_subcode")
                    .HasMaxLength(20);

                entity.Property(e => e.ActivitySubcode2)
                    .HasColumnName("activity_subcode2")
                    .HasMaxLength(20);

                entity.Property(e => e.ActivitySubcodeDesc)
                    .HasColumnName("activity_subcode_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.BillingCode)
                    .HasColumnName("billing_code")
                    .HasMaxLength(20);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(255);

                entity.Property(e => e.CompletionId)
                    .HasColumnName("completion_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostClass)
                    .HasColumnName("cost_class")
                    .HasMaxLength(16);

                entity.Property(e => e.CostCode)
                    .HasColumnName("cost_code")
                    .HasMaxLength(40);

                entity.Property(e => e.CostSubcode)
                    .HasColumnName("cost_subcode")
                    .HasMaxLength(40);

                entity.Property(e => e.CustomCode1)
                    .HasColumnName("custom_code1")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomCode2)
                    .HasColumnName("custom_code2")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomCode3)
                    .HasColumnName("custom_code3")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomCode4)
                    .HasColumnName("custom_code4")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomCode5)
                    .HasColumnName("custom_code5")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomCode6)
                    .HasColumnName("custom_code6")
                    .HasMaxLength(100);

                entity.Property(e => e.FailureId)
                    .HasColumnName("failure_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LinkedReportJournalId)
                    .HasColumnName("linked_report_journal_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MdFrom).HasColumnName("md_from");

                entity.Property(e => e.MdTo).HasColumnName("md_to");

                entity.Property(e => e.NptLevel).HasColumnName("npt_level");

                entity.Property(e => e.OffBottomTorque).HasColumnName("off_bottom_torque");

                entity.Property(e => e.OnBottomTorque).HasColumnName("on_bottom_torque");

                entity.Property(e => e.PickupWeight).HasColumnName("pickup_weight");

                entity.Property(e => e.RotatingOffBottom).HasColumnName("rotating_off_bottom");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.ServiceCompany)
                    .HasColumnName("service_company")
                    .HasMaxLength(60);

                entity.Property(e => e.SlackoffWeight).HasColumnName("slackoff_weight");

                entity.Property(e => e.StepNo)
                    .HasColumnName("step_no")
                    .HasMaxLength(20);

                entity.Property(e => e.TimeFrom)
                    .HasColumnName("time_from")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeTo)
                    .HasColumnName("time_to")
                    .HasColumnType("datetime");

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreZoneId)
                    .HasColumnName("wellbore_zone_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmActivityT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_176");
            });

            modelBuilder.Entity<DmAfe>(entity =>
            {
                entity.HasKey(e => e.AfeId)
                    .HasName("XPKDM_AFE");

                entity.ToTable("DM_AFE");

                entity.Property(e => e.AfeId)
                    .HasColumnName("afe_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActivityClass)
                    .HasColumnName("activity_class")
                    .HasMaxLength(20);

                entity.Property(e => e.ActivityCode)
                    .HasColumnName("activity_code")
                    .HasMaxLength(20);

                entity.Property(e => e.ActivityPhase)
                    .HasColumnName("activity_phase")
                    .HasMaxLength(20);

                entity.Property(e => e.ActivitySubcode)
                    .HasColumnName("activity_subcode")
                    .HasMaxLength(20);

                entity.Property(e => e.ActualDays).HasColumnName("actual_days");

                entity.Property(e => e.AfeDesc)
                    .HasColumnName("afe_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.AfeNo)
                    .HasColumnName("afe_no")
                    .HasMaxLength(25);

                entity.Property(e => e.AfeTotal).HasColumnName("afe_total");

                entity.Property(e => e.AltCurrencyCode)
                    .HasColumnName("alt_currency_code")
                    .HasMaxLength(3);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("approved_by")
                    .HasMaxLength(60);

                entity.Property(e => e.AuthorizedMd).HasColumnName("authorized_md");

                entity.Property(e => e.AuthorizedTvd).HasColumnName("authorized_tvd");

                entity.Property(e => e.BudgetDesc)
                    .HasColumnName("budget_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.ContingencyPercent).HasColumnName("contingency_percent");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.CumulativeCost).HasColumnName("cumulative_cost");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(3);

                entity.Property(e => e.CurrencyExchRate).HasColumnName("currency_exch_rate");

                entity.Property(e => e.DateApproval)
                    .HasColumnName("date_approval")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateReport)
                    .HasColumnName("date_report")
                    .HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentCode)
                    .HasColumnName("department_code")
                    .HasMaxLength(6);

                entity.Property(e => e.EstimatedDays).HasColumnName("estimated_days");

                entity.Property(e => e.Estimator)
                    .HasColumnName("estimator")
                    .HasMaxLength(60);

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("project_code")
                    .HasMaxLength(6);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("project_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("ntext");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<DmAfeSupp>(entity =>
            {
                entity.HasKey(e => new { e.AfeId, e.AfeSuppId })
                    .HasName("XPKDM_AFE_SUPP");

                entity.ToTable("DM_AFE_SUPP");

                entity.Property(e => e.AfeId)
                    .HasColumnName("afe_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AfeSuppId)
                    .HasColumnName("afe_supp_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AfeSuppNo)
                    .HasColumnName("afe_supp_no")
                    .HasMaxLength(50);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("approved_by")
                    .HasMaxLength(60);

                entity.Property(e => e.CumSuppCost).HasColumnName("cum_supp_cost");

                entity.Property(e => e.DateApproved)
                    .HasColumnName("date_approved")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateSupplement)
                    .HasColumnName("date_supplement")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pool)
                    .HasColumnName("pool")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("ntext");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.HasOne(d => d.Afe)
                    .WithMany(p => p.DmAfeSupp)
                    .HasForeignKey(d => d.AfeId)
                    .HasConstraintName("R_188");
            });

            modelBuilder.Entity<DmAnchorOpT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.AnchorOpId })
                    .HasName("XPKDM_ANCHOR_OP");

                entity.ToTable("DM_ANCHOR_OP_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnchorOpId)
                    .HasColumnName("anchor_op_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnchorId)
                    .HasColumnName("anchor_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.DateOp)
                    .HasColumnName("date_op")
                    .HasColumnType("datetime");

                entity.Property(e => e.Easting).HasColumnName("easting");

                entity.Property(e => e.IsCarryover)
                    .HasColumnName("is_carryover")
                    .HasMaxLength(1);

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Northing).HasColumnName("northing");

                entity.Property(e => e.Preload).HasColumnName("preload");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.Tension).HasColumnName("tension");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmAnchorOpT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_2139");
            });

            modelBuilder.Entity<DmBhaOpT>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.WellId, e.DailyId, e.BhaOpId })
                    .HasName("XPKDM_BHA_OP");

                entity.ToTable("DM_BHA_OP_T");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BhaOpId)
                    .HasColumnName("bha_op_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualHookLoad).HasColumnName("actual_hook_load");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.BhaRunId)
                    .HasColumnName("bha_run_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CirculatingHours).HasColumnName("circulating_hours");

                entity.Property(e => e.DateOp)
                    .HasColumnName("date_op")
                    .HasColumnType("datetime");

                entity.Property(e => e.DoglegSeverity).HasColumnName("dogleg_severity");

                entity.Property(e => e.Drag).HasColumnName("drag");

                entity.Property(e => e.DrillMode)
                    .HasColumnName("drill_mode")
                    .HasMaxLength(16);

                entity.Property(e => e.DrillingHours).HasColumnName("drilling_hours");

                entity.Property(e => e.FlowRate).HasColumnName("flow_rate");

                entity.Property(e => e.Inclination).HasColumnName("inclination");

                entity.Property(e => e.MaxOverpull).HasColumnName("max_overpull");

                entity.Property(e => e.MdOp).HasColumnName("md_op");

                entity.Property(e => e.OffBottomCircPressure).HasColumnName("off_bottom_circ_pressure");

                entity.Property(e => e.OnBottomCircPressure).HasColumnName("on_bottom_circ_pressure");

                entity.Property(e => e.OperationType)
                    .HasColumnName("operation_type")
                    .HasMaxLength(32);

                entity.Property(e => e.RotaryRpm).HasColumnName("rotary_rpm");

                entity.Property(e => e.Rpm).HasColumnName("rpm");

                entity.Property(e => e.RpmRotatingAvg).HasColumnName("rpm_rotating_avg");

                entity.Property(e => e.RpmRotatingCurrent).HasColumnName("rpm_rotating_current");

                entity.Property(e => e.RpmRotatingMax).HasColumnName("rpm_rotating_max");

                entity.Property(e => e.RpmRotatingMin).HasColumnName("rpm_rotating_min");

                entity.Property(e => e.StandPipePressure).HasColumnName("stand_pipe_pressure");

                entity.Property(e => e.StandpipePressureMax).HasColumnName("standpipe_pressure_max");

                entity.Property(e => e.StandpipePressureMin).HasColumnName("standpipe_pressure_min");

                entity.Property(e => e.StringWeightDown).HasColumnName("string_weight_down");

                entity.Property(e => e.StringWeightRotating).HasColumnName("string_weight_rotating");

                entity.Property(e => e.StringWeightUp).HasColumnName("string_weight_up");

                entity.Property(e => e.ToolFaceOrientation).HasColumnName("tool_face_orientation");

                entity.Property(e => e.TorqueAvg).HasColumnName("torque_avg");

                entity.Property(e => e.TorqueCurrent).HasColumnName("torque_current");

                entity.Property(e => e.TorqueMax).HasColumnName("torque_max");

                entity.Property(e => e.TorqueMin).HasColumnName("torque_min");

                entity.Property(e => e.TorqueOffBottom).HasColumnName("torque_off_bottom");

                entity.Property(e => e.TorqueOnBottom).HasColumnName("torque_on_bottom");

                entity.Property(e => e.TorqueOnBottomAvg).HasColumnName("torque_on_bottom_avg");

                entity.Property(e => e.TorqueOnBottomCurrent).HasColumnName("torque_on_bottom_current");

                entity.Property(e => e.TorqueOnBottomMax).HasColumnName("torque_on_bottom_max");

                entity.Property(e => e.TorqueOnBottomMin).HasColumnName("torque_on_bottom_min");

                entity.Property(e => e.TripRate).HasColumnName("trip_rate");

                entity.Property(e => e.Tvd).HasColumnName("tvd");

                entity.Property(e => e.WeightAboveJars).HasColumnName("weight_above_jars");

                entity.Property(e => e.WeightBelowJars).HasColumnName("weight_below_jars");

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Wob).HasColumnName("wob");

                entity.Property(e => e.WobAvg).HasColumnName("wob_avg");

                entity.Property(e => e.WobCurrent).HasColumnName("wob_current");

                entity.Property(e => e.WobMax).HasColumnName("wob_max");

                entity.Property(e => e.WobMin).HasColumnName("wob_min");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmBhaOpT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_270");
            });

            modelBuilder.Entity<DmBhaRunT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.BhaRunId })
                    .HasName("XPKDM_BHA_RUN");

                entity.ToTable("DM_BHA_RUN_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BhaRunId)
                    .HasColumnName("bha_run_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyId)
                    .HasColumnName("assembly_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("ntext");

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DailyRotatingFootage).HasColumnName("daily_rotating_footage");

                entity.Property(e => e.DailyRotatingHours).HasColumnName("daily_rotating_hours");

                entity.Property(e => e.DailySlidingFootage).HasColumnName("daily_sliding_footage");

                entity.Property(e => e.DailySlidingHours).HasColumnName("daily_sliding_hours");

                entity.Property(e => e.DateIn)
                    .HasColumnName("date_in")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOut)
                    .HasColumnName("date_out")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.IsLeftInHole)
                    .HasColumnName("is_left_in_hole")
                    .HasMaxLength(1);

                entity.Property(e => e.IsNuclearSource)
                    .HasColumnName("is_nuclear_source")
                    .HasMaxLength(1);

                entity.Property(e => e.MdIn).HasColumnName("md_in");

                entity.Property(e => e.MdOut).HasColumnName("md_out");

                entity.Property(e => e.PerformanceActual)
                    .HasColumnName("performance_actual")
                    .HasMaxLength(255);

                entity.Property(e => e.PerformancePredicted)
                    .HasColumnName("performance_predicted")
                    .HasMaxLength(255);

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(10);

                entity.Property(e => e.Purpose)
                    .HasColumnName("purpose")
                    .HasMaxLength(40);

                entity.Property(e => e.ScenarioId)
                    .HasColumnName("scenario_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TripTimeIn).HasColumnName("trip_time_in");

                entity.Property(e => e.TripTimeOut).HasColumnName("trip_time_out");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.DmBhaRunT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId })
                    .HasConstraintName("R_2199");
            });

            modelBuilder.Entity<DmBitOpT>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.WellId, e.DailyId, e.BitOpId })
                    .HasName("XPKDM_BIT_OP");

                entity.ToTable("DM_BIT_OP_T");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BitOpId)
                    .HasColumnName("bit_op_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActivityCode)
                    .HasColumnName("activity_code")
                    .HasMaxLength(20);

                entity.Property(e => e.AssemblyCompId)
                    .HasColumnName("assembly_comp_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssemblyId)
                    .HasColumnName("assembly_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.BhaRunId)
                    .HasColumnName("bha_run_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CirculatingTime).HasColumnName("circulating_time");

                entity.Property(e => e.ConnectionTime).HasColumnName("connection_time");

                entity.Property(e => e.DateOp)
                    .HasColumnName("date_op")
                    .HasColumnType("datetime");

                entity.Property(e => e.Density).HasColumnName("density");

                entity.Property(e => e.Flowrate).HasColumnName("flowrate");

                entity.Property(e => e.FormationName)
                    .HasColumnName("formation_name")
                    .HasMaxLength(50);

                entity.Property(e => e.HydraulicHp).HasColumnName("hydraulic_hp");

                entity.Property(e => e.Inclination).HasColumnName("inclination");

                entity.Property(e => e.KiloRev).HasColumnName("kilo_rev");

                entity.Property(e => e.MdBase).HasColumnName("md_base");

                entity.Property(e => e.MdOp).HasColumnName("md_op");

                entity.Property(e => e.MdTop).HasColumnName("md_top");

                entity.Property(e => e.NozzleVelocity).HasColumnName("nozzle_velocity");

                entity.Property(e => e.OpDuration).HasColumnName("op_duration");

                entity.Property(e => e.OpProgress).HasColumnName("op_progress");

                entity.Property(e => e.PressureDropBit).HasColumnName("pressure_drop_bit");

                entity.Property(e => e.PressureOffBottom).HasColumnName("pressure_off_bottom");

                entity.Property(e => e.PressureStandpipe).HasColumnName("pressure_standpipe");

                entity.Property(e => e.Rop).HasColumnName("rop");

                entity.Property(e => e.Rpg).HasColumnName("rpg");

                entity.Property(e => e.RpmAvg).HasColumnName("rpm_avg");

                entity.Property(e => e.RpmCurrent).HasColumnName("rpm_current");

                entity.Property(e => e.RpmDownHole).HasColumnName("rpm_down_hole");

                entity.Property(e => e.RpmMax).HasColumnName("rpm_max");

                entity.Property(e => e.RpmMin).HasColumnName("rpm_min");

                entity.Property(e => e.RpmRotatingAvg).HasColumnName("rpm_rotating_avg");

                entity.Property(e => e.RpmRotatingCurrent).HasColumnName("rpm_rotating_current");

                entity.Property(e => e.RpmRotatingMax).HasColumnName("rpm_rotating_max");

                entity.Property(e => e.RpmRotatingMin).HasColumnName("rpm_rotating_min");

                entity.Property(e => e.StandpipePressureMax).HasColumnName("standpipe_pressure_max");

                entity.Property(e => e.StandpipePressureMin).HasColumnName("standpipe_pressure_min");

                entity.Property(e => e.TorqueAvg).HasColumnName("torque_avg");

                entity.Property(e => e.TorqueCurrent).HasColumnName("torque_current");

                entity.Property(e => e.TorqueMax).HasColumnName("torque_max");

                entity.Property(e => e.TorqueMin).HasColumnName("torque_min");

                entity.Property(e => e.WellboreFormationId)
                    .HasColumnName("wellbore_formation_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WobAvg).HasColumnName("wob_avg");

                entity.Property(e => e.WobCurrent).HasColumnName("wob_current");

                entity.Property(e => e.WobMax).HasColumnName("wob_max");

                entity.Property(e => e.WobMin).HasColumnName("wob_min");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmBitOpT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_272");
            });

            modelBuilder.Entity<DmBulkT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.BulkId })
                    .HasName("XPKDM_BULK");

                entity.ToTable("DM_BULK_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BulkId)
                    .HasColumnName("bulk_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstUsedDate)
                    .HasColumnName("first_used_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductName)
                    .HasColumnName("product_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.UnitMeasure).HasColumnName("unit_measure");

                entity.Property(e => e.UnitSize)
                    .HasColumnName("unit_size")
                    .HasMaxLength(16);

                entity.HasOne(d => d.DmEventT)
                    .WithMany(p => p.DmBulkT)
                    .HasForeignKey(d => new { d.WellId, d.EventId })
                    .HasConstraintName("R_1984");
            });

            modelBuilder.Entity<DmBulkTranT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.BulkTranId })
                    .HasName("XPKDM_BULK_TRAN");

                entity.ToTable("DM_BULK_TRAN_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BulkTranId)
                    .HasColumnName("bulk_tran_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BulkId)
                    .HasColumnName("bulk_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QuantityAdjusted).HasColumnName("quantity_adjusted");

                entity.Property(e => e.QuantityOnHand).HasColumnName("quantity_on_hand");

                entity.Property(e => e.QuantityOrdered).HasColumnName("quantity_ordered");

                entity.Property(e => e.QuantityReceived).HasColumnName("quantity_received");

                entity.Property(e => e.QuantityReturned).HasColumnName("quantity_returned");

                entity.Property(e => e.QuantityUsed).HasColumnName("quantity_used");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmBulkTranT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_1987");
            });

            modelBuilder.Entity<DmCentrifugeOpT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.CentrifugeOpId })
                    .HasName("XPKDM_CENTRIFUGE_OP");

                entity.ToTable("DM_CENTRIFUGE_OP_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CentrifugeOpId)
                    .HasColumnName("centrifuge_op_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CentrifugeId)
                    .HasColumnName("centrifuge_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateOp)
                    .HasColumnName("date_op")
                    .HasColumnType("datetime");

                entity.Property(e => e.DensityFeed).HasColumnName("density_feed");

                entity.Property(e => e.DensityOut).HasColumnName("density_out");

                entity.Property(e => e.DensityOverflow).HasColumnName("density_overflow");

                entity.Property(e => e.DensityUnderflow).HasColumnName("density_underflow");

                entity.Property(e => e.DischargeLocation)
                    .HasColumnName("discharge_location")
                    .HasMaxLength(30);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.FeedFlowrate).HasColumnName("feed_flowrate");

                entity.Property(e => e.FeedSource)
                    .HasColumnName("feed_source")
                    .HasMaxLength(30);

                entity.Property(e => e.MdOp).HasColumnName("md_op");

                entity.Property(e => e.OpCode)
                    .HasColumnName("op_code")
                    .HasMaxLength(2);

                entity.Property(e => e.OverflowFlowrate).HasColumnName("overflow_flowrate");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rpm).HasColumnName("rpm");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.UnderflowFlowrate).HasColumnName("underflow_flowrate");

                entity.Property(e => e.VolOilRetained).HasColumnName("vol_oil_retained");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmCentrifugeOpT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_1992");
            });

            modelBuilder.Entity<DmCompanyDailyT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.CompanyDailyId })
                    .HasName("XPKDM_COMPANY_DAILY");

                entity.ToTable("DM_COMPANY_DAILY_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyDailyId)
                    .HasColumnName("company_daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsCarryover)
                    .HasColumnName("is_carryover")
                    .HasMaxLength(1);

                entity.Property(e => e.NumPeople).HasColumnName("num_people");

                entity.Property(e => e.TotalHours).HasColumnName("total_hours");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmCompanyDailyT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_2858");
            });

            modelBuilder.Entity<DmCompanyT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.CompanyId })
                    .HasName("XPKDM_COMPANY");

                entity.ToTable("DM_COMPANY_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(60);

                entity.Property(e => e.ContactAddress)
                    .HasColumnName("contact_address")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactFaxNo)
                    .HasColumnName("contact_fax_no")
                    .HasMaxLength(32);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(60);

                entity.Property(e => e.ContactTelNo)
                    .HasColumnName("contact_tel_no")
                    .HasMaxLength(32);

                entity.Property(e => e.FirstUsedDate)
                    .HasColumnName("first_used_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.HasOne(d => d.DmEventT)
                    .WithMany(p => p.DmCompanyT)
                    .HasForeignKey(d => new { d.WellId, d.EventId })
                    .HasConstraintName("R_2857");
            });

            modelBuilder.Entity<DmCrCleanupT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.CleanupId })
                    .HasName("XPKDM_CR_CLEANUP_T");

                entity.ToTable("DM_CR_CLEANUP_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CleanupId)
                    .HasColumnName("cleanup_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AcceptedByPerson)
                    .HasColumnName("accepted_by_person")
                    .HasMaxLength(60);

                entity.Property(e => e.AcceptedByPhone)
                    .HasColumnName("accepted_by_phone")
                    .HasMaxLength(32);

                entity.Property(e => e.AgencyContact)
                    .HasColumnName("agency_contact")
                    .HasMaxLength(60);

                entity.Property(e => e.AgencyContactPhone)
                    .HasColumnName("agency_contact_phone")
                    .HasMaxLength(32);

                entity.Property(e => e.AgencyName)
                    .HasColumnName("agency_name")
                    .HasMaxLength(60);

                entity.Property(e => e.AmendmentsForeman)
                    .HasColumnName("amendments_foreman")
                    .HasMaxLength(60);

                entity.Property(e => e.AssociatedDrillingEventId)
                    .HasColumnName("associated_drilling_event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BrushDisposalLocation)
                    .HasColumnName("brush_disposal_location")
                    .HasMaxLength(255);

                entity.Property(e => e.BrushDisposalMethod)
                    .HasColumnName("brush_disposal_method")
                    .HasMaxLength(255);

                entity.Property(e => e.CleanupComments)
                    .HasColumnName("cleanup_comments")
                    .HasMaxLength(255);

                entity.Property(e => e.Contractor)
                    .HasColumnName("contractor")
                    .HasMaxLength(60);

                entity.Property(e => e.CorrectiveMeasures)
                    .HasColumnName("corrective_measures")
                    .HasMaxLength(255);

                entity.Property(e => e.DisposalComments)
                    .HasColumnName("disposal_comments")
                    .HasMaxLength(512);

                entity.Property(e => e.DisposalProblemDescription)
                    .HasColumnName("disposal_problem_description")
                    .HasMaxLength(255);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EstimatedAmount).HasColumnName("estimated_amount");

                entity.Property(e => e.EstimatedAmountUnit)
                    .HasColumnName("estimated_amount_unit")
                    .HasMaxLength(16);

                entity.Property(e => e.ForemanName)
                    .HasColumnName("foreman_name")
                    .HasMaxLength(60);

                entity.Property(e => e.GroundConditionFinal)
                    .HasColumnName("ground_condition_final")
                    .HasMaxLength(16);

                entity.Property(e => e.GroundConditionInitial)
                    .HasColumnName("ground_condition_initial")
                    .HasMaxLength(16);

                entity.Property(e => e.IsArtesianAquifer)
                    .HasColumnName("is_artesian_aquifer")
                    .HasMaxLength(1);

                entity.Property(e => e.IsCleanupComplete)
                    .HasColumnName("is_cleanup_complete")
                    .HasMaxLength(1);

                entity.Property(e => e.IsOffLeaseConsentObtained)
                    .HasColumnName("is_off_lease_consent_obtained")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSaltZone)
                    .HasColumnName("is_salt_zone")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSiteAccepted)
                    .HasColumnName("is_site_accepted")
                    .HasMaxLength(1);

                entity.Property(e => e.IsWaterWellToRemain)
                    .HasColumnName("is_water_well_to_remain")
                    .HasMaxLength(1);

                entity.Property(e => e.IsWorkDoneByLandowner)
                    .HasColumnName("is_work_done_by_landowner")
                    .HasMaxLength(1);

                entity.Property(e => e.LocationName)
                    .HasColumnName("location_name")
                    .HasMaxLength(128);

                entity.Property(e => e.LocationProvince)
                    .HasColumnName("location_province")
                    .HasMaxLength(16);

                entity.Property(e => e.LocationUwi)
                    .HasColumnName("location_uwi")
                    .HasMaxLength(16);

                entity.Property(e => e.OffLeaseConditions)
                    .HasColumnName("off_lease_conditions")
                    .HasMaxLength(255);

                entity.Property(e => e.OffLeaseConsenterName)
                    .HasColumnName("off_lease_consenter_name")
                    .HasMaxLength(60);

                entity.Property(e => e.OffLeaseConsenterPhone)
                    .HasColumnName("off_lease_consenter_phone")
                    .HasMaxLength(32);

                entity.Property(e => e.OffLeaseDisposalContractor)
                    .HasColumnName("off_lease_disposal_contractor")
                    .HasMaxLength(60);

                entity.Property(e => e.OwnerComments)
                    .HasColumnName("owner_comments")
                    .HasColumnType("ntext");

                entity.Property(e => e.Packaging)
                    .HasColumnName("packaging")
                    .HasMaxLength(16);

                entity.Property(e => e.RecontourDate)
                    .HasColumnName("recontour_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecontourGroundCondition)
                    .HasColumnName("recontour_ground_condition")
                    .HasMaxLength(16);

                entity.Property(e => e.RecordNumber)
                    .HasColumnName("record_number")
                    .HasMaxLength(16);

                entity.Property(e => e.RecordType)
                    .HasColumnName("record_type")
                    .HasMaxLength(16);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("ntext");

                entity.Property(e => e.RemoteLocation)
                    .HasColumnName("remote_location")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReportJournalId)
                    .HasColumnName("report_journal_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("supervisor")
                    .HasMaxLength(60);

                entity.Property(e => e.TurnoverAuthorizedDate)
                    .HasColumnName("turnover_authorized_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TurnoverTo)
                    .HasColumnName("turnover_to")
                    .HasMaxLength(32);

                entity.Property(e => e.WorkDoneByLandowner)
                    .HasColumnName("work_done_by_landowner")
                    .HasMaxLength(255);

                entity.HasOne(d => d.DmEventT)
                    .WithMany(p => p.DmCrCleanupT)
                    .HasForeignKey(d => new { d.WellId, d.EventId })
                    .HasConstraintName("DM_CR_CLEANUP_PARENT");
            });

            modelBuilder.Entity<DmCrMudAdditiveT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.CleanupId, e.AdditiveId })
                    .HasName("XPKDM_CR_MUD_ADDITIVE_T");

                entity.ToTable("DM_CR_MUD_ADDITIVE_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CleanupId)
                    .HasColumnName("cleanup_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AdditiveId)
                    .HasColumnName("additive_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AmountUnits)
                    .HasColumnName("amount_units")
                    .HasMaxLength(16);

                entity.Property(e => e.AmountUsed).HasColumnName("amount_used");

                entity.Property(e => e.MudProduct)
                    .HasColumnName("mud_product")
                    .HasMaxLength(64);

                entity.Property(e => e.OriginEventId)
                    .HasColumnName("origin_event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OriginWellId)
                    .HasColumnName("origin_well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.HasOne(d => d.DmCrCleanupT)
                    .WithMany(p => p.DmCrMudAdditiveT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.CleanupId })
                    .HasConstraintName("DM_CR_MA_PARENT");
            });

            modelBuilder.Entity<DmDailyDitchMagnetT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.MagnetId })
                    .HasName("XPKDM_DAILY_DITCH_MAGNET_T");

                entity.ToTable("DM_DAILY_DITCH_MAGNET_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MagnetId)
                    .HasColumnName("magnet_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(255);

                entity.Property(e => e.DateTime)
                    .HasColumnName("date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Md).HasColumnName("md");

                entity.Property(e => e.PipeRevs).HasColumnName("pipe_revs");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.TimesCollected).HasColumnName("times_collected");

                entity.Property(e => e.TotalPipeRevs).HasColumnName("total_pipe_revs");

                entity.Property(e => e.TotalWeightRecovered).HasColumnName("total_weight_recovered");

                entity.Property(e => e.WeightRecovered).HasColumnName("weight_recovered");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmDailyDitchMagnetT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("DM_DAILY_DITCH_MAGNET_PARENT");
            });

            modelBuilder.Entity<DmDailyNotificationT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.DailyNotificationId })
                    .HasName("XPKDM_DAILY_NOTIFICATION_T");

                entity.ToTable("DM_DAILY_NOTIFICATION_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyNotificationId)
                    .HasColumnName("daily_notification_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Agency)
                    .HasColumnName("agency")
                    .HasMaxLength(60);

                entity.Property(e => e.AgencyContact)
                    .HasColumnName("agency_contact")
                    .HasMaxLength(60);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(1000);

                entity.Property(e => e.Engineer)
                    .HasColumnName("engineer")
                    .HasMaxLength(60);

                entity.Property(e => e.NotificationDate)
                    .HasColumnName("notification_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NotificationType)
                    .HasColumnName("notification_type")
                    .HasMaxLength(32);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmDailyNotificationT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("DM_DAILY_NOTIFICATION_PARENT");
            });

            modelBuilder.Entity<DmDailyT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId })
                    .HasName("XPKDM_DAILY");

                entity.ToTable("DM_DAILY_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActivityGroupFilter)
                    .HasColumnName("activity_group_filter")
                    .HasMaxLength(20);

                entity.Property(e => e.CommentForecast24)
                    .HasColumnName("comment_forecast_24")
                    .HasMaxLength(2000);

                entity.Property(e => e.CommentGeneral)
                    .HasColumnName("comment_general")
                    .HasMaxLength(2000);

                entity.Property(e => e.CommentOperational)
                    .HasColumnName("comment_operational")
                    .HasMaxLength(2000);

                entity.Property(e => e.CommentSummary)
                    .HasColumnName("comment_summary")
                    .HasMaxLength(4000);

                entity.Property(e => e.CommentWeather)
                    .HasColumnName("comment_weather")
                    .HasMaxLength(255);

                entity.Property(e => e.ContingencyPercent).HasColumnName("contingency_percent");

                entity.Property(e => e.CostApprovedBy)
                    .HasColumnName("cost_approved_by")
                    .HasMaxLength(60);

                entity.Property(e => e.CrPercentComplete).HasColumnName("cr_percent_complete");

                entity.Property(e => e.CrSuperPhone)
                    .HasColumnName("cr_super_phone")
                    .HasMaxLength(50);

                entity.Property(e => e.DailyCost).HasColumnName("daily_cost");

                entity.Property(e => e.DailyCostCalc).HasColumnName("daily_cost_calc");

                entity.Property(e => e.DailyMudCost).HasColumnName("daily_mud_cost");

                entity.Property(e => e.DailyNote)
                    .HasColumnName("daily_note")
                    .HasColumnType("ntext");

                entity.Property(e => e.DailyTroubleCost).HasColumnName("daily_trouble_cost");

                entity.Property(e => e.DateLastWirelineWork)
                    .HasColumnName("date_last_wireline_work")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateReport)
                    .HasColumnName("date_report")
                    .HasColumnType("datetime");

                entity.Property(e => e.DaysAhead).HasColumnName("days_ahead");

                entity.Property(e => e.DaysFromSpud).HasColumnName("days_from_spud");

                entity.Property(e => e.DaysOnLocation).HasColumnName("days_on_location");

                entity.Property(e => e.DaysOnTurnkey).HasColumnName("days_on_turnkey");

                entity.Property(e => e.DirectionalCompany)
                    .HasColumnName("directional_company")
                    .HasMaxLength(60);

                entity.Property(e => e.DrillingCompletionInd)
                    .HasColumnName("drilling_completion_ind")
                    .HasMaxLength(1);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.FillDate)
                    .HasColumnName("fill_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FillDepth).HasColumnName("fill_depth");

                entity.Property(e => e.FinalFlowPressure).HasColumnName("final_flow_pressure");

                entity.Property(e => e.FinalFlowRate).HasColumnName("final_flow_rate");

                entity.Property(e => e.FormationGradient).HasColumnName("formation_gradient");

                entity.Property(e => e.FormationName)
                    .HasColumnName("formation_name")
                    .HasMaxLength(50);

                entity.Property(e => e.FormationTop).HasColumnName("formation_top");

                entity.Property(e => e.GasProducedTo)
                    .HasColumnName("gas_produced_to")
                    .HasMaxLength(50);

                entity.Property(e => e.HoleCondition)
                    .HasColumnName("hole_condition")
                    .HasMaxLength(50);

                entity.Property(e => e.InitialFlowPressure).HasColumnName("initial_flow_pressure");

                entity.Property(e => e.InitialFlowRate).HasColumnName("initial_flow_rate");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("is_approved")
                    .HasMaxLength(1);

                entity.Property(e => e.IsConventionalWell)
                    .HasColumnName("is_conventional_well")
                    .HasMaxLength(1);

                entity.Property(e => e.IsCostApproved)
                    .HasColumnName("is_cost_approved")
                    .HasMaxLength(1);

                entity.Property(e => e.IsDrillCapable)
                    .HasColumnName("is_drill_capable")
                    .HasMaxLength(1);

                entity.Property(e => e.IsFinalReport)
                    .HasColumnName("is_final_report")
                    .HasMaxLength(1);

                entity.Property(e => e.LagStrokes).HasColumnName("lag_strokes");

                entity.Property(e => e.LagTime).HasColumnName("lag_time");

                entity.Property(e => e.LinerSize).HasColumnName("liner_size");

                entity.Property(e => e.LinerTop).HasColumnName("liner_top");

                entity.Property(e => e.LithologyCurrent)
                    .HasColumnName("lithology_current")
                    .HasMaxLength(50);

                entity.Property(e => e.LithologyDescription)
                    .HasColumnName("lithology_description")
                    .HasMaxLength(255);

                entity.Property(e => e.MagneticDeclination).HasColumnName("magnetic_declination");

                entity.Property(e => e.MdCurrent).HasColumnName("md_current");

                entity.Property(e => e.MdFill).HasColumnName("md_fill");

                entity.Property(e => e.MudCompany)
                    .HasColumnName("mud_company")
                    .HasMaxLength(60);

                entity.Property(e => e.MudLossMdBase).HasColumnName("mud_loss_md_base");

                entity.Property(e => e.MudLossMdTop).HasColumnName("mud_loss_md_top");

                entity.Property(e => e.MwdCompany)
                    .HasColumnName("mwd_company")
                    .HasMaxLength(60);

                entity.Property(e => e.OpenHoleFlowPressure).HasColumnName("open_hole_flow_pressure");

                entity.Property(e => e.OpenHoleFlowRate).HasColumnName("open_hole_flow_rate");

                entity.Property(e => e.OrificeDiameter).HasColumnName("orifice_diameter");

                entity.Property(e => e.PackerDepth).HasColumnName("packer_depth");

                entity.Property(e => e.PackerType)
                    .HasColumnName("packer_type")
                    .HasMaxLength(32);

                entity.Property(e => e.PercentComplete).HasColumnName("percent_complete");

                entity.Property(e => e.PlugbackMd).HasColumnName("plugback_md");

                entity.Property(e => e.PlugbackTvd).HasColumnName("plugback_tvd");

                entity.Property(e => e.PressureAmw).HasColumnName("pressure_amw");

                entity.Property(e => e.PressureCasing).HasColumnName("pressure_casing");

                entity.Property(e => e.PressureMasic).HasColumnName("pressure_masic");

                entity.Property(e => e.PressureTubing).HasColumnName("pressure_tubing");

                entity.Property(e => e.Progress).HasColumnName("progress");

                entity.Property(e => e.ReportJournalId)
                    .HasColumnName("report_journal_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReportNo)
                    .HasColumnName("report_no")
                    .HasMaxLength(4);

                entity.Property(e => e.Reviewer)
                    .HasColumnName("reviewer")
                    .HasMaxLength(60);

                entity.Property(e => e.RigFuelConsumption).HasColumnName("rig_fuel_consumption");

                entity.Property(e => e.RopAvgDay).HasColumnName("rop_avg_day");

                entity.Property(e => e.RopCurrent).HasColumnName("rop_current");

                entity.Property(e => e.RotatingElapsedTime).HasColumnName("rotating_elapsed_time");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(2000);

                entity.Property(e => e.SuperPhone)
                    .HasColumnName("super_phone")
                    .HasMaxLength(50);

                entity.Property(e => e.SupervisorName0)
                    .HasColumnName("supervisor_name_0")
                    .HasMaxLength(60);

                entity.Property(e => e.SupervisorName1)
                    .HasColumnName("supervisor_name_1")
                    .HasMaxLength(60);

                entity.Property(e => e.SupervisorName2)
                    .HasColumnName("supervisor_name_2")
                    .HasMaxLength(60);

                entity.Property(e => e.SupervisorName3)
                    .HasColumnName("supervisor_name_3")
                    .HasMaxLength(60);

                entity.Property(e => e.SupervisorName4)
                    .HasColumnName("supervisor_name_4")
                    .HasMaxLength(60);

                entity.Property(e => e.SupervisorName5)
                    .HasColumnName("supervisor_name_5")
                    .HasMaxLength(60);

                entity.Property(e => e.SupervisorName6)
                    .HasColumnName("supervisor_name_6")
                    .HasMaxLength(60);

                entity.Property(e => e.SupervisorName7)
                    .HasColumnName("supervisor_name_7")
                    .HasMaxLength(60);

                entity.Property(e => e.SupervisorName8)
                    .HasColumnName("supervisor_name_8")
                    .HasMaxLength(60);

                entity.Property(e => e.SupervisorName9)
                    .HasColumnName("supervisor_name_9")
                    .HasMaxLength(60);

                entity.Property(e => e.TreeCondition)
                    .HasColumnName("tree_condition")
                    .HasMaxLength(1000);

                entity.Property(e => e.TubingDepth).HasColumnName("tubing_depth");

                entity.Property(e => e.TubingSize).HasColumnName("tubing_size");

                entity.Property(e => e.TvdCurrent).HasColumnName("tvd_current");

                entity.Property(e => e.VelAnnularCritical).HasColumnName("vel_annular_critical");

                entity.Property(e => e.VelAnnularDc1st).HasColumnName("vel_annular_dc_1st");

                entity.Property(e => e.VelAnnularDc2nd).HasColumnName("vel_annular_dc_2nd");

                entity.Property(e => e.VelAnnularDp).HasColumnName("vel_annular_dp");

                entity.Property(e => e.VelAnnularDpCsg).HasColumnName("vel_annular_dp_csg");

                entity.Property(e => e.VelCuttingsSlip).HasColumnName("vel_cuttings_slip");

                entity.Property(e => e.VelRiser).HasColumnName("vel_riser");

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellheadRadiation).HasColumnName("wellhead_radiation");

                entity.Property(e => e.WirelineWorkUnitSize).HasColumnName("wireline_work_unit_size");

                entity.Property(e => e.WuCtWlineDiameter).HasColumnName("wu_ct_wline_diameter");

                entity.HasOne(d => d.DmEventT)
                    .WithMany(p => p.DmDailyT)
                    .HasForeignKey(d => new { d.WellId, d.EventId })
                    .HasConstraintName("R_175");
            });

            modelBuilder.Entity<DmEnvironmentalT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.EnvironmentalId })
                    .HasName("XPKDM_ENVIRONMENTAL");

                entity.ToTable("DM_ENVIRONMENTAL_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EnvironmentalId)
                    .HasColumnName("environmental_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoatCleanedDate)
                    .HasColumnName("boat_cleaned_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChokeLineVolume).HasColumnName("choke_line_volume");

                entity.Property(e => e.DomesticWasteFloatingSolids)
                    .HasColumnName("domestic_waste_floating_solids")
                    .HasMaxLength(1);

                entity.Property(e => e.KillLineVolume).HasColumnName("kill_line_volume");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("ntext");

                entity.Property(e => e.RigCleanedDate)
                    .HasColumnName("rig_cleaned_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SewageFloatingSolids)
                    .HasColumnName("sewage_floating_solids")
                    .HasMaxLength(1);

                entity.Property(e => e.TfmCompany)
                    .HasColumnName("tfm_company")
                    .HasMaxLength(60);

                entity.Property(e => e.TfmEngineer)
                    .HasColumnName("tfm_engineer")
                    .HasMaxLength(60);

                entity.Property(e => e.TfmLostTime).HasColumnName("tfm_lost_time");

                entity.Property(e => e.VisualSheenObserved)
                    .HasColumnName("visual_sheen_observed")
                    .HasMaxLength(1);

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmEnvironmentalT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_2087");
            });

            modelBuilder.Entity<DmEventT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId })
                    .HasName("XPKDM_EVENT");

                entity.ToTable("DM_EVENT_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualWci)
                    .HasColumnName("actual_wci")
                    .HasMaxLength(8);

                entity.Property(e => e.AmountLastCostEst).HasColumnName("amount_last_cost_est");

                entity.Property(e => e.BudgetType)
                    .HasColumnName("budget_type")
                    .HasMaxLength(16);

                entity.Property(e => e.ContingencyPercent).HasColumnName("contingency_percent");

                entity.Property(e => e.CostAuthorized).HasColumnName("cost_authorized");

                entity.Property(e => e.CostType)
                    .HasColumnName("cost_type")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(3);

                entity.Property(e => e.DateAuthorized)
                    .HasColumnName("date_authorized")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateLastCostEst)
                    .HasColumnName("date_last_cost_est")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOffProd)
                    .HasColumnName("date_off_prod")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOnProd)
                    .HasColumnName("date_on_prod")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOpsEnd)
                    .HasColumnName("date_ops_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOpsStart)
                    .HasColumnName("date_ops_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.EquipType)
                    .HasColumnName("equip_type")
                    .HasMaxLength(50);

                entity.Property(e => e.EstimatedDays).HasColumnName("estimated_days");

                entity.Property(e => e.EventCode)
                    .HasColumnName("event_code")
                    .HasMaxLength(20);

                entity.Property(e => e.EventNo)
                    .HasColumnName("event_no")
                    .HasMaxLength(30);

                entity.Property(e => e.EventObjective1)
                    .HasColumnName("event_objective_1")
                    .HasMaxLength(255);

                entity.Property(e => e.EventObjective2)
                    .HasColumnName("event_objective_2")
                    .HasMaxLength(255);

                entity.Property(e => e.EventObjective3)
                    .HasColumnName("event_objective_3")
                    .HasMaxLength(255);

                entity.Property(e => e.EventOperator)
                    .HasColumnName("event_operator")
                    .HasMaxLength(120);

                entity.Property(e => e.EventReason)
                    .HasColumnName("event_reason")
                    .HasMaxLength(16);

                entity.Property(e => e.EventTeam)
                    .HasColumnName("event_team")
                    .HasMaxLength(20);

                entity.Property(e => e.EventType)
                    .HasColumnName("event_type")
                    .HasMaxLength(40);

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.InitialLoadVolumeOil).HasColumnName("initial_load_volume_oil");

                entity.Property(e => e.InitialLoadVolumeOther).HasColumnName("initial_load_volume_other");

                entity.Property(e => e.InitialLoadVolumeWater).HasColumnName("initial_load_volume_water");

                entity.Property(e => e.IsFinalReport)
                    .HasColumnName("is_final_report")
                    .HasMaxLength(1);

                entity.Property(e => e.IsProjectReadonly)
                    .HasColumnName("is_project_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.JobTypeId)
                    .HasColumnName("job_type_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LostGasVol).HasColumnName("lost_gas_vol");

                entity.Property(e => e.LostOilVol).HasColumnName("lost_oil_vol");

                entity.Property(e => e.OperatedType)
                    .HasColumnName("operated_type")
                    .HasMaxLength(64);

                entity.Property(e => e.OperatedTypeCode)
                    .HasColumnName("operated_type_code")
                    .HasMaxLength(3);

                entity.Property(e => e.PaSuCompletionDays).HasColumnName("pa_su_completion_days");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(10);

                entity.Property(e => e.PlannedWci)
                    .HasColumnName("planned_wci")
                    .HasMaxLength(8);

                entity.Property(e => e.PrimaryServiceProvider)
                    .HasColumnName("primary_service_provider")
                    .HasMaxLength(60);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.ReportingStandard).HasColumnName("reporting_standard");

                entity.Property(e => e.ReportingTime)
                    .HasColumnName("reporting_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RigMoveDistance).HasColumnName("rig_move_distance");

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(20);

                entity.Property(e => e.StatusEnd)
                    .HasColumnName("status_end")
                    .HasMaxLength(50);

                entity.Property(e => e.TvdCurrent).HasColumnName("tvd_current");

                entity.Property(e => e.TvdPlugback).HasColumnName("tvd_plugback");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.WellGeometry)
                    .HasColumnName("well_geometry")
                    .HasMaxLength(32);

                entity.Property(e => e.WellboreInterface)
                    .HasColumnName("wellbore_interface")
                    .HasMaxLength(32);

                entity.Property(e => e.WellheadConnection)
                    .HasColumnName("wellhead_connection")
                    .HasMaxLength(32);

                entity.Property(e => e.Wta1)
                    .HasColumnName("wta1")
                    .HasMaxLength(32);

                entity.Property(e => e.Wta2)
                    .HasColumnName("wta2")
                    .HasMaxLength(32);

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.DmEventT)
                    .HasForeignKey(d => d.WellId)
                    .HasConstraintName("R_170");
            });

            modelBuilder.Entity<DmHydrocloneOpT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.HydrocloneOpId })
                    .HasName("XPKDM_HYDROCLONE_OP");

                entity.ToTable("DM_HYDROCLONE_OP_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HydrocloneOpId)
                    .HasColumnName("hydroclone_op_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateOp)
                    .HasColumnName("date_op")
                    .HasColumnType("datetime");

                entity.Property(e => e.DensityFeed).HasColumnName("density_feed");

                entity.Property(e => e.DensityOverflow).HasColumnName("density_overflow");

                entity.Property(e => e.DensityUnderflow).HasColumnName("density_underflow");

                entity.Property(e => e.DischargeLocation)
                    .HasColumnName("discharge_location")
                    .HasMaxLength(30);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.FeedSource)
                    .HasColumnName("feed_source")
                    .HasMaxLength(30);

                entity.Property(e => e.FlowrateFeed).HasColumnName("flowrate_feed");

                entity.Property(e => e.FlowrateOverflow).HasColumnName("flowrate_overflow");

                entity.Property(e => e.FlowrateUnderflow).HasColumnName("flowrate_underflow");

                entity.Property(e => e.HydrocloneId)
                    .HasColumnName("hydroclone_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InsertType)
                    .HasColumnName("insert_type")
                    .HasMaxLength(50);

                entity.Property(e => e.MdOp).HasColumnName("md_op");

                entity.Property(e => e.PressOp).HasColumnName("press_op");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmHydrocloneOpT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_1995");
            });

            modelBuilder.Entity<DmMudProductT>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.MudProductId, e.WellId })
                    .HasName("XPKDM_MUD_PRODUCT");

                entity.ToTable("DM_MUD_PRODUCT_T");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MudProductId)
                    .HasColumnName("mud_product_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostClass)
                    .HasColumnName("cost_class")
                    .HasMaxLength(16);

                entity.Property(e => e.CostCode)
                    .HasColumnName("cost_code")
                    .HasMaxLength(40);

                entity.Property(e => e.CostSubcode)
                    .HasColumnName("cost_subcode")
                    .HasMaxLength(40);

                entity.Property(e => e.DateFirstUsed)
                    .HasColumnName("date_first_used")
                    .HasColumnType("datetime");

                entity.Property(e => e.Microtox).HasColumnName("microtox");

                entity.Property(e => e.MudFunction)
                    .HasColumnName("mud_function")
                    .HasMaxLength(40);

                entity.Property(e => e.ProductName)
                    .HasColumnName("product_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.UnitMeasure).HasColumnName("unit_measure");

                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");

                entity.Property(e => e.UnitSize)
                    .HasColumnName("unit_size")
                    .HasMaxLength(16);

                entity.Property(e => e.Vendor)
                    .HasColumnName("vendor")
                    .HasMaxLength(60);

                entity.HasOne(d => d.DmEventT)
                    .WithMany(p => p.DmMudProductT)
                    .HasForeignKey(d => new { d.WellId, d.EventId })
                    .HasConstraintName("R_247");
            });

            modelBuilder.Entity<DmMudProductTranT>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.WellId, e.DailyId, e.MudProductTranId })
                    .HasName("XPKDM_MUD_PRODUCT_TRAN");

                entity.ToTable("DM_MUD_PRODUCT_TRAN_T");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MudProductTranId)
                    .HasColumnName("mud_product_tran_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApplicationRate).HasColumnName("application_rate");

                entity.Property(e => e.MudProductId)
                    .HasColumnName("mud_product_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductDailyCost).HasColumnName("product_daily_cost");

                entity.Property(e => e.QuantityAdjusted).HasColumnName("quantity_adjusted");

                entity.Property(e => e.QuantityOrdered).HasColumnName("quantity_ordered");

                entity.Property(e => e.QuantityReceived).HasColumnName("quantity_received");

                entity.Property(e => e.QuantityReturned).HasColumnName("quantity_returned");

                entity.Property(e => e.QuantityUsed).HasColumnName("quantity_used");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmMudProductTranT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_231");
            });

            modelBuilder.Entity<DmMudVolumeT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.MudVolumeId })
                    .HasName("XPKDM_MUD_VOLUME");

                entity.ToTable("DM_MUD_VOLUME_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MudVolumeId)
                    .HasColumnName("mud_volume_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MudFlowrate).HasColumnName("mud_flowrate");

                entity.Property(e => e.MudVol).HasColumnName("mud_vol");

                entity.Property(e => e.MudVolDesc)
                    .HasColumnName("mud_vol_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.MudVolLocation)
                    .HasColumnName("mud_vol_location")
                    .HasMaxLength(10);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmMudVolumeT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_71");
            });

            modelBuilder.Entity<DmOperEquipFailT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.FailureId, e.EventId })
                    .HasName("XPKDM_OPER_EQUIP_FAIL");

                entity.ToTable("DM_OPER_EQUIP_FAIL_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FailureId)
                    .HasColumnName("failure_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cause)
                    .HasColumnName("cause")
                    .HasMaxLength(60);

                entity.Property(e => e.CloseFailureDate)
                    .HasColumnName("close_failure_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(60);

                entity.Property(e => e.ContractorComment)
                    .HasColumnName("contractor_comment")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContractorFindings)
                    .HasColumnName("contractor_findings")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContractorName)
                    .HasColumnName("contractor_name")
                    .HasMaxLength(60);

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateFailureEnd)
                    .HasColumnName("date_failure_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFailureStart)
                    .HasColumnName("date_failure_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.EquipFailType)
                    .HasColumnName("equip_fail_type")
                    .HasMaxLength(8);

                entity.Property(e => e.EquipMetallurgy)
                    .HasColumnName("equip_metallurgy")
                    .HasMaxLength(32);

                entity.Property(e => e.EquipService)
                    .HasColumnName("equip_service")
                    .HasMaxLength(32);

                entity.Property(e => e.EquipmentCost).HasColumnName("equipment_cost");

                entity.Property(e => e.EquipmentFailureCode)
                    .HasColumnName("equipment_failure_code")
                    .HasMaxLength(4);

                entity.Property(e => e.EquipmentGroup)
                    .HasColumnName("equipment_group")
                    .HasMaxLength(32);

                entity.Property(e => e.EquipmentManufacturer)
                    .HasColumnName("equipment_manufacturer")
                    .HasMaxLength(60);

                entity.Property(e => e.EquipmentOwner)
                    .HasColumnName("equipment_owner")
                    .HasMaxLength(60);

                entity.Property(e => e.EquipmentType)
                    .HasColumnName("equipment_type")
                    .HasMaxLength(32);

                entity.Property(e => e.FailureDayCost).HasColumnName("failure_day_cost");

                entity.Property(e => e.FailureDepth).HasColumnName("failure_depth");

                entity.Property(e => e.FailureDescription)
                    .HasColumnName("failure_description")
                    .HasColumnType("ntext");

                entity.Property(e => e.FailureDuration).HasColumnName("failure_duration");

                entity.Property(e => e.FailureLocation)
                    .HasColumnName("failure_location")
                    .HasMaxLength(32);

                entity.Property(e => e.FailureOtherCost).HasColumnName("failure_other_cost");

                entity.Property(e => e.FailureTitle)
                    .HasColumnName("failure_title")
                    .HasColumnType("ntext");

                entity.Property(e => e.FailureTotalCost).HasColumnName("failure_total_cost");

                entity.Property(e => e.FailureType)
                    .HasColumnName("failure_type")
                    .HasMaxLength(32);

                entity.Property(e => e.FirstActivityDailyId)
                    .HasColumnName("first_activity_daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstActivityId)
                    .HasColumnName("first_activity_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GlobalVendor)
                    .HasColumnName("global_vendor")
                    .HasMaxLength(60);

                entity.Property(e => e.HoursBeforeFail).HasColumnName("hours_before_fail");

                entity.Property(e => e.InspectionType)
                    .HasColumnName("inspection_type")
                    .HasMaxLength(32);

                entity.Property(e => e.IsFailureClosed)
                    .HasColumnName("is_failure_closed")
                    .HasMaxLength(1);

                entity.Property(e => e.IsPrototypeEquip)
                    .HasColumnName("is_prototype_equip")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.LastActivityDailyId)
                    .HasColumnName("last_activity_daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastActivityId)
                    .HasColumnName("last_activity_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastInspectionDate)
                    .HasColumnName("last_inspection_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LessonId)
                    .HasColumnName("lesson_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(32);

                entity.Property(e => e.NptCauseCode)
                    .HasColumnName("npt_cause_code")
                    .HasMaxLength(32);

                entity.Property(e => e.NptCoach)
                    .HasColumnName("npt_coach")
                    .HasMaxLength(60);

                entity.Property(e => e.NptContractorCost).HasColumnName("npt_contractor_cost");

                entity.Property(e => e.NptDescCode)
                    .HasColumnName("npt_desc_code")
                    .HasMaxLength(32);

                entity.Property(e => e.NptDurationType)
                    .HasColumnName("npt_duration_type")
                    .HasMaxLength(32);

                entity.Property(e => e.NptEventAssessment)
                    .HasColumnName("npt_event_assessment")
                    .HasMaxLength(32);

                entity.Property(e => e.NptLearnings)
                    .HasColumnName("npt_learnings")
                    .HasColumnType("ntext");

                entity.Property(e => e.NptLevel).HasColumnName("npt_level");

                entity.Property(e => e.NptNestedTime).HasColumnName("npt_nested_time");

                entity.Property(e => e.NptNetTime).HasColumnName("npt_net_time");

                entity.Property(e => e.NptNonConfNumber)
                    .HasColumnName("npt_non_conf_number")
                    .HasMaxLength(80);

                entity.Property(e => e.NptOperationType)
                    .HasColumnName("npt_operation_type")
                    .HasMaxLength(32);

                entity.Property(e => e.NptPotentialProbability).HasColumnName("npt_potential_probability");

                entity.Property(e => e.NptPreventActions)
                    .HasColumnName("npt_prevent_actions")
                    .HasColumnType("ntext");

                entity.Property(e => e.NptProductiveTimeAdjustment).HasColumnName("npt_productive_time_adjustment");

                entity.Property(e => e.NptResponseMatrix)
                    .HasColumnName("npt_response_matrix")
                    .HasMaxLength(2);

                entity.Property(e => e.NptTargetCompletionDate)
                    .HasColumnName("npt_target_completion_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NptTeam)
                    .HasColumnName("npt_team")
                    .HasMaxLength(80);

                entity.Property(e => e.NptTotalCostNet).HasColumnName("npt_total_cost_net");

                entity.Property(e => e.PartNo)
                    .HasColumnName("part_no")
                    .HasMaxLength(25);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.ReportJournalId)
                    .HasColumnName("report_journal_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReviewerName)
                    .HasColumnName("reviewer_name")
                    .HasMaxLength(60);

                entity.Property(e => e.RootCauseSummary)
                    .HasColumnName("root_cause_summary")
                    .HasMaxLength(2000);

                entity.Property(e => e.RootCauseType)
                    .HasColumnName("root_cause_type")
                    .HasMaxLength(32);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("serial_no")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(16);

                entity.Property(e => e.StatusDate)
                    .HasColumnName("status_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemAge).HasColumnName("system_age");

                entity.Property(e => e.SystemModel)
                    .HasColumnName("system_model")
                    .HasMaxLength(30);

                entity.Property(e => e.SystemSize)
                    .HasColumnName("system_size")
                    .HasMaxLength(50);

                entity.Property(e => e.SystemVendor)
                    .HasColumnName("system_vendor")
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.WellboreFormationId)
                    .HasColumnName("wellbore_formation_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.DmEventT)
                    .WithMany(p => p.DmOperEquipFailT)
                    .HasForeignKey(d => new { d.WellId, d.EventId })
                    .HasConstraintName("R_2844");
            });

            modelBuilder.Entity<DmPersonnelDailyT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.PersonnelDetailId })
                    .HasName("XPKDM_PERSONNEL_DAILY");

                entity.ToTable("DM_PERSONNEL_DAILY_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PersonnelDetailId)
                    .HasColumnName("personnel_detail_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrComments)
                    .HasColumnName("cr_comments")
                    .HasMaxLength(100);

                entity.Property(e => e.CrContactEmail)
                    .HasColumnName("cr_contact_email")
                    .HasMaxLength(32);

                entity.Property(e => e.CrContactName)
                    .HasColumnName("cr_contact_name")
                    .HasMaxLength(60);

                entity.Property(e => e.CrContactPhone)
                    .HasColumnName("cr_contact_phone")
                    .HasMaxLength(32);

                entity.Property(e => e.CrContractor)
                    .HasColumnName("cr_contractor")
                    .HasMaxLength(60);

                entity.Property(e => e.CrDate)
                    .HasColumnName("cr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrOperation)
                    .HasColumnName("cr_operation")
                    .HasMaxLength(32);

                entity.Property(e => e.CrRating)
                    .HasColumnName("cr_rating")
                    .HasMaxLength(32);

                entity.Property(e => e.HoursOvertime).HasColumnName("hours_overtime");

                entity.Property(e => e.HoursRegular).HasColumnName("hours_regular");

                entity.Property(e => e.HoursTraining).HasColumnName("hours_training");

                entity.Property(e => e.HoursTrainingOvertime).HasColumnName("hours_training_overtime");

                entity.Property(e => e.IsCarryover)
                    .HasColumnName("is_carryover")
                    .HasMaxLength(1);

                entity.Property(e => e.IsInjured)
                    .HasColumnName("is_injured")
                    .HasMaxLength(1);

                entity.Property(e => e.IsMeal1Required)
                    .HasColumnName("is_meal1_required")
                    .HasMaxLength(1);

                entity.Property(e => e.IsMeal2Required)
                    .HasColumnName("is_meal2_required")
                    .HasMaxLength(1);

                entity.Property(e => e.IsMeal3Required)
                    .HasColumnName("is_meal3_required")
                    .HasMaxLength(1);

                entity.Property(e => e.IsMeal4Required)
                    .HasColumnName("is_meal4_required")
                    .HasMaxLength(1);

                entity.Property(e => e.PersonnelId)
                    .HasColumnName("personnel_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.Service)
                    .HasColumnName("service")
                    .HasMaxLength(64);

                entity.Property(e => e.TotalHours).HasColumnName("total_hours");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmPersonnelDailyT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_2134");
            });

            modelBuilder.Entity<DmPersonnelT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.PersonnelId })
                    .HasName("XPKDM_PERSONNEL");

                entity.ToTable("DM_PERSONNEL_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PersonnelId)
                    .HasColumnName("personnel_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Catering)
                    .HasColumnName("catering")
                    .HasMaxLength(16);

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(60);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Crew)
                    .HasColumnName("crew")
                    .HasMaxLength(16);

                entity.Property(e => e.DateArrived)
                    .HasColumnName("date_arrived")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDeparted)
                    .HasColumnName("date_departed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(32);

                entity.Property(e => e.Duties)
                    .HasColumnName("duties")
                    .HasMaxLength(80);

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(60);

                entity.Property(e => e.EmployeeNo)
                    .HasColumnName("employee_no")
                    .HasMaxLength(32);

                entity.Property(e => e.EmployeeWeight).HasColumnName("employee_weight");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("job_title")
                    .HasMaxLength(32);

                entity.Property(e => e.LifeboatNo)
                    .HasColumnName("lifeboat_no")
                    .HasMaxLength(8);

                entity.Property(e => e.LuggageWeight).HasColumnName("luggage_weight");

                entity.Property(e => e.PayRate).HasColumnName("pay_rate");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RigOperationId)
                    .HasColumnName("rig_operation_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RoomNo)
                    .HasColumnName("room_no")
                    .HasMaxLength(16);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.Service)
                    .HasColumnName("service")
                    .HasMaxLength(32);

                entity.Property(e => e.SocialSecurityNo)
                    .HasColumnName("social_security_no")
                    .HasMaxLength(32);

                entity.Property(e => e.SquadMember)
                    .HasColumnName("squad_member")
                    .HasMaxLength(60);

                entity.HasOne(d => d.DmEventT)
                    .WithMany(p => p.DmPersonnelT)
                    .HasForeignKey(d => new { d.WellId, d.EventId })
                    .HasConstraintName("R_2133");
            });

            modelBuilder.Entity<DmPitOpT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.PitOpId })
                    .HasName("XPKDM_PIT_OP");

                entity.ToTable("DM_PIT_OP_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PitOpId)
                    .HasColumnName("pit_op_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateOp)
                    .HasColumnName("date_op")
                    .HasColumnType("datetime");

                entity.Property(e => e.FluidVol).HasColumnName("fluid_vol");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasMaxLength(1);

                entity.Property(e => e.MudDensity).HasColumnName("mud_density");

                entity.Property(e => e.PitContents)
                    .HasColumnName("pit_contents")
                    .HasMaxLength(50);

                entity.Property(e => e.PitId)
                    .HasColumnName("pit_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.Viscosity).HasColumnName("viscosity");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmPitOpT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_1994");
            });

            modelBuilder.Entity<DmPumpOpT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.PumpOpId })
                    .HasName("XPKDM_PUMP_OP");

                entity.ToTable("DM_PUMP_OP_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PumpOpId)
                    .HasColumnName("pump_op_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateOp)
                    .HasColumnName("date_op")
                    .HasColumnType("datetime");

                entity.Property(e => e.Efficiency).HasColumnName("efficiency");

                entity.Property(e => e.Flowrate).HasColumnName("flowrate");

                entity.Property(e => e.LinerId).HasColumnName("liner_id");

                entity.Property(e => e.MdOp).HasColumnName("md_op");

                entity.Property(e => e.OpCode)
                    .HasColumnName("op_code")
                    .HasMaxLength(2);

                entity.Property(e => e.Press).HasColumnName("press");

                entity.Property(e => e.PumpId)
                    .HasColumnName("pump_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.SlowPumpEfficiency).HasColumnName("slow_pump_efficiency");

                entity.Property(e => e.Spm).HasColumnName("spm");

                entity.Property(e => e.SuperchargerRunHours).HasColumnName("supercharger_run_hours");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmPumpOpT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_1997");
            });

            modelBuilder.Entity<DmReportJournal>(entity =>
            {
                entity.HasKey(e => e.ReportJournalId)
                    .HasName("XPKDM_REPORT_JOURNAL");

                entity.ToTable("DM_REPORT_JOURNAL");

                entity.Property(e => e.ReportJournalId)
                    .HasColumnName("report_journal_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActivityInstanceId)
                    .HasColumnName("activity_instance_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActivitySequenceNo).HasColumnName("activity_sequence_no");

                entity.Property(e => e.ActivityTypeId)
                    .HasColumnName("activity_type_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AfeId)
                    .HasColumnName("afe_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompletionId)
                    .HasColumnName("completion_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateLocked)
                    .HasColumnName("date_locked")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePrinted)
                    .HasColumnName("date_printed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateReport)
                    .HasColumnName("date_report")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTransmitted)
                    .HasColumnName("date_transmitted")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.EntityType)
                    .HasColumnName("entity_type")
                    .HasMaxLength(32);

                entity.Property(e => e.EquipmentTypeUsed)
                    .HasColumnName("equipment_type_used")
                    .HasMaxLength(2);

                entity.Property(e => e.EventCode)
                    .HasColumnName("event_code")
                    .HasMaxLength(20);

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsAutoprintFlag)
                    .HasColumnName("is_autoprint_flag")
                    .HasMaxLength(1);

                entity.Property(e => e.IsMainframeFlag)
                    .HasColumnName("is_mainframe_flag")
                    .HasMaxLength(1);

                entity.Property(e => e.IsModifiedFlag)
                    .HasColumnName("is_modified_flag")
                    .HasMaxLength(1);

                entity.Property(e => e.IsProjectReadonly)
                    .HasColumnName("is_project_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReportComplete)
                    .HasColumnName("is_report_complete")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSendFlag)
                    .HasColumnName("is_send_flag")
                    .HasMaxLength(1);

                entity.Property(e => e.IsValidated)
                    .HasColumnName("is_validated")
                    .HasMaxLength(1);

                entity.Property(e => e.LockUserId)
                    .HasColumnName("lock_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(30);

                entity.Property(e => e.PadId)
                    .HasColumnName("pad_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PadOpId)
                    .HasColumnName("pad_op_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentReportJournalId)
                    .HasColumnName("parent_report_journal_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReportAlias)
                    .HasColumnName("report_alias")
                    .HasMaxLength(25);

                entity.Property(e => e.ReportNo)
                    .HasColumnName("report_no")
                    .HasMaxLength(4);

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SectionStatus)
                    .HasColumnName("section_status")
                    .HasMaxLength(800);

                entity.Property(e => e.StatusFilename)
                    .HasColumnName("status_filename")
                    .HasMaxLength(16);

                entity.Property(e => e.TransferStatus)
                    .HasColumnName("transfer_status")
                    .HasMaxLength(16);

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DmRigDecklogT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.RigDecklogId })
                    .HasName("XPKDM_RIG_DECKLOG");

                entity.ToTable("DM_RIG_DECKLOG_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RigDecklogId)
                    .HasColumnName("rig_decklog_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvgDraft).HasColumnName("avg_draft");

                entity.Property(e => e.BowDraft).HasColumnName("bow_draft");

                entity.Property(e => e.BowLegReaction).HasColumnName("bow_leg_reaction");

                entity.Property(e => e.DateOp)
                    .HasColumnName("date_op")
                    .HasColumnType("datetime");

                entity.Property(e => e.HeelAngle).HasColumnName("heel_angle");

                entity.Property(e => e.HeelPortOrStar)
                    .HasColumnName("heel_port_or_star")
                    .HasMaxLength(1);

                entity.Property(e => e.InspectionComments)
                    .HasColumnName("inspection_comments")
                    .HasColumnType("ntext");

                entity.Property(e => e.LegLoad1).HasColumnName("leg_load_1");

                entity.Property(e => e.LegLoad2).HasColumnName("leg_load_2");

                entity.Property(e => e.LegLoad3).HasColumnName("leg_load_3");

                entity.Property(e => e.LegLoad4).HasColumnName("leg_load_4");

                entity.Property(e => e.LegPenetration1).HasColumnName("leg_penetration_1");

                entity.Property(e => e.LegPenetration2).HasColumnName("leg_penetration_2");

                entity.Property(e => e.LegPenetration3).HasColumnName("leg_penetration_3");

                entity.Property(e => e.LegPenetration4).HasColumnName("leg_penetration_4");

                entity.Property(e => e.MaxLoad).HasColumnName("max_load");

                entity.Property(e => e.OpType)
                    .HasColumnName("op_type")
                    .HasMaxLength(30);

                entity.Property(e => e.OtherLegReact).HasColumnName("other_leg_react");

                entity.Property(e => e.PortLegReact).HasColumnName("port_leg_react");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.RigHeading).HasColumnName("rig_heading");

                entity.Property(e => e.RigOffset).HasColumnName("rig_offset");

                entity.Property(e => e.StabilityMargin).HasColumnName("stability_margin");

                entity.Property(e => e.StarLegReact).HasColumnName("star_leg_react");

                entity.Property(e => e.SternDraft).HasColumnName("stern_draft");

                entity.Property(e => e.TotalDeckLoad).HasColumnName("total_deck_load");

                entity.Property(e => e.TotalLegLoad).HasColumnName("total_leg_load");

                entity.Property(e => e.TrimAngle).HasColumnName("trim_angle");

                entity.Property(e => e.TrimSternOrBow)
                    .HasColumnName("trim_stern_or_bow")
                    .HasMaxLength(1);

                entity.Property(e => e.VariableDeckLoad).HasColumnName("variable_deck_load");

                entity.Property(e => e.VariableLegLoad).HasColumnName("variable_leg_load");

                entity.Property(e => e.VesselDisplacement).HasColumnName("vessel_displacement");

                entity.Property(e => e.VesselHeave).HasColumnName("vessel_heave");

                entity.Property(e => e.VesselPitch).HasColumnName("vessel_pitch");

                entity.Property(e => e.VesselRoll).HasColumnName("vessel_roll");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmRigDecklogT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_180");
            });

            modelBuilder.Entity<DmRigOperation>(entity =>
            {
                entity.HasKey(e => new { e.RigId, e.RigOperationId })
                    .HasName("XPKDM_RIG_OPERATION");

                entity.ToTable("DM_RIG_OPERATION");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RigOperationId)
                    .HasColumnName("rig_operation_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AirGap).HasColumnName("air_gap");

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContractMaxDays).HasColumnName("contract_max_days");

                entity.Property(e => e.ContractNo)
                    .HasColumnName("contract_no")
                    .HasMaxLength(30);

                entity.Property(e => e.ContractRate).HasColumnName("contract_rate");

                entity.Property(e => e.ContractReference)
                    .HasColumnName("contract_reference")
                    .HasMaxLength(60);

                entity.Property(e => e.ContractType)
                    .HasColumnName("contract_type")
                    .HasMaxLength(30);

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateContract)
                    .HasColumnName("date_contract")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEffective)
                    .HasColumnName("date_effective")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRigDown)
                    .HasColumnName("date_rig_down")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRigPickup)
                    .HasColumnName("date_rig_pickup")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRigReleased)
                    .HasColumnName("date_rig_released")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRigUp)
                    .HasColumnName("date_rig_up")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTimeChargeStart)
                    .HasColumnName("date_time_charge_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTimeOffLocation)
                    .HasColumnName("date_time_off_location")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTimeOnLocation)
                    .HasColumnName("date_time_on_location")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTimeOpsFinished)
                    .HasColumnName("date_time_ops_finished")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTimeOpsStart)
                    .HasColumnName("date_time_ops_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.DrillDays).HasColumnName("drill_days");

                entity.Property(e => e.FreqBopTest).HasColumnName("freq_bop_test");

                entity.Property(e => e.IsDrillCapable)
                    .HasColumnName("is_drill_capable")
                    .HasMaxLength(1);

                entity.Property(e => e.IsHelipadInspected)
                    .HasColumnName("is_helipad_inspected")
                    .HasMaxLength(1);

                entity.Property(e => e.IsHelipadReady)
                    .HasColumnName("is_helipad_ready")
                    .HasMaxLength(1);

                entity.Property(e => e.IsReadonly)
                    .HasColumnName("is_readonly")
                    .HasMaxLength(1);

                entity.Property(e => e.IsRoadInspected)
                    .HasColumnName("is_road_inspected")
                    .HasMaxLength(1);

                entity.Property(e => e.IsRoadReady)
                    .HasColumnName("is_road_ready")
                    .HasMaxLength(1);

                entity.Property(e => e.NextSiteId)
                    .HasColumnName("next_site_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NextWellId)
                    .HasColumnName("next_well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NextWellLocation)
                    .HasColumnName("next_well_location")
                    .HasMaxLength(60);

                entity.Property(e => e.NextWellName)
                    .HasColumnName("next_well_name")
                    .HasMaxLength(60);

                entity.Property(e => e.NumBeds).HasColumnName("num_beds");

                entity.Property(e => e.OperationType)
                    .HasColumnName("operation_type")
                    .HasMaxLength(16);

                entity.Property(e => e.PerformanceRating)
                    .HasColumnName("performance_rating")
                    .HasMaxLength(5);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(2000);

                entity.Property(e => e.RigEmail)
                    .HasColumnName("rig_email")
                    .HasMaxLength(80);

                entity.Property(e => e.RigManager)
                    .HasColumnName("rig_manager")
                    .HasMaxLength(60);

                entity.Property(e => e.RigPhone1)
                    .HasColumnName("rig_phone_1")
                    .HasMaxLength(50);

                entity.Property(e => e.RigPhone2)
                    .HasColumnName("rig_phone_2")
                    .HasMaxLength(50);

                entity.Property(e => e.RiserLengthUsed).HasColumnName("riser_length_used");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Rig)
                    .WithMany(p => p.DmRigOperation)
                    .HasForeignKey(d => d.RigId)
                    .HasConstraintName("R_63");
            });

            modelBuilder.Entity<DmRiser>(entity =>
            {
                entity.HasKey(e => new { e.RigId, e.RiserId })
                    .HasName("XPKDM_RISER");

                entity.ToTable("DM_RISER");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RiserId)
                    .HasColumnName("riser_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConnectionType)
                    .HasColumnName("connection_type")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateAppId)
                    .HasColumnName("create_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("create_user_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DateInstalled)
                    .HasColumnName("date_installed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRemoved)
                    .HasColumnName("date_removed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(60);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LengthAvailable).HasColumnName("length_available");

                entity.Property(e => e.Make)
                    .HasColumnName("make")
                    .HasMaxLength(50);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(32);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(30);

                entity.Property(e => e.Od).HasColumnName("od");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(60);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.RiserAngleLimit).HasColumnName("riser_angle_limit");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.UpdateAppId)
                    .HasColumnName("update_app_id")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Rig)
                    .WithMany(p => p.DmRiser)
                    .HasForeignKey(d => d.RigId)
                    .HasConstraintName("R_211");
            });

            modelBuilder.Entity<DmRiserOpT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.RiserOpId })
                    .HasName("XPKDM_RISER_OP");

                entity.ToTable("DM_RISER_OP_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RiserOpId)
                    .HasColumnName("riser_op_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BallJointAngle).HasColumnName("ball_joint_angle");

                entity.Property(e => e.BallJointDirection).HasColumnName("ball_joint_direction");

                entity.Property(e => e.BopAngle).HasColumnName("bop_angle");

                entity.Property(e => e.BopDirection).HasColumnName("bop_direction");

                entity.Property(e => e.DateOp)
                    .HasColumnName("date_op")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuideBaseAngle).HasColumnName("guide_base_angle");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RiserAngle).HasColumnName("riser_angle");

                entity.Property(e => e.RiserDirection).HasColumnName("riser_direction");

                entity.Property(e => e.RiserId)
                    .HasColumnName("riser_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RiserTension).HasColumnName("riser_tension");

                entity.Property(e => e.RiserVol).HasColumnName("riser_vol");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmRiserOpT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_2138");
            });

            modelBuilder.Entity<DmSafetyT>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.WellId, e.DailyId, e.SafetyId })
                    .HasName("XPKDM_SAFETY");

                entity.ToTable("DM_SAFETY_T");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SafetyId)
                    .HasColumnName("safety_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BopFtConnector)
                    .HasColumnName("bop_ft_connector")
                    .HasMaxLength(1);

                entity.Property(e => e.BopFtPods)
                    .HasColumnName("bop_ft_pods")
                    .HasMaxLength(1);

                entity.Property(e => e.BopPressureAnnular).HasColumnName("bop_pressure_annular");

                entity.Property(e => e.BopPressureChokeLine).HasColumnName("bop_pressure_choke_line");

                entity.Property(e => e.BopPressureChokeMan).HasColumnName("bop_pressure_choke_man");

                entity.Property(e => e.BopPressureDiverter).HasColumnName("bop_pressure_diverter");

                entity.Property(e => e.BopPressureKellyHose).HasColumnName("bop_pressure_kelly_hose");

                entity.Property(e => e.BopPressureKillLine).HasColumnName("bop_pressure_kill_line");

                entity.Property(e => e.BopPressureRamsLower).HasColumnName("bop_pressure_rams_lower");

                entity.Property(e => e.BopPressureRamsUpper).HasColumnName("bop_pressure_rams_upper");

                entity.Property(e => e.BopPressureSpMan).HasColumnName("bop_pressure_sp_man");

                entity.Property(e => e.Bunks).HasColumnName("bunks");

                entity.Property(e => e.ConnGasConcAvg).HasColumnName("conn_gas_conc_avg");

                entity.Property(e => e.ConnGasConcMax).HasColumnName("conn_gas_conc_max");

                entity.Property(e => e.DateAnnularTested)
                    .HasColumnName("date_annular_tested")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateBopDrill)
                    .HasColumnName("date_bop_drill")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateBopFunction)
                    .HasColumnName("date_bop_function")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateBopTest)
                    .HasColumnName("date_bop_test")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateComTest)
                    .HasColumnName("date_com_test")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCsgPressTest)
                    .HasColumnName("date_csg_press_test")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCustom1)
                    .HasColumnName("date_custom1")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCustom2)
                    .HasColumnName("date_custom2")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDiverterDrill)
                    .HasColumnName("date_diverter_drill")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEvacuationDrill)
                    .HasColumnName("date_evacuation_drill")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFireDrill)
                    .HasColumnName("date_fire_drill")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateH2sDrill)
                    .HasColumnName("date_h2s_drill")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateNextBopTest)
                    .HasColumnName("date_next_bop_test")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePitDrill)
                    .HasColumnName("date_pit_drill")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRamsTested)
                    .HasColumnName("date_rams_tested")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateReport)
                    .HasColumnName("date_report")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRigInspection)
                    .HasColumnName("date_rig_inspection")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateSafetyInspection)
                    .HasColumnName("date_safety_inspection")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateSafetyMeeting)
                    .HasColumnName("date_safety_meeting")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTripDrill)
                    .HasColumnName("date_trip_drill")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateWeeklyRigCheck)
                    .HasColumnName("date_weekly_rig_check")
                    .HasColumnType("datetime");

                entity.Property(e => e.DaysOnDrillCollar).HasColumnName("days_on_drill_collar");

                entity.Property(e => e.DaysOnDrillPipe).HasColumnName("days_on_drill_pipe");

                entity.Property(e => e.DaysOnEquip1).HasColumnName("days_on_equip_1");

                entity.Property(e => e.DaysOnEquip2).HasColumnName("days_on_equip_2");

                entity.Property(e => e.DaysOnEquip3).HasColumnName("days_on_equip_3");

                entity.Property(e => e.DaysOnGenBha).HasColumnName("days_on_gen_bha");

                entity.Property(e => e.DaysOnHeavyWeight).HasColumnName("days_on_heavy_weight");

                entity.Property(e => e.DaysOnJars).HasColumnName("days_on_jars");

                entity.Property(e => e.DaysOnOtherBha).HasColumnName("days_on_other_bha");

                entity.Property(e => e.DaysOnShockSub).HasColumnName("days_on_shock_sub");

                entity.Property(e => e.DaysOnStab).HasColumnName("days_on_stab");

                entity.Property(e => e.DaysSinceDrill).HasColumnName("days_since_drill");

                entity.Property(e => e.DaysSinceLtiOper).HasColumnName("days_since_lti_oper");

                entity.Property(e => e.DaysSinceLtiTot).HasColumnName("days_since_lti_tot");

                entity.Property(e => e.DescEquip1)
                    .HasColumnName("desc_equip_1")
                    .HasMaxLength(32);

                entity.Property(e => e.DescEquip2)
                    .HasColumnName("desc_equip_2")
                    .HasMaxLength(32);

                entity.Property(e => e.DescEquip3)
                    .HasColumnName("desc_equip_3")
                    .HasMaxLength(32);

                entity.Property(e => e.DrillGasConcAvg).HasColumnName("drill_gas_conc_avg");

                entity.Property(e => e.DrillGasConcMax).HasColumnName("drill_gas_conc_max");

                entity.Property(e => e.DrillType)
                    .HasColumnName("drill_type")
                    .HasMaxLength(16);

                entity.Property(e => e.FlaredGas).HasColumnName("flared_gas");

                entity.Property(e => e.H2sGasConcAvg).HasColumnName("h2s_gas_conc_avg");

                entity.Property(e => e.H2sGasConcMax).HasColumnName("h2s_gas_conc_max");

                entity.Property(e => e.InspectionResult)
                    .HasColumnName("inspection_result")
                    .HasMaxLength(32);

                entity.Property(e => e.IsCableCut)
                    .HasColumnName("is_cable_cut")
                    .HasMaxLength(1);

                entity.Property(e => e.IsCompanyInspected)
                    .HasColumnName("is_company_inspected")
                    .HasMaxLength(1);

                entity.Property(e => e.IsGovernmentInspected)
                    .HasColumnName("is_government_inspected")
                    .HasMaxLength(1);

                entity.Property(e => e.IsJobsiteCheck)
                    .HasColumnName("is_jobsite_check")
                    .HasMaxLength(1);

                entity.Property(e => e.IsNoncompReceived)
                    .HasColumnName("is_noncomp_received")
                    .HasMaxLength(1);

                entity.Property(e => e.IsSheenSpill)
                    .HasColumnName("is_sheen_spill")
                    .HasMaxLength(1);

                entity.Property(e => e.JobSafetyAnalysis).HasColumnName("job_safety_analysis");

                entity.Property(e => e.JobsiteEvaluation).HasColumnName("jobsite_evaluation");

                entity.Property(e => e.LastCasingTestPressure).HasColumnName("last_casing_test_pressure");

                entity.Property(e => e.LostConnIncidentType)
                    .HasColumnName("lost_conn_incident_type")
                    .HasMaxLength(32);

                entity.Property(e => e.MinorInjuryType)
                    .HasColumnName("minor_injury_type")
                    .HasMaxLength(16);

                entity.Property(e => e.NumPtw).HasColumnName("num_ptw");

                entity.Property(e => e.OtherBhaDesc)
                    .HasColumnName("other_bha_desc")
                    .HasMaxLength(32);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(500);

                entity.Property(e => e.Reporter)
                    .HasColumnName("reporter")
                    .HasMaxLength(60);

                entity.Property(e => e.RidCards).HasColumnName("rid_cards");

                entity.Property(e => e.SafetyKeyword)
                    .HasColumnName("safety_keyword")
                    .HasMaxLength(32);

                entity.Property(e => e.SafetyMomentTopic)
                    .HasColumnName("safety_moment_topic")
                    .HasMaxLength(32);

                entity.Property(e => e.SafetyNote)
                    .HasColumnName("safety_note")
                    .HasColumnType("ntext");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.SpareDate1)
                    .HasColumnName("spare_date_1")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpareDate2)
                    .HasColumnName("spare_date_2")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpareDesc1)
                    .HasColumnName("spare_desc_1")
                    .HasMaxLength(32);

                entity.Property(e => e.SpareDesc2)
                    .HasColumnName("spare_desc_2")
                    .HasMaxLength(32);

                entity.Property(e => e.TermNames)
                    .HasColumnName("term_names")
                    .HasMaxLength(60);

                entity.Property(e => e.Terminated).HasColumnName("terminated");

                entity.Property(e => e.TimeOnDrillCollar).HasColumnName("time_on_drill_collar");

                entity.Property(e => e.TimeOnDrillPipe).HasColumnName("time_on_drill_pipe");

                entity.Property(e => e.TimeOnEquip1).HasColumnName("time_on_equip_1");

                entity.Property(e => e.TimeOnEquip2).HasColumnName("time_on_equip_2");

                entity.Property(e => e.TimeOnEquip3).HasColumnName("time_on_equip_3");

                entity.Property(e => e.TimeOnGenBha).HasColumnName("time_on_gen_bha");

                entity.Property(e => e.TimeOnHeavyWeight).HasColumnName("time_on_heavy_weight");

                entity.Property(e => e.TimeOnJars).HasColumnName("time_on_jars");

                entity.Property(e => e.TimeOnOtherBha).HasColumnName("time_on_other_bha");

                entity.Property(e => e.TimeOnShockSub).HasColumnName("time_on_shock_sub");

                entity.Property(e => e.TimeOnStab).HasColumnName("time_on_stab");

                entity.Property(e => e.TonMiles).HasColumnName("ton_miles");

                entity.Property(e => e.TripGasConcAvg).HasColumnName("trip_gas_conc_avg");

                entity.Property(e => e.TripGasConcMax).HasColumnName("trip_gas_conc_max");

                entity.Property(e => e.VentedGas).HasColumnName("vented_gas");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmSafetyT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_44");
            });

            modelBuilder.Entity<DmShakerOpT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.EventId, e.DailyId, e.ShakerOpId })
                    .HasName("XPKDM_SHAKER_OP");

                entity.ToTable("DM_SHAKER_OP_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShakerOpId)
                    .HasColumnName("shaker_op_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateOp)
                    .HasColumnName("date_op")
                    .HasColumnType("datetime");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.MdOp).HasColumnName("md_op");

                entity.Property(e => e.MudCover).HasColumnName("mud_cover");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.ShakerAngle).HasColumnName("shaker_angle");

                entity.Property(e => e.ShakerId)
                    .HasColumnName("shaker_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmShakerOpT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_1998");
            });

            modelBuilder.Entity<DmShakerscreen>(entity =>
            {
                entity.HasKey(e => new { e.RigId, e.ShakerId, e.ShakerscreenId })
                    .HasName("XPKDM_SHAKERSCREEN");

                entity.ToTable("DM_SHAKERSCREEN");

                entity.Property(e => e.RigId)
                    .HasColumnName("rig_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShakerId)
                    .HasColumnName("shaker_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShakerscreenId)
                    .HasColumnName("shakerscreen_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApiSize)
                    .HasColumnName("api_size")
                    .HasMaxLength(30);

                entity.Property(e => e.CutPoint)
                    .HasColumnName("cut_point")
                    .HasMaxLength(5);

                entity.Property(e => e.DateInstalled)
                    .HasColumnName("date_installed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRemoved)
                    .HasColumnName("date_removed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Disposition)
                    .HasColumnName("disposition")
                    .HasMaxLength(100);

                entity.Property(e => e.IsInUse)
                    .HasColumnName("is_in_use")
                    .HasMaxLength(1);

                entity.Property(e => e.Make)
                    .HasColumnName("make")
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(30);

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(60);

                entity.Property(e => e.ScreenNo)
                    .HasColumnName("screen_no")
                    .HasMaxLength(20);

                entity.Property(e => e.SerialNo)
                    .HasColumnName("serial_no")
                    .HasMaxLength(25);

                entity.Property(e => e.SizeMeshX).HasColumnName("size_mesh_x");

                entity.Property(e => e.SizeMeshY).HasColumnName("size_mesh_y");

                entity.Property(e => e.SizeMeshZ).HasColumnName("size_mesh_z");

                entity.Property(e => e.Supplier)
                    .HasColumnName("supplier")
                    .HasMaxLength(60);

                entity.HasOne(d => d.CdRigShaker)
                    .WithMany(p => p.DmShakerscreen)
                    .HasForeignKey(d => new { d.RigId, d.ShakerId })
                    .HasConstraintName("R_2355");
            });

            modelBuilder.Entity<DmSupportVesselDailyT>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.WellId, e.DailyId, e.SupportVesselDailyId })
                    .HasName("XPKDM_SUPPORT_VESSEL_DAILY");

                entity.ToTable("DM_SUPPORT_VESSEL_DAILY_T");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupportVesselDailyId)
                    .HasColumnName("support_vessel_daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ArrivalRemarks)
                    .HasColumnName("arrival_remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.DateArrival)
                    .HasColumnName("date_arrival")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDeparture)
                    .HasColumnName("date_departure")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureRemarks)
                    .HasColumnName("departure_remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.IsCarryover)
                    .HasColumnName("is_carryover")
                    .HasMaxLength(1);

                entity.Property(e => e.NumberOfCraft).HasColumnName("number_of_craft");

                entity.Property(e => e.PassengersInbound).HasColumnName("passengers_inbound");

                entity.Property(e => e.PassengersOutbound).HasColumnName("passengers_outbound");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.SupportVesselId)
                    .HasColumnName("support_vessel_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmSupportVesselDailyT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_236");
            });

            modelBuilder.Entity<DmSupportVesselT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.SupportVesselId })
                    .HasName("XPKDM_SUPPORT_VESSEL");

                entity.ToTable("DM_SUPPORT_VESSEL_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupportVesselId)
                    .HasColumnName("support_vessel_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ArrivalRemarks)
                    .HasColumnName("arrival_remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.DateArrival)
                    .HasColumnName("date_arrival")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDeparture)
                    .HasColumnName("date_departure")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureRemarks)
                    .HasColumnName("departure_remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.VesselIdNo)
                    .HasColumnName("vessel_id_no")
                    .HasMaxLength(20);

                entity.Property(e => e.VesselName)
                    .HasColumnName("vessel_name")
                    .HasMaxLength(50);

                entity.Property(e => e.VesselOwner)
                    .HasColumnName("vessel_owner")
                    .HasMaxLength(60);

                entity.Property(e => e.VesselType)
                    .HasColumnName("vessel_type")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Well)
                    .WithMany(p => p.DmSupportVesselT)
                    .HasForeignKey(d => d.WellId)
                    .HasConstraintName("R_2312");
            });

            modelBuilder.Entity<DmWeatherCheckT>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.WellId, e.DailyId, e.WeatherCheckId })
                    .HasName("XPKDM_WEATHER_CHECK");

                entity.ToTable("DM_WEATHER_CHECK_T");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DailyId)
                    .HasColumnName("daily_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WeatherCheckId)
                    .HasColumnName("weather_check_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CeilingHeight).HasColumnName("ceiling_height");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CloudCoverPercent).HasColumnName("cloud_cover_percent");

                entity.Property(e => e.CurrentMonitorEquipment)
                    .HasColumnName("current_monitor_equipment")
                    .HasMaxLength(32);

                entity.Property(e => e.CurrentTemperature).HasColumnName("current_temperature");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.PrecipitationAmount).HasColumnName("precipitation_amount");

                entity.Property(e => e.PrecipitationType)
                    .HasColumnName("precipitation_type")
                    .HasMaxLength(10);

                entity.Property(e => e.PressureAtmospheric).HasColumnName("pressure_atmospheric");

                entity.Property(e => e.PressureBarometric).HasColumnName("pressure_barometric");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.SeaDirCurrent).HasColumnName("sea_dir_current");

                entity.Property(e => e.SeaSpeedCurrent).HasColumnName("sea_speed_current");

                entity.Property(e => e.SwellDirection).HasColumnName("swell_direction");

                entity.Property(e => e.SwellHeight).HasColumnName("swell_height");

                entity.Property(e => e.SwellPeriod).HasColumnName("swell_period");

                entity.Property(e => e.TempHigh).HasColumnName("temp_high");

                entity.Property(e => e.TempLow).HasColumnName("temp_low");

                entity.Property(e => e.TempSea).HasColumnName("temp_sea");

                entity.Property(e => e.Visibility).HasColumnName("visibility");

                entity.Property(e => e.WaveDir).HasColumnName("wave_dir");

                entity.Property(e => e.WaveHeight).HasColumnName("wave_height");

                entity.Property(e => e.WaveHeightMax).HasColumnName("wave_height_max");

                entity.Property(e => e.WaveHeightMaxDir).HasColumnName("wave_height_max_dir");

                entity.Property(e => e.WavePeriod).HasColumnName("wave_period");

                entity.Property(e => e.WavePeriodMax).HasColumnName("wave_period_max");

                entity.Property(e => e.WeatherAgency)
                    .HasColumnName("weather_agency")
                    .HasMaxLength(60);

                entity.Property(e => e.WindDir).HasColumnName("wind_dir");

                entity.Property(e => e.WindGustDir).HasColumnName("wind_gust_dir");

                entity.Property(e => e.WindGustSpeed).HasColumnName("wind_gust_speed");

                entity.Property(e => e.WindSpeed).HasColumnName("wind_speed");

                entity.HasOne(d => d.DmDailyT)
                    .WithMany(p => p.DmWeatherCheckT)
                    .HasForeignKey(d => new { d.WellId, d.EventId, d.DailyId })
                    .HasConstraintName("R_214");
            });

            modelBuilder.Entity<DmWellboreIntegT>(entity =>
            {
                entity.HasKey(e => new { e.WellId, e.WellboreId, e.HoleSectGroupId, e.WellboreIntegId })
                    .HasName("XPKDM_WELLBORE_INTEG");

                entity.ToTable("DM_WELLBORE_INTEG_T");

                entity.Property(e => e.WellId)
                    .HasColumnName("well_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreId)
                    .HasColumnName("wellbore_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoleSectGroupId)
                    .HasColumnName("hole_sect_group_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WellboreIntegId)
                    .HasColumnName("wellbore_integ_id")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChargeLoss).HasColumnName("charge_loss");

                entity.Property(e => e.DateTest)
                    .HasColumnName("date_test")
                    .HasColumnType("datetime");

                entity.Property(e => e.FluidApiWaterLoss).HasColumnName("fluid_api_water_loss");

                entity.Property(e => e.InjectionPoint)
                    .HasColumnName("injection_point")
                    .HasMaxLength(16);

                entity.Property(e => e.IsAbsorption)
                    .HasColumnName("is_absorption")
                    .HasMaxLength(1);

                entity.Property(e => e.IsFracture)
                    .HasColumnName("is_fracture")
                    .HasMaxLength(1);

                entity.Property(e => e.IsInjection)
                    .HasColumnName("is_injection")
                    .HasMaxLength(1);

                entity.Property(e => e.IsTestContinuous)
                    .HasColumnName("is_test_continuous")
                    .HasMaxLength(1);

                entity.Property(e => e.LotAzimuth).HasColumnName("lot_azimuth");

                entity.Property(e => e.LotFormation)
                    .HasColumnName("lot_formation")
                    .HasMaxLength(50);

                entity.Property(e => e.LotInclination).HasColumnName("lot_inclination");

                entity.Property(e => e.LotLithology)
                    .HasColumnName("lot_lithology")
                    .HasMaxLength(50);

                entity.Property(e => e.LotMd).HasColumnName("lot_md");

                entity.Property(e => e.LotPress).HasColumnName("lot_press");

                entity.Property(e => e.LotTvd).HasColumnName("lot_tvd");

                entity.Property(e => e.MdWater).HasColumnName("md_water");

                entity.Property(e => e.OpenHoleLength).HasColumnName("open_hole_length");

                entity.Property(e => e.PumpHeight).HasColumnName("pump_height");

                entity.Property(e => e.PumpRate).HasColumnName("pump_rate");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.StabilizationPressure).HasColumnName("stabilization_pressure");

                entity.Property(e => e.StabilizationTime).HasColumnName("stabilization_time");

                entity.Property(e => e.TestResult)
                    .HasColumnName("test_result")
                    .HasMaxLength(1);

                entity.Property(e => e.TestType)
                    .HasColumnName("test_type")
                    .HasMaxLength(16);

                entity.Property(e => e.TotalBhPress).HasColumnName("total_bh_press");

                entity.Property(e => e.TotalVolume).HasColumnName("total_volume");

                entity.Property(e => e.VolFluidAbsorbed).HasColumnName("vol_fluid_absorbed");

                entity.Property(e => e.VolFluidReturned).HasColumnName("vol_fluid_returned");

                entity.Property(e => e.WeightLotAmw).HasColumnName("weight_lot_amw");

                entity.Property(e => e.WeightLotEmw).HasColumnName("weight_lot_emw");

                entity.HasOne(d => d.CdHoleSectGroupT)
                    .WithMany(p => p.DmWellboreIntegT)
                    .HasForeignKey(d => new { d.WellId, d.WellboreId, d.HoleSectGroupId })
                    .HasConstraintName("R_2350");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
