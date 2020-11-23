using BigData.Models;
using BigData.Repositories;
using System.Collections.Generic;

namespace BigData
{
    public class JvEdmController
    {
        private readonly DmReportJournalRepository dmReportJournalRepository;
        private readonly CdAssemblyCompTRepository cdAssemblyCompTRepository;
        private readonly CdAssemblyDetailTRepository cdAssemblyDetailTRepository;
        private readonly CdAssemblyTRepository cdAssemblyTRepository;
        private readonly CdBhaCompBitTRepository cdBhaCompBitTRepository;
        private readonly CdCementFluidScheduleTRepository cdCementFluidScheduleTRepository;
        private readonly CdCementFluidTRepository cdCementFluidTRepository;
        private readonly CdCementJobTRepository cdCementJobTRepository;
        private readonly CdCementPlugStatusTRepository cdCementPlugStatusTRepository;
        private readonly CdCementStageTRepository cdCementStageTRepository;
        private readonly CdDatumTRepository cdDatumTRepository;
        private readonly CdDefinitiveSurveyHeaderTRepository cdDefinitiveSurveyHeaderTRepository;
        private readonly CdFluidTRepository cdFluidTRepository;
        private readonly CdHoleSectGroupTRepository cdHoleSectGroupTRepository;
        private readonly CdHoleSectTRepository cdHoleSectTRepository;
        private readonly CdPerforateTRepository cdPerforateTRepository;
        private readonly CdPolicyRepository cdPolicyRepository;
        private readonly CdProjectSourceRepository cdProjectSourceRepository;
        private readonly CdRigRepository cdRigRepository;
        private readonly CdRigAnchorRepository cdRigAnchorRepository;
        private readonly CdRigCentrifugeRepository cdRigCentrifugeRepository;
        private readonly CdRigHydrocloneRepository cdRigHydrocloneRepository;
        private readonly CdRigPumpRepository cdRigPumpRepository;
        private readonly CdSiteSourceRepository cdSiteSourceRepository;
        private readonly CdSurveyHeaderTRepository cdSurveyHeaderTRepository;
        private readonly CdSurveyStationTRepository cdSurveyStationTRepository;
        private readonly CdVgMeterTRepository cdVgMeterTRepository;
        private readonly CdWellSourceRepository cdWellSourceRepository;
        private readonly CdWellStatusTRepository cdWellStatusTRepository;
        private readonly CdWellboreFormationTRepository cdWellboreFormationTRepository;
        private readonly CdWellboreTRepository cdWellboreTRepository;
        private readonly DmActivityTRepository dmActivityTRepository;
        private readonly DmAfeRepository dmAfeRepository;
        private readonly DmAfeSuppRepository dmAfeSuppRepository;
        private readonly DmAnchorOpTRepository dmAnchorOpTRepository;
        private readonly DmBhaOpTRepository dmBhaOpTRepository;
        private readonly DmBhaRunTRepository dmBhaRunTRepository;
        private readonly DmBitOpTRepository dmBitOpTRepository;
        private readonly DmBulkTRepository dmBulkTRepository;
        private readonly DmBulkTranTRepository dmBulkTranTRepository;
        private readonly DmCentrifugeOpTRepository dmCentrifugeOpTRepository;
        private readonly DmCompanyDailyTRepository dmCompanyDailyTRepository;
        private readonly DmCompanyTRepository dmCompanyTRepository;
        private readonly DmCrCleanupTRepository dmCrCleanupTRepository;
        private readonly DmCrMudAdditiveTRepository dmCrMudAdditiveTRepository;
        private readonly DmDailyDitchMagnetTRepository dmDailyDitchMagnetTRepository;
        private readonly DmDailyNotificationTRepository dmDailyNotificationTRepository;
        private readonly DmDailyTRepository dmDailyTRepository;
        private readonly DmEnvironmentalTRepository dmEnvironmentalTRepository;
        private readonly DmEventTRepository dmEventTRepository;
        private readonly DmHydrocloneOpTRepository dmHydrocloneOpTRepository;
        private readonly DmMudProductTRepository dmMudProductTRepository;
        private readonly DmMudProductTranTRepository dmMudProductTranTRepository;
        private readonly DmMudVolumeTRepository dmMudVolumeTRepository;
        private readonly DmOperEquipFailTRepository dmOperEquipFailTRepository;
        private readonly DmPersonnelDailyTRepository dmPersonnelDailyTRepository;
        private readonly DmPersonnelTRepository dmPersonnelTRepository;
        private readonly DmPitOpTRepository dmPitOpTRepository;
        private readonly DmPumpOpTRepository dmPumpOpTRepository;
        private readonly DmRigDecklogTRepository dmRigDecklogTRepository;
        private readonly DmRigOperationRepository dmRigOperationRepository;
        private readonly DmRiserRepository dmRiserRepository;
        private readonly DmRiserOpTRepository dmRiserOpTRepository;
        private readonly DmSafetyTRepository dmSafetyTRepository;
        private readonly DmShakerOpTRepository dmShakerOpTRepository;
        private readonly DmShakerscreenRepository dmShakerscreenRepository;
        private readonly DmSupportVesselDailyTRepository dmSupportVesselDailyTRepository;
        private readonly DmSupportVesselTRepository dmSupportVesselTRepository;
        private readonly DmWeatherCheckTRepository dmWeatherCheckTRepository;
        private readonly DmWellboreIntegTRepository dmWellboreIntegTRepository;

