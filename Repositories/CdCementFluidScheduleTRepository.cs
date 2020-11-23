using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
	public class CdCementFluidScheduleTRepository
	{
		private readonly jv_edm_dbContext dbContext;

		public CdCementFluidScheduleTRepository()
		{
			dbContext = new jv_edm_dbContext();
		}

		public IEnumerable<CdCementFluidScheduleT> GetRows()
		{
			return dbContext.CdCementFluidScheduleT.Select(x => x).ToList();
		}

		public bool Create(CdCementFluidScheduleT data)
		{
			data.FluidScheduleId = NormalHelper.GenerateNormalKey();
			dbContext.CdCementFluidScheduleT.Add(data);
			return dbContext.SaveChanges() > 0;
		}

		public bool Update(string Id, CdCementFluidScheduleT data)
		{
			var model = dbContext.CdCementFluidScheduleT.SingleOrDefault(x => x.FluidScheduleId == Id);
			if (model == null) return false;
			model = data;
			dbContext.CdCementFluidScheduleT.Update(model);
			return dbContext.SaveChanges() > 0;
		}

		public bool Delete(string Id)
		{
			var model = dbContext.CdCementFluidScheduleT.Where(x => x.FluidScheduleId == Id);
			dbContext.CdCementFluidScheduleT.RemoveRange(model);
			return dbContext.SaveChanges() > 0;
		}
	}
}
