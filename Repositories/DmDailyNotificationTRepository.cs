﻿using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmDailyNotificationTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmDailyNotificationTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmDailyNotificationT> GetRows()
        {
            return dbContext.DmDailyNotificationT.Select(x => x).ToList();
        }

        public bool Create(DmDailyNotificationT data)
        {
            data.DailyNotificationId = NormalHelper.GenerateNormalKey();
            dbContext.DmDailyNotificationT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmDailyNotificationT data)
        {
            var model = dbContext.DmDailyNotificationT.SingleOrDefault(x => x.DailyNotificationId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmDailyNotificationT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmDailyNotificationT.Where(x => x.DailyNotificationId == Id);
            dbContext.DmDailyNotificationT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
