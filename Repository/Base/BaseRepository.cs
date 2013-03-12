using Blackport.DataLayer.Repositories.API;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Base
{
	public abstract class BaseRepository<TType, TCtx> : IBaseRepository<TType, TCtx>
		where TType : class, new()
		where TCtx : DbContext, new()
	{
		public virtual bool Create(IEnumerable<TType> set)
		{
			return false;
		}

		public virtual IEnumerable<TType> Read(Func<TType, bool> predicate)
		{
			return null;
		}

		public virtual bool Update(IEnumerable<TType> set)
		{
			return false;
		}

		public virtual bool Delete(Func<TType, bool> predicate)
		{
			return false;
		}

		public virtual bool Save()
		{
			return false;
		}
	}
}