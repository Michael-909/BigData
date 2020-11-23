using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdDefinitiveSurveyHeaderTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdDefinitiveSurveyHeaderTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdDefinitiveSurveyHeaderT> GetRows()
        {
            return dbContext.CdDefinitiveSurveyHeaderT.Select(x => x).ToList();
        }

        public bool Create(CdDefinitiveSurveyHeaderT data)
        {
            data.DefSurveyHeaderId = NormalHelper.GenerateNormalKey();
            dbContext.CdDefinitiveSurveyHeaderT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdDefinitiveSurveyHeaderT data)
        {
            var model = dbContext.CdDefinitiveSurveyHeaderT.SingleOrDefault(x => x.DefSurveyHeaderId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdDefinitiveSurveyHeaderT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdDefinitiveSurveyHeaderT.Where(x => x.DefSurveyHeaderId == Id);
            dbContext.CdDefinitiveSurveyHeaderT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
