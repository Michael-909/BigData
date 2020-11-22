using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdSurveyStationTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdSurveyStationTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdSurveyStationT> GetRows()
        {
            return dbContext.CdSurveyStationT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdSurveyStationT>(jsonData);
            model.SurveyId = NormalHelper.GenerateNormalKey();
            dbContext.CdSurveyStationT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdSurveyStationT.SingleOrDefault(x => x.SurveyId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdSurveyStationT>(jsonData);
            dbContext.CdSurveyStationT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdSurveyStationT.Where(x => x.SurveyId == Id);
            dbContext.CdSurveyStationT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