        public JvEdmController()
        {
            dmReportJournalRepository = new DmReportJournalRepository();
            cdAssemblyCompTRepository = new CdAssemblyCompTRepository();
            cdAssemblyDetailTRepository = new CdAssemblyDetailTRepository();
            cdAssemblyTRepository = new CdAssemblyTRepository();
            cdBhaCompBitTRepository = new CdBhaCompBitTRepository();
            cdCementFluidScheduleTRepository = new CdCementFluidScheduleTRepository();
            cdCementFluidTRepository = new CdCementFluidTRepository();
            cdCementJobTRepository = new CdCementJobTRepository();
            cdCementPlugStatusTRepository = new CdCementPlugStatusTRepository();
            cdCementStageTRepository = new CdCementStageTRepository();
            cdDatumTRepository = new CdDatumTRepository();
            cdDefinitiveSurveyHeaderTRepository = new CdDefinitiveSurveyHeaderTRepository();
            cdFluidTRepository = new CdFluidTRepository();
            cdHoleSectGroupTRepository = new CdHoleSectGroupTRepository();
            cdHoleSectTRepository = new CdHoleSectTRepository();
            cdPerforateTRepository = new CdPerforateTRepository();
            cdPolicyRepository = new CdPolicyRepository();
            cdProjectSourceRepository = new CdProjectSourceRepository();
            cdRigRepository = new CdRigRepository();
            cdRigAnchorRepository = new CdRigAnchorRepository();
            cdRigCentrifugeRepository = new CdRigCentrifugeRepository();
            cdRigHydrocloneRepository = new CdRigHydrocloneRepository();
            cdRigPumpRepository = new CdRigPumpRepository();
            cdSiteSourceRepository = new CdSiteSourceRepository();
            cdSurveyHeaderTRepository = new CdSurveyHeaderTRepository();
            cdSurveyStationTRepository = new CdSurveyStationTRepository();
            cdVgMeterTRepository = new CdVgMeterTRepository();
            cdWellSourceRepository = new CdWellSourceRepository();
            cdWellStatusTRepository = new CdWellStatusTRepository();
            cdWellboreFormationTRepository = new CdWellboreFormationTRepository();
            cdWellboreTRepository = new CdWellboreTRepository();
            dmActivityTRepository = new DmActivityTRepository();
            dmAfeRepository = new DmAfeRepository();
            dmAfeSuppRepository = new DmAfeSuppRepository();
            dmAnchorOpTRepository = new DmAnchorOpTRepository();
            dmBhaOpTRepository = new DmBhaOpTRepository();
            dmBhaRunTRepository = new DmBhaRunTRepository();
            dmBitOpTRepository = new DmBitOpTRepository();
            dmBulkTRepository = new DmBulkTRepository();
            dmBulkTranTRepository = new DmBulkTranTRepository();
            dmCentrifugeOpTRepository = new DmCentrifugeOpTRepository();
            dmCompanyDailyTRepository = new DmCompanyDailyTRepository();
            dmCompanyTRepository = new DmCompanyTRepository();
            dmCrCleanupTRepository = new DmCrCleanupTRepository();
            dmCrMudAdditiveTRepository = new DmCrMudAdditiveTRepository();
            dmDailyDitchMagnetTRepository = new DmDailyDitchMagnetTRepository();
            dmDailyNotificationTRepository = new DmDailyNotificationTRepository();
            dmDailyTRepository = new DmDailyTRepository();
            dmEnvironmentalTRepository = new DmEnvironmentalTRepository();
            dmEventTRepository = new DmEventTRepository();
            dmHydrocloneOpTRepository = new DmHydrocloneOpTRepository();
            dmMudProductTRepository = new DmMudProductTRepository();
            dmMudProductTranTRepository = new DmMudProductTranTRepository();
            dmMudVolumeTRepository = new DmMudVolumeTRepository();
            dmOperEquipFailTRepository = new DmOperEquipFailTRepository();
            dmPersonnelDailyTRepository = new DmPersonnelDailyTRepository();
            dmPersonnelTRepository = new DmPersonnelTRepository();
            dmPitOpTRepository = new DmPitOpTRepository();
            dmPumpOpTRepository = new DmPumpOpTRepository();
            dmRigDecklogTRepository = new DmRigDecklogTRepository();
            dmRigOperationRepository = new DmRigOperationRepository();
            dmRiserRepository = new DmRiserRepository();
            dmRiserOpTRepository = new DmRiserOpTRepository();
            dmSafetyTRepository = new DmSafetyTRepository();
            dmShakerOpTRepository = new DmShakerOpTRepository();
            dmShakerscreenRepository = new DmShakerscreenRepository();
            dmSupportVesselDailyTRepository = new DmSupportVesselDailyTRepository();
            dmSupportVesselTRepository = new DmSupportVesselTRepository();
            dmWeatherCheckTRepository = new DmWeatherCheckTRepository();
            dmWellboreIntegTRepository = new DmWellboreIntegTRepository();
        }

        #region DmReportJournal
        public IEnumerable<DmReportJournal> GetDmReportJournals()
        {
            return dmReportJournalRepository.GetRows();
        }
        public bool CreateDmReportJournal(DmReportJournal data)
        {
            return dmReportJournalRepository.Create(data);
        }

        public bool UpdateDmReportJournal(string Id, DmReportJournal data)
        {
            return dmReportJournalRepository.Update(Id, data);
        }
        public bool DeleteDmReportJournal(string Id)
        {
            return dmReportJournalRepository.Delete(Id);
        }
        #endregion

        #region CdAssemblyCompT
        public IEnumerable<CdAssemblyCompT> GetCdAssemblyCompTs()
        {
            return cdAssemblyCompTRepository.GetRows();
        }
        public bool CreateCdAssemblyCompT(CdAssemblyCompT data)
        {
            return cdAssemblyCompTRepository.Create(data);
        }
        public bool UpdateCdAssemblyCompT(string Id, CdAssemblyCompT data)
        {
            return cdAssemblyCompTRepository.Update(Id, data);
        }
        public bool DeleteCdAssemblyComp(string Id)
        {
            return cdAssemblyCompTRepository.Delete(Id);
        }
        #endregion

        #region CdAssemblyDetailT
        public IEnumerable<CdAssemblyDetailT> GetCdAssemblyDetailT()
        {
            return cdAssemblyDetailTRepository.GetRows();
        }

        public bool CreateCdAssemblyDetailT(CdAssemblyDetailT data)
        {
            return cdAssemblyDetailTRepository.Create(data);
        }

        public bool UpdateCdAssemblyDtailT(string Id, CdAssemblyDetailT data)
        {
            return cdAssemblyDetailTRepository.Update(Id, data);
        }

        public bool DeleteCdAssemblyDetailT(string Id)
        {
            return cdAssemblyDetailTRepository.Delete(Id);
        }
        #endregion

        #region CdAssemblyT
        public IEnumerable<CdAssemblyT> GetCdAssemblyT()
        {
            return cdAssemblyTRepository.GetRows();
        }

        public bool CreateCdAssemblyT(CdAssemblyT data)
        {
            return cdAssemblyTRepository.Create(data);
        }

        public bool UpdateCdAssemblyT(string Id, CdAssemblyT data)
        {
            return cdAssemblyTRepository.Update(Id, data);
        }

        public bool DeleteCdAssemblyT(string Id)
        {
            return cdAssemblyTRepository.Delete(Id);
        }
        #endregion

        #region CdBhaCompBitTRepository
        public IEnumerable<CdBhaCompBitT> GetCdBhaCompBitT()
        {
            return cdBhaCompBitTRepository.GetRows();
        }
        public bool CreateCdBhaBitT(CdBhaCompBitT data)
        {
            return cdBhaCompBitTRepository.Create(data);
        }
        #endregion

