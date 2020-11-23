using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
	public class CdAssemblyTRepository
	{
		private readonly jv_edm_dbContext dbContext;

		public CdAssemblyTRepository()
		{
			dbContext = new jv_edm_dbContext();
		}

		public IEnumerable<CdAssemblyT> GetRows()
		{
			return dbContext.CdAssemblyT.Select(x => x).ToList();
		}

		public bool Create(CdAssemblyT data)
		{
			data.AssemblyId = NormalHelper.GenerateNormalKey();
			dbContext.CdAssemblyT.Add(data);
			return dbContext.SaveChanges() > 0;
		}

		public bool Update(string Id, CdAssemblyT data)
		{
			var model = dbContext.CdAssemblyT.SingleOrDefault(x => x.AssemblyId == Id);
			if (model == null) return false;
			model = data;
			dbContext.CdAssemblyT.Update(model);
			return dbContext.SaveChanges() > 0;
		}

		public bool Delete(string Id)
		{
			var data = dbContext.CdAssemblyT.Where(x => x.AssemblyId == Id);
			dbContext.CdAssemblyT.RemoveRange(data);
			return dbContext.SaveChanges() > 0;
		}
	}
}
