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
        public bool Create(string jsonData)
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
    }
}