        #region CdCementFluidScheduleT
        public IEnumerable<CdCementFluidScheduleT> GetCdCementFluidSchedule()
        {
            return cdCementFluidScheduleTRepository.GetRows();
        }

        public bool CreateCdCementFluidSchedule(CdCementFluidScheduleT data)
        {
            return cdCementFluidScheduleTRepository.Create(data);
        }

        public bool UpdateCdCementFluidSchedule(string Id, CdCementFluidScheduleT data)
        {
            return cdCementFluidScheduleTRepository.Update(Id, data);
        }

        public bool DeleteCdCementFluidSchedule(string Id)
        {
            return cdCementFluidScheduleTRepository.Delete(Id);
        }
        #endregion

        #region CdCementFluidT
        public IEnumerable<CdCementFluidT> GetCdCementFluidT()
        {
            return cdCementFluidTRepository.GetRows();
        }

        public bool CreateCdCementFluidT(CdCementFluidT data)
        {
            return cdCementFluidTRepository.Create(data);
        }

        public bool UpdateCdCementFluidT(string Id, CdCementFluidT data)
        {
            return cdCementFluidTRepository.Update(Id, data);
        }

        public bool DeleteCdCementFluidT(string Id)
        {
            return cdCementFluidTRepository.Delete(Id);
        }
        #endregion

        #region CdCementJobT
        public IEnumerable<CdCementJobT> GetCdCementJobT()
        {
            return cdCementJobTRepository.GetRows();
        }

        public bool CreateCdCementJobT(CdCementJobT data)
        {
            return cdCementJobTRepository.Create(data);
        }

        public bool UpdateCdCementJobT(string Id, CdCementJobT data)
        {
            return cdCementJobTRepository.Update(Id, data);
        }

        public bool DeleteCdCementJobT(string Id)
        {
            return cdCementJobTRepository.Delete(Id);
        }
        #endregion

        #region CdCementPlugStatusT
        public IEnumerable<CdCementPlugStatusT> GetCdCementStatusT()
        {
            return cdCementPlugStatusTRepository.GetRows();
        }

        public bool CreateCdCementStatusT(CdCementPlugStatusT data)
        {
            return cdCementPlugStatusTRepository.Create(data);
        }

        public bool UpdateCdCementStatusT(string Id, CdCementPlugStatusT data)
        {
            return cdCementPlugStatusTRepository.Update(Id, data);
        }

        public bool DeleteCdCementStatusT(string Id)
        {
            return cdCementPlugStatusTRepository.Delete(Id);
        }
        #endregion

        #region CdCementStageT
        public IEnumerable<CdCementStageT> GetCdCementStageT()
        {
            return cdCementStageTRepository.GetRows();
        }

        public bool CreateCdCementStageT(CdCementStageT data)
        {
            return cdCementStageTRepository.Create(data);
        }

        public bool UpdateCdCementStageT(string Id, CdCementStageT data)
        {
            return cdCementStageTRepository.Update(Id, data);
        }

        public bool DeleteCdCementStageT(string Id)
        {
            return cdCementStageTRepository.Delete(Id);
        }
        #endregion

        #region CdDatumT
        public IEnumerable<CdDatumT> GetCdDatumT()
        {
            return cdDatumTRepository.GetRows();
        }

        public bool CreateCdDatumT(CdDatumT data)
        {
            return cdDatumTRepository.Create(data);
        }

        public bool UpdateCdDatumT(string Id, CdDatumT data)
        {
            return cdDatumTRepository.Update(Id, data);
        }

        public bool DeleteCdDatumT(string Id)
        {
            return cdDatumTRepository.Delete(Id);
        }
        #endregion

        #region CdDefinitiveSurveyHeaderT
        public IEnumerable<CdDefinitiveSurveyHeaderT> GetCdDefinitiveSurveyHeaderT()
        {
            return cdDefinitiveSurveyHeaderTRepository.GetRows();
        }

        public bool CreateCdDefinitiveSurveyHeaderT(CdDefinitiveSurveyHeaderT data)
        {
            return cdDefinitiveSurveyHeaderTRepository.Create(data);
        }

        public bool UpdateCdDefinitiveSurveyHeaderT(string Id, CdDefinitiveSurveyHeaderT data)
        {
            return cdDefinitiveSurveyHeaderTRepository.Update(Id, data);
        }

        public bool DeleteCdDefinitiveSurveyHeaderT(string Id)
        {
            return cdDefinitiveSurveyHeaderTRepository.Delete(Id);
        }
        #endregion

        #region CdFluidT
        public IEnumerable<CdFluidT> GetCdFluidT()
        {
            return cdFluidTRepository.GetRows();
        }

        public bool CreateCdFluidT(CdFluidT data)
        {
            return cdFluidTRepository.Create(data);
        }

        public bool UpdateCdFluidT(string Id, CdFluidT data)
        {
            return cdFluidTRepository.Update(Id, data);
        }

        public bool DeleteCdFluidT(string Id)
        {
            return cdFluidTRepository.Delete(Id);
        }
        #endregion

        #region CdHoleSectGroupT
        public IEnumerable<CdHoleSectGroupT> GetCdHoleSectGroupT()
        {
            return cdHoleSectGroupTRepository.GetRows();
        }

        public bool CreateCdHoleSectGroupT(CdHoleSectGroupT data)
        {
            return cdHoleSectGroupTRepository.Create(data);
        }

        public bool UpdateCdHoleSectGroupT(string Id, CdHoleSectGroupT data)
        {
            return cdHoleSectGroupTRepository.Update(Id, data);
        }

        public bool DeleteCdHoleSectGroupT(string Id)
        {
            return cdHoleSectGroupTRepository.Delete(Id);
        }
        #endregion

        #region CdHoleSectT
        public IEnumerable<CdHoleSectT> GetCdHoleSectT()
        {
            return cdHoleSectTRepository.GetRows();
        }

        public bool CreateCdHoleSectT(CdHoleSectT data)
        {
            return cdHoleSectTRepository.Create(data);
        }

        public bool UpdateCdHoleSectT(string Id, CdHoleSectT data)
        {
            return cdHoleSectTRepository.Update(Id, data);
        }

        public bool DeleteCdHoleSectT(string Id)
        {
            return cdHoleSectTRepository.Delete(Id);
        }
        #endregion

        #region CdPerforateT
        public IEnumerable<CdPerforateT> GetCdPerforateT()
        {
            return cdPerforateTRepository.GetRows();
        }

        public bool CreateCdPerforateT(CdPerforateT data)
        {
            return cdPerforateTRepository.Create(data);
        }

