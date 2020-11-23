using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
	public class CdAssemblyCompTRepository
	{
		private readonly jv_edm_dbContext dbContext;

		public CdAssemblyCompTRepository()
		{
			dbContext = new jv_edm_dbContext();
		}

		public IEnumerable<CdAssemblyCompT> GetRows()
		{
			return dbContext.CdAssemblyCompT.Select(x => x).ToList();
		}

		public bool Create(CdAssemblyCompT data)
		{
			data.AssemblyCompId = NormalHelper.GenerateNormalKey();
			dbContext.CdAssemblyCompT.Add(data);
			return dbContext.SaveChanges() > 0;
		}

		public bool Update(string Id, CdAssemblyCompT data)
		{
			var model = dbContext.CdAssemblyCompT.SingleOrDefault(x => x.AssemblyCompId == Id);
			if (model == null) return false;
			model = data;
			dbContext.CdAssemblyCompT.Update(model);
			return dbContext.SaveChanges() > 0;
		}

		public bool Delete(string Id)
		{
			var data = dbContext.CdAssemblyCompT.Where(x => x.AssemblyCompId == Id);
			dbContext.CdAssemblyCompT.RemoveRange(data);
			return dbContext.SaveChanges() > 0;
		}
	}
}
