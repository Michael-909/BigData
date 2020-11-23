using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

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

        public bool Create(CdSurveyStationT data)
        {
            data.SurveyId = NormalHelper.GenerateNormalKey();
            dbContext.CdSurveyStationT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdSurveyStationT data)
        {
            var model = dbContext.CdSurveyStationT.SingleOrDefault(x => x.SurveyId == Id);
            if (model == null) return false;
            model = data;
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