        public bool UpdateCdPerforateT(string Id, CdPerforateT data)
        {
            return cdPerforateTRepository.Update(Id, data);
        }

        public bool DeleteCdPerforateT(string Id)
        {
            return cdPerforateTRepository.Delete(Id);
        }
        #endregion

        #region CdPolicy
        public IEnumerable<CdPolicy> GetCdPolicy()
        {
            return cdPolicyRepository.GetRows();
        }

        public bool CreateCdPolicy(CdPolicy data)
        {
            return cdPolicyRepository.Create(data);
        }

        public bool UpdateCdPolicy(string Id, CdPolicy data)
        {
            return cdPolicyRepository.Update(Id, data);
        }

        public bool DeleteCdPolicy(string Id)
        {
            return cdPolicyRepository.Delete(Id);
        }
        #endregion

        #region CdProjectSource
        public IEnumerable<CdProjectSource> GetCdProjectSource()
        {
            return cdProjectSourceRepository.GetRows();
        }

        public bool CreateCdProjectSource(CdProjectSource data)
        {
            return cdProjectSourceRepository.Create(data);
        }

        public bool UpdateCdProjectSource(string Id, CdProjectSource data)
        {
            return cdProjectSourceRepository.Update(Id, data);
        }

        public bool DeleteCdProjectSource(string Id)
        {
            return cdProjectSourceRepository.Delete(Id);
        }
        #endregion

        #region CdRig
        public IEnumerable<CdRig> GetCdRig()
        {
            return cdRigRepository.GetRows();
        }

        public bool CreateCdRig(CdRig data)
        {
            return cdRigRepository.Create(data);
        }

        public bool UpdateCdRig(string Id, CdRig data)
        {
            return cdRigRepository.Update(Id, data);
        }

        public bool DeleteCdRig(string Id)
        {
            return cdRigRepository.Delete(Id);
        }
        #endregion

        #region CdRigAnchor
        public IEnumerable<CdRigAnchor> GetCdRigAnchor()
        {
            return cdRigAnchorRepository.GetRows();
        }

        public bool CreateCdRigAnchor(CdRigAnchor data)
        {
            return cdRigAnchorRepository.Create(data);
        }

        public bool UpdateCdRigAnchor(string Id, CdRigAnchor data)
        {
            return cdRigAnchorRepository.Update(Id, data);
        }

        public bool DeleteCdRigAnchor(string Id)
        {
            return cdRigAnchorRepository.Delete(Id);
        }
        #endregion

        #region CdRigCentrifuge
        public IEnumerable<CdRigCentrifuge> GetCdRigCentrifuge()
        {
            return cdRigCentrifugeRepository.GetRows();
        }

        public bool CreateCdRigCentrifuge(CdRigCentrifuge data)
        {
            return cdRigCentrifugeRepository.Create(data);
        }

        public bool UpdateCdRigCentrifuge(string Id, CdRigCentrifuge data)
        {
            return cdRigCentrifugeRepository.Update(Id, data);
        }

        public bool DeleteCdRigCentrifuge(string Id)
        {
            return cdRigCentrifugeRepository.Delete(Id);
        }
        #endregion

        #region CdRigHydroclone
        public IEnumerable<CdRigHydroclone> GetCdRigHydroclones()
        {
            return cdRigHydrocloneRepository.GetRows();
        }

        public bool CreateCdRigHydroclone(CdRigHydroclone data)
        {
            return cdRigHydrocloneRepository.Create(data);
        }

        public bool UpdateCdRigHydroclone(string Id, CdRigHydroclone data)
        {
            return cdRigHydrocloneRepository.Update(Id, data);
        }

        public bool DeleteCdRigHydroclone(string Id)
        {
            return cdRigHydrocloneRepository.Delete(Id);
        }
        #endregion

        #region CdRigPumpRepository
        public IEnumerable<CdRigPump> GetCdRigPump()
        {
            return cdRigPumpRepository.GetRows();
        }

        public bool CreateCdRigPump(CdRigPump data)
        {
            return cdRigPumpRepository.Create(data);
        }

        public bool UpdateCdRigPump(string Id, CdRigPump data)
        {
            return cdRigPumpRepository.Update(Id, data);
        }

        public bool DeleteCdRigPump(string Id)
        {
            return cdRigPumpRepository.Delete(Id);
        }
        #endregion

        #region CdSiteSource
        public IEnumerable<CdSiteSource> GetCdSiteSource()
        {
            return cdSiteSourceRepository.GetRows();
        }

        public bool CreateCdSiteSource(CdSiteSource data)
        {
            return cdSiteSourceRepository.Create(data);
        }

        public bool UpdateCdSiteSource(string Id, CdSiteSource data)
        {
            return cdSiteSourceRepository.Update(Id, data);
        }

        public bool DeleteCdSiteSource(string Id)
        {
            return cdSiteSourceRepository.Delete(Id);
        }
        #endregion

        #region CdSruveyHeaderT
        public IEnumerable<CdSurveyHeaderT> GetCdSruveyHeaderT()
        {
            return cdSurveyHeaderTRepository.GetRows();
        }

        public bool CreateCdSurveyHeaderT(CdSurveyHeaderT data)
        {
            return cdSurveyHeaderTRepository.Create(data);
        }

        public bool UpdateCdSurveyHeaderT(string Id, CdSurveyHeaderT data)
        {
            return cdSurveyHeaderTRepository.Update(Id, data);
        }

        public bool DeleteCdSurveyHeaderT(string Id)
        {
            return cdSurveyHeaderTRepository.Delete(Id);
        }
        #endregion

        #region CdSurveyStationT
        public IEnumerable<CdSurveyStationT> GetCdSurveyStationT()
        {
            return cdSurveyStationTRepository.GetRows();
        }

        public bool CreateCdSurveyStationT(CdSurveyStationT data)
        {
            return cdSurveyStationTRepository.Create(data);
        }

        public bool UpdateCdSurveyStationT(string Id, CdSurveyStationT data)
        {
            return cdSurveyStationTRepository.Update(Id, data);
        }

        public bool DeleteCdSurveyStationT(string Id)
        {
            return cdSurveyStationTRepository.Delete(Id);
        }
        #endregion

        #region CdVgMeterT
        public IEnumerable<CdVgMeterT> GetCdVgMeterTs()
        {
            return cdVgMeterTRepository.GetRows();
        }

        public bool CreateCdVgMeterT(CdVgMeterT data)
        {
            return cdVgMeterTRepository.Create(data);
        }

        public bool UpdateCdVgMeterT(string Id, CdVgMeterT data)
        {
            return cdVgMeterTRepository.Update(Id, data);
        }

