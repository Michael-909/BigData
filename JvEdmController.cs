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

        public JvEdmController()
        {
            dmReportJournalRepository = new DmReportJournalRepository();
            cdAssemblyCompTRepository = new CdAssemblyCompTRepository();
            cdAssemblyDetailTRepository = new CdAssemblyDetailTRepository();
            cdAssemblyTRepository = new CdAssemblyTRepository();
            cdBhaCompBitTRepository = new CdBhaCompBitTRepository();
            cdCementFluidScheduleTRepository = new CdCementFluidScheduleTRepository();
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
    }
}
