using BigData.Models;
using BigData.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        }

        #region DmReportJournal
        public IEnumerable<DmReportJournal> GetDmReportJournals()
        {
            return dmReportJournalRepository.GetRows();
        }
        public bool CreateDmReportJournal(string jsonData)
        {
            return dmReportJournalRepository.Create(jsonData);
        }

        public bool UpdateDmReportJournal(string Id, string jsonData)
        {
            return dmReportJournalRepository.Update(Id, jsonData);
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
        public bool CreateCdAssemblyCompT(string jsonData)
        {
            return cdAssemblyCompTRepository.Create(jsonData);
        }
        public bool UpdateCdAssemblyCompT(string Id, string jsonData)
        {
            return cdAssemblyCompTRepository.Update(Id, jsonData);
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

        public bool CreateCdAssemblyDetailT(string jsonData)
        {
            return cdAssemblyDetailTRepository.Create(jsonData);
        }

        public bool UpdateCdAssemblyDtailT(string Id, string jsonData)
        {
            return cdAssemblyDetailTRepository.Update(Id, jsonData);
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

        public bool CreateCdAssemblyT(string jsonData)
        {
            return cdAssemblyTRepository.Create(jsonData);
        }

        public bool UpdateCdAssemblyT(string Id, string jsonData)
        {
            return cdAssemblyTRepository.Update(Id, jsonData);
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
        public bool CreateCdBhaBitT(string jsonData)
        {
            return cdBhaCompBitTRepository.Create(jsonData);
        }
        #endregion

        #region CdCementFluidScheduleT
        public IEnumerable<CdCementFluidScheduleT> GetCdCementFluidSchedule()
        {
            return cdCementFluidScheduleTRepository.GetRows();
        }

        public bool CreateCdCementFluidSchedule(string jsonData)
        {
            return cdCementFluidScheduleTRepository.Create(jsonData);
        }

        public bool UpdateCdCementFluidSchedule(string Id, string jsonData)
        {
            return cdCementFluidScheduleTRepository.Update(Id, jsonData);
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

        public bool CreateCdCementFluidT(string jsonData)
        {
            return cdCementFluidTRepository.Create(jsonData);
        }

        public bool UpdateCdCementFluidT(string Id, string jsonData)
        {
            return cdCementFluidTRepository.Update(Id, jsonData);
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

        public bool CreateCdCementJobT(string jsonData)
        {
            return cdCementJobTRepository.Create(jsonData);
        }

        public bool UpdateCdCementJobT(string Id, string jsonData)
        {
            return cdCementJobTRepository.Update(Id, jsonData);
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

        public bool CreateCdCementStatusT(string jsonData)
        {
            return cdCementPlugStatusTRepository.Create(jsonData);
        }

        public bool UpdateCdCementStatusT(string Id, string jsonData)
        {
            return cdCementPlugStatusTRepository.Update(Id, jsonData);
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

        public bool CreateCdCementStageT(string jsonData)
        {
            return cdCementStageTRepository.Create(jsonData);
        }

        public bool UpdateCdCementStageT(string Id, string jsonData)
        {
            return cdCementStageTRepository.Update(Id, jsonData);
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

        public bool CreateCdDatumT(string jsonData)
        {
            return cdDatumTRepository.Create(jsonData);
        }

        public bool UpdateCdDatumT(string Id, string jsonData)
        {
            return cdDatumTRepository.Update(Id, jsonData);
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

        public bool CreateCdDefinitiveSurveyHeaderT(string jsonData)
        {
            return cdDefinitiveSurveyHeaderTRepository.Create(jsonData);
        }

        public bool UpdateCdDefinitiveSurveyHeaderT(string Id, string jsonData)
        {
            return cdDefinitiveSurveyHeaderTRepository.Update(Id, jsonData);
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

        public bool CreateCdFluidT(string jsonData)
        {
            return cdFluidTRepository.Create(jsonData);
        }

        public bool UpdateCdFluidT(string Id, string jsonData)
        {
            return cdFluidTRepository.Update(Id, jsonData);
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

        public bool CreateCdHoleSectGroupT(string jsonData)
        {
            return cdHoleSectGroupTRepository.Create(jsonData);
        }

        public bool UpdateCdHoleSectGroupT(string Id, string jsonData)
        {
            return cdHoleSectGroupTRepository.Update(Id, jsonData);
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

        public bool CreateCdHoleSectT(string jsonData)
        {
            return cdHoleSectTRepository.Create(jsonData);
        }

        public bool UpdateCdHoleSectT(string Id, string jsonData)
        {
            return cdHoleSectTRepository.Update(Id, jsonData);
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

        public bool CreateCdPerforateT(string jsonData)
        {
            return cdPerforateTRepository.Create(jsonData);
        }

        public bool UpdateCdPerforateT(string Id, string jsonData)
        {
            return cdPerforateTRepository.Update(Id, jsonData);
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

        public bool CreateCdPolicy(string jsonData)
        {
            return cdPolicyRepository.Create(jsonData);
        }

        public bool UpdateCdPolicy(string Id, string jsonData)
        {
            return cdPolicyRepository.Update(Id, jsonData);
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

        public bool CreateCdProjectSource(string jsonData)
        {
            return cdProjectSourceRepository.Create(jsonData);
        }

        public bool UpdateCdProjectSource(string Id, string jsonData)
        {
            return cdProjectSourceRepository.Update(Id, jsonData);
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

        public bool CreateCdRig(string jsonData)
        {
            return cdRigRepository.Create(jsonData);
        }

        public bool UpdateCdRig(string Id, string jsonData)
        {
            return cdRigRepository.Update(Id, jsonData);
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

        public bool CreateCdRigAnchor(string jsonData)
        {
            return cdRigAnchorRepository.Create(jsonData);
        }

        public bool UpdateCdRigAnchor(string Id, string jsonData)
        {
            return cdRigAnchorRepository.Update(Id, jsonData);
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

        public bool CreateCdRigCentrifuge(string jsonData)
        {
            return cdRigCentrifugeRepository.Create(jsonData);
        }

        public bool UpdateCdRigCentrifuge(string Id, string jsonData)
        {
            return cdRigCentrifugeRepository.Update(Id, jsonData);
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

        public bool CreateCdRigHydroclone(string jsonData)
        {
            return cdRigHydrocloneRepository.Create(jsonData);
        }

        public bool UpdateCdRigHydroclone(string Id, string jsonData)
        {
            return cdRigHydrocloneRepository.Update(Id, jsonData);
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

        public bool CreateCdRigPump(string jsonData)
        {
            return cdRigPumpRepository.Create(jsonData);
        }

        public bool UpdateCdRigPump(string Id, string jsonData)
        {
            return cdRigPumpRepository.Update(Id, jsonData);
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

        public bool CreateCdSiteSource(string jsonData)
        {
            return cdSiteSourceRepository.Create(jsonData);
        }

        public bool UpdateCdSiteSource(string Id, string jsonData)
        {
            return cdSiteSourceRepository.Update(Id, jsonData);
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

        public bool CreateCdSurveyHeaderT(string jsonData)
        {
            return cdSurveyHeaderTRepository.Create(jsonData);
        }

        public bool UpdateCdSurveyHeaderT(string Id, string jsonData)
        {
            return cdSurveyHeaderTRepository.Update(Id, jsonData);
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

        public bool CreateCdSurveyStationT(string jsonData)
        {
            return cdSurveyStationTRepository.Create(jsonData);
        }

        public bool UpdateCdSurveyStationT(string Id, string jsonData)
        {
            return cdSurveyStationTRepository.Update(Id, jsonData);
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

        public bool CreateCdVgMeterT(string jsonData)
        {
            return cdVgMeterTRepository.Create(jsonData);
        }

        public bool UpdateCdVgMeterT(string Id, string jsonData)
        {
            return cdVgMeterTRepository.Update(Id, jsonData);
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

        public bool CreateCdWellSource(string jsonData)
        {
            return cdWellSourceRepository.Create(jsonData);
        }

        public bool UpdateCdWellSource(string Id, string jsonData)
        {
            return cdWellSourceRepository.Update(Id, jsonData);
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

        public bool CreateCdWellStatusT(string jsonData)
        {
            return cdWellStatusTRepository.Create(jsonData);
        }

        public bool UpdateCdWellStatusT(string Id, string jsonData)
        {
            return cdWellStatusTRepository.Update(Id, jsonData);
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

        public bool CreateCdWellboreFormationT(string jsonData)
        {
            return cdWellboreFormationTRepository.Create(jsonData);
        }

        public bool UpdateCdWellboreFormationT(string Id, string jsonData)
        {
            return cdWellboreFormationTRepository.Update(Id, jsonData);
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

        public bool CreateCdWellboreT(string jsonData)
        {
            return cdWellboreTRepository.Create(jsonData);
        }

        public bool UpdateCdWellboreT(string Id, string jsonData)
        {
            return cdWellboreTRepository.Update(Id, jsonData);
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

        public bool CreateDmActivityT(string jsonData)
        {
            return dmActivityTRepository.Create(jsonData);
        }

        public bool UpdateDmActivityT(string Id, string jsonData)
        {
            return dmActivityTRepository.Update(Id, jsonData);
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

        public bool CreateDmAfe(string jsonData)
        {
            return dmAfeRepository.Create(jsonData);
        }

        public bool UpdateDmAfe(string Id, string jsonData)
        {
            return dmAfeRepository.Update(Id, jsonData);
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

        public bool CreateDmAfeSupp(string jsonData)
        {
            return dmAfeSuppRepository.Create(jsonData);
        }

        public bool UpdateDmAfeSupp(string Id, string jsonData)
        {
            return dmAfeSuppRepository.Update(Id, jsonData);
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

        public bool CreateDmAnchorOpT(string jsonData)
        {
            return dmAnchorOpTRepository.Create(jsonData);
        }

        public bool UpdateDmAnchorOpT(string Id, string jsonData)
        {
            return dmAnchorOpTRepository.Update(Id, jsonData);
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

        public bool CreateDmBhaOpT(string jsonData)
        {
            return dmBhaOpTRepository.Create(jsonData);
        }

        public bool UpdateDmBhaOpT(string Id, string jsonData)
        {
            return dmBhaOpTRepository.Update(Id, jsonData);
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

        public bool CreateDmBhaRunT(string jsonData)
        {
            return dmBhaRunTRepository.Create(jsonData);
        }

        public bool UpdateDmBhaRunT(string Id, string jsonData)
        {
            return dmBhaRunTRepository.Update(Id, jsonData);
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

        public bool CreateDmBitOpT(string jsonData)
        {
            return dmBitOpTRepository.Create(jsonData);
        }

        public bool UpdateDmBitOpT(string Id, string jsonData)
        {
            return dmBitOpTRepository.Update(Id, jsonData);
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

        public bool CreateDmBulkT(string jsonData)
        {
            return dmBulkTRepository.Create(jsonData);
        }

        public bool UpdateDmBulkT(string Id, string jsonData)
        {
            return dmBulkTRepository.Update(Id, jsonData);
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

        public bool CreateDmBulkTranT(string jsonData)
        {
            return dmBulkTranTRepository.Create(jsonData);
        }

        public bool UpdateDmBulkTranT(string Id, string jsonData)
        {
            return dmBulkTranTRepository.Update(Id, jsonData);
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

        public bool CreateDmCentrifugeOpT(string jsonData)
        {
            return dmCentrifugeOpTRepository.Create(jsonData);
        }

        public bool UpdateDmCentrifugeOpT(string Id, string jsonData)
        {
            return dmCentrifugeOpTRepository.Update(Id, jsonData);
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

        public bool CreateDmCompanyDailyT(string jsonData)
        {
            return dmCompanyDailyTRepository.Create(jsonData);
        }

        public bool UpdateDmCompanyDailyT(string Id, string jsonData)
        {
            return dmCompanyDailyTRepository.Update(Id, jsonData);
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

        public bool CreateDmCompanyT(string jsonData)
        {
            return dmCompanyTRepository.Create(jsonData);
        }

        public bool UpdateDmCompanyT(string Id, string jsonData)
        {
            return dmCompanyTRepository.Update(Id, jsonData);
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

        public bool CreateDmCrCleanupT(string jsonData)
        {
            return dmCrCleanupTRepository.Create(jsonData);
        }

        public bool UpdateDmCrCleanupT(string Id, string jsonData)
        {
            return dmCrCleanupTRepository.Update(Id, jsonData);
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

        public bool CreateDmCrMudAdditiveT(string jsonData)
        {
            return dmCrMudAdditiveTRepository.Create(jsonData);
        }

        public bool UpdateDmCrMudAdditiveT(string Id, string jsonData)
        {
            return dmCrMudAdditiveTRepository.Update(Id, jsonData);
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

        public bool CreateDmDailyDitchMagnetT(string jsonData)
        {
            return dmDailyDitchMagnetTRepository.Create(jsonData);
        }

        public bool UpdateDmDailyDitchMagnetT(string Id, string jsonData)
        {
            return dmDailyDitchMagnetTRepository.Update(Id, jsonData);
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

        public bool CreateDmDailyNotificationT(string jsonData)
        {
            return dmDailyNotificationTRepository.Create(jsonData);
        }

        public bool UdateDmDailyNotificationT(string Id, string jsonData)
        {
            return dmDailyNotificationTRepository.Update(Id, jsonData);
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

        public bool CreateDmDailyT(string jsonData)
        {
            return dmDailyTRepository.Create(jsonData);
        }

        public bool UpdateDailyT(string Id, string jsonData)
        {
            return dmDailyTRepository.Update(Id, jsonData);
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

        public bool CreateDmEnvironmentalT(string jsonData)
        {
            return dmEnvironmentalTRepository.Create(jsonData);
        }

        public bool UpdateDmEnvironmentalT(string Id, string jsonData)
        {
            return dmEnvironmentalTRepository.Update(Id, jsonData);
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

        public bool CreateDmEventT(string jsonData)
        {
            return dmEventTRepository.Create(jsonData);
        }

        public bool UpdateDmEventT(string Id, string jsonData)
        {
            return dmEventTRepository.Update(Id, jsonData);
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

        public bool CreateDmHydrocloneOpT(string jsonData)
        {
            return dmHydrocloneOpTRepository.Create(jsonData);
        }

        public bool UpdateDmHydrocloneOpT(string Id, string jsonData)
        {
            return dmHydrocloneOpTRepository.Update(Id, jsonData);
        }

        public bool DeleteDmHydrocloneOpT(string Id)
        {
            return dmHydrocloneOpTRepository.Delete(Id);
        }
        #endregion
    }
}