        public bool DeleteCdVgMeterT(string Id)
        {
            return cdVgMeterTRepository.Delete(Id);
        }
        #endregion

        #region CdWellSourceRepository
        public IEnumerable<CdWellSource> GetCdWellSources()
        {
            return cdWellSourceRepository.GetRows();
        }

        public bool CreateCdWellSource(CdWellSource data)
        {
            return cdWellSourceRepository.Create(data);
        }

        public bool UpdateCdWellSource(string Id, CdWellSource data)
        {
            return cdWellSourceRepository.Update(Id, data);
        }

        public bool DeleteCdWellSource(string Id)
        {
            return cdWellSourceRepository.Delete(Id);
        }
        #endregion

        #region CdWellStatusT
        public IEnumerable<CdWellStatusT> GetCdWellStatusTs()
        {
            return cdWellStatusTRepository.GetRows();
        }

        public bool CreateCdWellStatusT(CdWellStatusT data)
        {
            return cdWellStatusTRepository.Create(data);
        }

        public bool UpdateCdWellStatusT(string Id, CdWellStatusT data)
        {
            return cdWellStatusTRepository.Update(Id, data);
        }

        public bool DeleteCdWellStatusT(string Id)
        {
            return cdWellStatusTRepository.Delete(Id);
        }
        #endregion

        #region CdWellboreFormationT
        public IEnumerable<CdWellboreFormationT> GetCdWellboreFormationTs()
        {
            return cdWellboreFormationTRepository.GetRows();
        }

        public bool CreateCdWellboreFormationT(CdWellboreFormationT data)
        {
            return cdWellboreFormationTRepository.Create(data);
        }

        public bool UpdateCdWellboreFormationT(string Id, CdWellboreFormationT data)
        {
            return cdWellboreFormationTRepository.Update(Id, data);
        }

        public bool DeleteCdWellboreFormationT(string Id)
        {
            return cdWellboreFormationTRepository.Delete(Id);
        }
        #endregion

        #region CdWellboreT
        public IEnumerable<CdWellboreT> GetCdWellboreTs()
        {
            return cdWellboreTRepository.GetRows();
        }

        public bool CreateCdWellboreT(CdWellboreT data)
        {
            return cdWellboreTRepository.Create(data);
        }

        public bool UpdateCdWellboreT(string Id, CdWellboreT data)
        {
            return cdWellboreTRepository.Update(Id, data);
        }

        public bool DeleteCdWellboreT(string Id)
        {
            return cdWellboreTRepository.Delete(Id);
        }
        #endregion

        #region DmReportActivityT
        public IEnumerable<DmActivityT> GetDmActivityTs()
        {
            return dmActivityTRepository.GetRows();
        }

        public bool CreateDmActivityT(DmActivityT data)
        {
            return dmActivityTRepository.Create(data);
        }

        public bool UpdateDmActivityT(string Id, DmActivityT data)
        {
            return dmActivityTRepository.Update(Id, data);
        }

        public bool DeleteDmActivityT(string Id)
        {
            return dmActivityTRepository.Delete(Id);
        }
        #endregion

        #region DmAfe
        public IEnumerable<DmAfe> GetDmAfe()
        {
            return dmAfeRepository.GetRows();
        }

        public bool CreateDmAfe(DmAfe data)
        {
            return dmAfeRepository.Create(data);
        }

        public bool UpdateDmAfe(string Id, DmAfe data)
        {
            return dmAfeRepository.Update(Id, data);
        }

        public bool DeleteDmAfe(string Id)
        {
            return dmAfeRepository.Delete(Id);
        }
        #endregion

        #region DmAfeSupp
        public IEnumerable<DmAfeSupp> GetDmAfeSupps()
        {
            return dmAfeSuppRepository.GetRows();
        }

        public bool CreateDmAfeSupp(DmAfeSupp data)
        {
            return dmAfeSuppRepository.Create(data);
        }

        public bool UpdateDmAfeSupp(string Id, DmAfeSupp data)
        {
            return dmAfeSuppRepository.Update(Id, data);
        }

        public bool DeleteDmAfeSupp(string Id)
        {
            return dmAfeRepository.Delete(Id);
        }
        #endregion

        #region DmAnchorOpT
        public IEnumerable<DmAnchorOpT> GetDmAnchorOpTs()
        {
            return dmAnchorOpTRepository.GetRows();
        }

        public bool CreateDmAnchorOpT(DmAnchorOpT data)
        {
            return dmAnchorOpTRepository.Create(data);
        }

        public bool UpdateDmAnchorOpT(string Id, DmAnchorOpT data)
        {
            return dmAnchorOpTRepository.Update(Id, data);
        }

        public bool Delete(string Id)
        {
            return dmAnchorOpTRepository.Delete(Id);
        }
        #endregion

        #region DmBhaOpT
        public IEnumerable<DmBhaOpT> GetDmBhaOpTs()
        {
            return dmBhaOpTRepository.GetRows();
        }

        public bool CreateDmBhaOpT(DmBhaOpT data)
        {
            return dmBhaOpTRepository.Create(data);
        }

        public bool UpdateDmBhaOpT(string Id, DmBhaOpT data)
        {
            return dmBhaOpTRepository.Update(Id, data);
        }

        public bool DeleteDmBhaOpT(string Id)
        {
            return dmBhaOpTRepository.Delete(Id);
        }
        #endregion

        #region DmBhaRunT
        public IEnumerable<DmBhaRunT> GetDmBhaRunTs()
        {
            return dmBhaRunTRepository.GetRows();
        }

        public bool CreateDmBhaRunT(DmBhaRunT data)
        {
            return dmBhaRunTRepository.Create(data);
        }

        public bool UpdateDmBhaRunT(string Id, DmBhaRunT data)
        {
            return dmBhaRunTRepository.Update(Id, data);
        }

        public bool DeleteDmBhaRunT(string Id)
        {
            return dmBhaRunTRepository.Delete(Id);
        }
        #endregion

        #region DmBitOpT
        public IEnumerable<DmBitOpT> GetDmBitOpTs()
        {
            return dmBitOpTRepository.GetRows();
        }

        public bool CreateDmBitOpT(DmBitOpT data)
        {
            return dmBitOpTRepository.Create(data);
        }

        public bool UpdateDmBitOpT(string Id, DmBitOpT data)
        {
            return dmBitOpTRepository.Update(Id, data);
        }

        public bool DeleteDmBitOpT(string Id)
        {
            return dmBitOpTRepository.Delete(Id);
        }
        #endregion

