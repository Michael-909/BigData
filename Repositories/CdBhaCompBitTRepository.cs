using BigData.Models;
using System.Collections.Generic;
using System.Linq;

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

        public bool Create(CdBhaCompBitT data)
        {
            dbContext.CdBhaCompBitT.Add(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
