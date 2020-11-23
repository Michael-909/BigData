using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
	public class CdAssemblyDetailTRepository
	{
		private readonly jv_edm_dbContext dbContext;

		public CdAssemblyDetailTRepository()
		{
			dbContext = new jv_edm_dbContext();
		}

		public IEnumerable<CdAssemblyDetailT> GetRows()
		{
			return dbContext.CdAssemblyDetailT.Select(x => x).ToList();
		}

		public bool Create(CdAssemblyDetailT data)
		{
			data.AssemblyDetailId = NormalHelper.GenerateNormalKey();
			dbContext.CdAssemblyDetailT.Add(data);
			return dbContext.SaveChanges() > 0;
		}

		public bool Update(string Id, CdAssemblyDetailT data)
		{
			var model = dbContext.CdAssemblyDetailT.SingleOrDefault(x => x.AssemblyDetailId == Id);
			if (model == null) return false;
			model = data;
			dbContext.CdAssemblyDetailT.Update(model);
			return dbContext.SaveChanges() > 0;
		}

		public bool Delete(string Id)
		{
			var data = dbContext.CdAssemblyDetailT.Where(x => x.AssemblyDetailId == Id);
			dbContext.CdAssemblyDetailT.RemoveRange(data);
			return dbContext.SaveChanges() > 0;
		}
	}
}
