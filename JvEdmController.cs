﻿using BigData.Models;
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

        public bool Create(string jsonData)
        {
            return cdSiteSourceRepository.Create(jsonData);
        }

        public bool Update(string Id, string jsonData)
        {
            return cdSiteSourceRepository.Update(Id, jsonData);
        }

        public bool Delete(string Id)
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
    }
}