        #region DmBulkT
        public IEnumerable<DmBulkT> GetDmBulkTs()
        {
            return dmBulkTRepository.GetRows();
        }

        public bool CreateDmBulkT(DmBulkT data)
        {
            return dmBulkTRepository.Create(data);
        }

        public bool UpdateDmBulkT(string Id, DmBulkT data)
        {
            return dmBulkTRepository.Update(Id, data);
        }

        public bool DeleteDmBulkT(string Id)
        {
            return dmBulkTRepository.Delete(Id);
        }
        #endregion

        #region DmBulkTranT
        public IEnumerable<DmBulkTranT> GetDmBulkTranTs()
        {
            return dmBulkTranTRepository.GetRows();
        }

        public bool CreateDmBulkTranT(DmBulkTranT data)
        {
            return dmBulkTranTRepository.Create(data);
        }

        public bool UpdateDmBulkTranT(string Id, DmBulkTranT data)
        {
            return dmBulkTranTRepository.Update(Id, data);
        }

        public bool DeleteDmBulkTranT(string Id)
        {
            return dmBulkTranTRepository.Delete(Id);
        }
        #endregion

        #region DmCentrifugeOpT
        public IEnumerable<DmCentrifugeOpT> GetDmCentrifugeOpTs()
        {
            return dmCentrifugeOpTRepository.GetRows();
        }

        public bool CreateDmCentrifugeOpT(DmCentrifugeOpT data)
        {
            return dmCentrifugeOpTRepository.Create(data);
        }

        public bool UpdateDmCentrifugeOpT(string Id, DmCentrifugeOpT data)
        {
            return dmCentrifugeOpTRepository.Update(Id, data);
        }

        public bool DeleteDmCentrifugeOpT(string Id)
        {
            return dmCentrifugeOpTRepository.Delete(Id);
        }
        #endregion

        #region DmCompanyDailyT
        public IEnumerable<DmCompanyDailyT> GetDmCompanyDailyTs()
        {
            return dmCompanyDailyTRepository.GetRows();
        }

        public bool CreateDmCompanyDailyT(DmCompanyDailyT data)
        {
            return dmCompanyDailyTRepository.Create(data);
        }

        public bool UpdateDmCompanyDailyT(string Id, DmCompanyDailyT data)
        {
            return dmCompanyDailyTRepository.Update(Id, data);
        }

        public bool DeleteDmCompanyDailyT(string Id)
        {
            return dmCompanyDailyTRepository.Delete(Id);
        }
        #endregion

        #region DmCompanyT
        public IEnumerable<DmCompanyT> GetDmCompanyTs()
        {
            return dmCompanyTRepository.GetRows();
        }

        public bool CreateDmCompanyT(DmCompanyT data)
        {
            return dmCompanyTRepository.Create(data);
        }

        public bool UpdateDmCompanyT(string Id, DmCompanyT data)
        {
            return dmCompanyTRepository.Update(Id, data);
        }

        public bool DeleteDmCompanyT(string Id)
        {
            return dmCompanyTRepository.Delete(Id);
        }
        #endregion

        #region DmCrCleanupT
        public IEnumerable<DmCrCleanupT> GetDmCrCleanupTs()
        {
            return dmCrCleanupTRepository.GetRows();
        }

        public bool CreateDmCrCleanupT(DmCrCleanupT data)
        {
            return dmCrCleanupTRepository.Create(data);
        }

        public bool UpdateDmCrCleanupT(string Id, DmCrCleanupT data)
        {
            return dmCrCleanupTRepository.Update(Id, data);
        }

        public bool DeleteDmCrCleanupT(string Id)
        {
            return dmCrCleanupTRepository.Delete(Id);
        }
        #endregion

        #region DmCrMudAdditiveT
        public IEnumerable<DmCrMudAdditiveT> GetDmCrMudAdditiveTs()
        {
            return dmCrMudAdditiveTRepository.GetRows();
        }

        public bool CreateDmCrMudAdditiveT(DmCrMudAdditiveT data)
        {
            return dmCrMudAdditiveTRepository.Create(data);
        }

        public bool UpdateDmCrMudAdditiveT(string Id, DmCrMudAdditiveT data)
        {
            return dmCrMudAdditiveTRepository.Update(Id, data);
        }

        public bool DeleteDmCrMudAdditiveT(string Id)
        {
            return dmCrMudAdditiveTRepository.Delete(Id);
        }
        #endregion

        #region DmDailyDitchMagnetT
        public IEnumerable<DmDailyDitchMagnetT> GetDmDailyDitchMagnetTs()
        {
            return dmDailyDitchMagnetTRepository.GetRows();
        }

        public bool CreateDmDailyDitchMagnetT(DmDailyDitchMagnetT data)
        {
            return dmDailyDitchMagnetTRepository.Create(data);
        }

        public bool UpdateDmDailyDitchMagnetT(string Id, DmDailyDitchMagnetT data)
        {
            return dmDailyDitchMagnetTRepository.Update(Id, data);
        }

        public bool DeleteDmDailyDitchMagnetT(string Id)
        {
            return dmDailyDitchMagnetTRepository.Delete(Id);
        }
        #endregion

        #region DmDailyNotificationT
        public IEnumerable<DmDailyNotificationT> GetDmDailyNotificationTs()
        {
            return dmDailyNotificationTRepository.GetRows();
        }

        public bool CreateDmDailyNotificationT(DmDailyNotificationT data)
        {
            return dmDailyNotificationTRepository.Create(data);
        }

        public bool UdateDmDailyNotificationT(string Id, DmDailyNotificationT data)
        {
            return dmDailyNotificationTRepository.Update(Id, data);
        }

        public bool DeleteDmDailyNotificationT(string Id)
        {
            return dmDailyNotificationTRepository.Delete(Id);
        }
        #endregion

        #region DmDailyT
        public IEnumerable<DmDailyT> GetDmDailyTs()
        {
            return dmDailyTRepository.GetRows();
        }

        public bool CreateDmDailyT(DmDailyT data)
        {
            return dmDailyTRepository.Create(data);
        }

        public bool UpdateDailyT(string Id, DmDailyT data)
        {
            return dmDailyTRepository.Update(Id, data);
        }

        public bool DeleteDailyT(string Id)
        {
            return dmDailyTRepository.Delete(Id);
        }
        #endregion

        #region DmEnvironmentalT
        public IEnumerable<DmEnvironmentalT> GetDmEnvironmentalTs()
        {
            return dmEnvironmentalTRepository.GetRows();
        }

        public bool CreateDmEnvironmentalT(DmEnvironmentalT data)
        {
            return dmEnvironmentalTRepository.Create(data);
        }

