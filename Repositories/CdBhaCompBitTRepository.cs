using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdBhaCompBitTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdBhaCompBitTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdBhaCompBitT> GetRows()
        {
            return dbContext.CdBhaCompBitT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdBhaCompBitT>(jsonData);
            dbContext.CdBhaCompBitT.Add(model);
            return dbContext.SaveChanges() > 0;
        }
    }
}
