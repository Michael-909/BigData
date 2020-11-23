using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmWeatherCheckTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmWeatherCheckTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmWeatherCheckT> GetRows()
        {
            return dbContext.DmWeatherCheckT.Select(x => x).ToList();
        }

        public bool Create(DmWeatherCheckT data)
        {
            data.WeatherCheckId = NormalHelper.GenerateNormalKey();
            dbContext.DmWeatherCheckT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmWeatherCheckT data)
        {
            var model = dbContext.DmWeatherCheckT.SingleOrDefault(x => x.WeatherCheckId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmWeatherCheckT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmWeatherCheckT.Where(x => x.WeatherCheckId == Id);
            dbContext.DmWeatherCheckT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