        public bool UpdateDmEnvironmentalT(string Id, DmEnvironmentalT data)
        {
            return dmEnvironmentalTRepository.Update(Id, data);
        }

        public bool DeleteDmEnvironmentalT(string Id)
        {
            return dmEnvironmentalTRepository.Delete(Id);
        }
        #endregion

        #region DmEventT
        public IEnumerable<DmEventT> GetDmEventTs()
        {
            return dmEventTRepository.GetRows();
        }

        public bool CreateDmEventT(DmEventT data)
        {
            return dmEventTRepository.Create(data);
        }

        public bool UpdateDmEventT(string Id, DmEventT data)
        {
            return dmEventTRepository.Update(Id, data);
        }

        public bool DeleteDmEventT(string Id)
        {
            return dmEventTRepository.Delete(Id);
        }
        #endregion

        #region DmHydrocloneOpT
        public IEnumerable<DmHydrocloneOpT> GetDmHydrocloneOpTs()
        {
            return dmHydrocloneOpTRepository.GetRows();
        }

        public bool CreateDmHydrocloneOpT(DmHydrocloneOpT data)
        {
            return dmHydrocloneOpTRepository.Create(data);
        }

        public bool UpdateDmHydrocloneOpT(string Id, DmHydrocloneOpT data)
        {
            return dmHydrocloneOpTRepository.Update(Id, data);
        }

        public bool DeleteDmHydrocloneOpT(string Id)
        {
            return dmHydrocloneOpTRepository.Delete(Id);
        }
        #endregion

        #region DmMudProductT
        public IEnumerable<DmMudProductT> GetDmMudProductTs()
        {
            return dmMudProductTRepository.GetRows();
        }

        public bool CreateDmMudProduct(DmMudProductT data)
        {
            return dmMudProductTRepository.Create(data);
        }

        public bool UpdateDmMudProduct(string Id, DmMudProductT data)
        {
            return dmMudProductTRepository.Update(Id, data);
        }

        public bool DeleteDmMudProductT(string Id)
        {
            return dmMudProductTRepository.Delete(Id);
        }
        #endregion

        #region DmMudProductTranT
        public IEnumerable<DmMudProductTranT> GetDmMudProductTranTs()
        {
            return dmMudProductTranTRepository.GetRows();
        }

        public bool CreateDmMudProductTranT(DmMudProductTranT data)
        {
            return dmMudProductTranTRepository.Create(data);
        }

        public bool UpdateDmMudProductTranT(string Id, DmMudProductTranT data)
        {
            return dmMudProductTranTRepository.Update(Id, data);
        }

        public bool DeleteDmMudProductTranT(string Id)
        {
            return dmMudProductTranTRepository.Delete(Id);
        }
        #endregion

        #region DmMudVolumeT
        public IEnumerable<DmMudVolumeT> GetDmMudVolumeTs()
        {
            return dmMudVolumeTRepository.GetRows();
        }

        public bool CreateDmMudVolumeT(DmMudVolumeT data)
        {
            return dmMudVolumeTRepository.Create(data);
        }

        public bool UpdateDmMudVolumeT(string Id, DmMudVolumeT data)
        {
            return dmMudVolumeTRepository.Update(Id, data);
        }

        public bool DeleteDmMudVolumeT(string Id)
        {
            return dmMudVolumeTRepository.Delete(Id);
        }
        #endregion

        #region DmOperEquipFailT
        public IEnumerable<DmOperEquipFailT> GetDmOperEquipFailTs()
        {
            return dmOperEquipFailTRepository.GetRows();
        }

        public bool CreateDmOperEquipFailT(DmOperEquipFailT data)
        {
            return dmOperEquipFailTRepository.Create(data);
        }

        public bool UpdateDmOperEquipFailT(string Id, DmOperEquipFailT data)
        {
            return dmOperEquipFailTRepository.Update(Id, data);
        }

        public bool DeleteDmOperEquipFailT(string Id)
        {
            return dmOperEquipFailTRepository.Delete(Id);
        }
        #endregion

        #region DmPersonnelDailyT
        public IEnumerable<DmPersonnelDailyT> GetDmPersonnelDailyTs()
        {
            return dmPersonnelDailyTRepository.GetRows();
        }

        public bool CreateDmPersonnelDailyT(DmPersonnelDailyT data)
        {
            return dmPersonnelDailyTRepository.Create(data);
        }

        public bool UpdateDmPersonnelDailyT(string Id, DmPersonnelDailyT data)
        {
            return dmPersonnelDailyTRepository.Update(Id, data);
        }

        public bool DeleteDmPersonnelDailyT(string Id)
        {
            return dmPersonnelDailyTRepository.Delete(Id);
        }
        #endregion

        #region DmPersonnelT
        public IEnumerable<DmPersonnelT> GetDmPersonnelTs()
        {
            return dmPersonnelTRepository.GetRows();
        }

        public bool CreateDmPersonnelT(DmPersonnelT data)
        {
            return dmPersonnelTRepository.Create(data);
        }

        public bool UpdateDmPersonnelT(string Id, DmPersonnelT data)
        {
            return dmPersonnelTRepository.Update(Id, data);
        }

        public bool DeleteDmPersonnelT(string Id)
        {
            return dmPersonnelTRepository.Delete(Id);
        }
        #endregion

        #region DmPitOpT
        public IEnumerable<DmPitOpT> GetDmPitOpTs()
        {
            return dmPitOpTRepository.GetRows();
        }

        public bool CreateDmPitOpT(DmPitOpT data)
        {
            return dmPitOpTRepository.Create(data);
        }

        public bool UpdateDmPitOpT(string Id, DmPitOpT data)
        {
            return dmPitOpTRepository.Update(Id, data);
        }

        public bool DeleteDmPitOpT(string Id)
        {
            return dmPitOpTRepository.Delete(Id);
        }
        #endregion

        #region DmPumpOpT
        public IEnumerable<DmPumpOpT> GetDmPumpOpTs()
        {
            return dmPumpOpTRepository.GetRows();
        }

        public bool CreateDmPumpT(DmPumpOpT data)
        {
            return dmPumpOpTRepository.Create(data);
        }

        public bool UpdateDmPumpT(string Id, DmPumpOpT data)
        {
            return dmPumpOpTRepository.Update(Id, data);
        }

        public bool DeleteDmPumpT(string Id)
        {
            return dmPumpOpTRepository.Delete(Id);
        }
        #endregion

        #region DmRigDecklogT
        public IEnumerable<DmRigDecklogT> GetDmRigDecklogTs()
        {
            return dmRigDecklogTRepository.GetRows();
        }

