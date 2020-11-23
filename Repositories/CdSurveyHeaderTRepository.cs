using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdSurveyHeaderTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdSurveyHeaderTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdSurveyHeaderT> GetRows()
        {
            return dbContext.CdSurveyHeaderT.Select(x => x).ToList();
        }

        public bool Create(CdSurveyHeaderT data)
        {
            data.SurveyHeaderId = NormalHelper.GenerateNormalKey();
            dbContext.CdSurveyHeaderT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdSurveyHeaderT data)
        {
            var model = dbContext.CdSurveyHeaderT.SingleOrDefault(x => x.SurveyHeaderId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdSurveyHeaderT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdSurveyHeaderT.Where(x => x.SurveyHeaderId == Id);
            dbContext.CdSurveyHeaderT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