        public bool CreateDmRigDecklogT(DmRigDecklogT data)
        {
            return dmRigDecklogTRepository.Create(data);
        }

        public bool UpdateDmRigDecklogT(string Id, DmRigDecklogT data)
        {
            return dmRigDecklogTRepository.Update(Id, data);
        }

        public bool DeleteDmRigDecklogT(string Id)
        {
            return dmRigDecklogTRepository.Delete(Id);
        }
        #endregion

        #region DmRigOperation
        public IEnumerable<DmRigOperation> GetDmRigOperations()
        {
            return dmRigOperationRepository.GetRows();
        }

        public bool CreateDmRigOperation(DmRigOperation data)
        {
            return dmRigOperationRepository.Create(data);
        }

        public bool UpdateDmRigOperation(string Id, DmRigOperation data)
        {
            return dmRigOperationRepository.Update(Id, data);
        }

        public bool DeleteDmRigOperation(string Id)
        {
            return dmRigOperationRepository.Delete(Id);
        }
        #endregion

        #region DmRiser
        public IEnumerable<DmRiser> GetDmRisers()
        {
            return dmRiserRepository.GetRows();
        }

        public bool CreateDmRiser(DmRiser data)
        {
            return dmRiserRepository.Create(data);
        }

        public bool UpdateDmRiser(string Id, DmRiser data)
        {
            return dmRiserRepository.Update(Id, data);
        }

        public bool DeleteDmRiser(string Id)
        {
            return dmRiserRepository.Delete(Id);
        }
        #endregion

        #region DmRiserOpT
        public IEnumerable<DmRiserOpT> GetDmRiserOpTs()
        {
            return dmRiserOpTRepository.GetRows();
        }

        public bool CreateDmRiserOpT(DmRiserOpT data)
        {
            return dmRiserOpTRepository.Create(data);
        }

        public bool UpdateDmRiserOpT(string Id, DmRiserOpT data)
        {
            return dmRiserOpTRepository.Update(Id, data);
        }

        public bool DeleteDmRiserOpT(string Id)
        {
            return dmRiserOpTRepository.Delete(Id);
        }
        #endregion

        #region DmSafetyT
        public IEnumerable<DmSafetyT> GetDmSafetyTs()
        {
            return dmSafetyTRepository.GetRows();
        }

        public bool CreateDmSafetyT(DmSafetyT data)
        {
            return dmSafetyTRepository.Create(data);
        }

        public bool UpdateDmSafetyT(string Id, DmSafetyT data)
        {
            return dmSafetyTRepository.Update(Id, data);
        }

        public bool DeleteDmSafetyT(string Id)
        {
            return dmSafetyTRepository.Delete(Id);
        }
        #endregion

        #region DmShakerOpT
        public IEnumerable<DmShakerOpT> GetDmShakerOpTs()
        {
            return dmShakerOpTRepository.GetRows();
        }

        public bool CreateDmShakerOpT(DmShakerOpT data)
        {
            return dmShakerOpTRepository.Create(data);
        }

        public bool UpdateDmShakerOpT(string Id, DmShakerOpT data)
        {
            return dmShakerOpTRepository.Update(Id, data);
        }

        public bool DeleteDmShakerOpT(string Id)
        {
            return dmShakerOpTRepository.Delete(Id);
        }
        #endregion

        #region Shakerscreen
        public IEnumerable<DmShakerscreen> GetDmShakerscreens()
        {
            return dmShakerscreenRepository.GetRows();
        }

        public bool CreateDmShakerscreen(DmShakerscreen data)
        {
            return dmShakerscreenRepository.Create(data);
        }

        public bool UpdateDmShakerscreen(string Id, DmShakerscreen data)
        {
            return dmShakerscreenRepository.Update(Id, data);
        }

        public bool DeleteDmShakerscreen(string Id)
        {
            return dmShakerscreenRepository.Delete(Id);
        }
        #endregion

        #region DmSupportVesselDailyT
        public IEnumerable<DmSupportVesselDailyT> GetDmSupportVesselDailyTs()
        {
            return dmSupportVesselDailyTRepository.GetRows();
        }

        public bool CreateDmSupportVesselDailyT(DmSupportVesselDailyT data)
        {
            return dmSupportVesselDailyTRepository.Create(data);
        }

        public bool UpdateDmSupportVesselDailyT(string Id, DmSupportVesselDailyT data)
        {
            return dmSupportVesselDailyTRepository.Update(Id, data);
        }

        public bool DeleteDmSupportVesselDailyT(string Id)
        {
            return dmSupportVesselDailyTRepository.Delete(Id);
        }
        #endregion

        #region DmSupportVesselT
        public IEnumerable<DmSupportVesselT> GetDmSupportVesselTs()
        {
            return dmSupportVesselTRepository.GetRows();
        }

        public bool CreateDmSupportVesselT(DmSupportVesselT data)
        {
            return dmSupportVesselTRepository.Create(data);
        }

        public bool UpdateDmSupportVesselT(string Id, DmSupportVesselT data)
        {
            return dmSupportVesselTRepository.Update(Id, data);
        }

        public bool DeleteDmSupportVesselT(string Id)
        {
            return dmSupportVesselTRepository.Delete(Id);
        }
        #endregion

        #region DmWeatherCheckT
        public IEnumerable<DmWeatherCheckT> GetDmWeatherCheckTs()
        {
            return dmWeatherCheckTRepository.GetRows();
        }

        public bool CreateDmWeatherCheckT(DmWeatherCheckT data)
        {
            return dmWeatherCheckTRepository.Create(data);
        }

        public bool UpdateDmWeatherCheckT(string Id, DmWeatherCheckT data)
        {
            return dmWeatherCheckTRepository.Update(Id, data);
        }

        public bool DeleteDmWeatherCheckT(string Id)
        {
            return dmWeatherCheckTRepository.Delete(Id);
        }
        #endregion

        #region DmWellboreIntegT
        public IEnumerable<DmWellboreIntegT> GetDmWellboreIntegTs()
        {
            return dmWellboreIntegTRepository.GetRows();
        }

        public bool CreateDmWellboreIntegT(DmWellboreIntegT data)
        {
            return dmWellboreIntegTRepository.Create(data);
        }

        public bool UpdateDmWellboreIntegT(string Id, DmWellboreIntegT data)
        {
            return dmWellboreIntegTRepository.Update(Id, data);
        }

        public bool DeleteDmWellboreIntegT(string Id)
        {
            return dmWellboreIntegTRepository.Delete(Id);
        }
        #endregion
    }
}
