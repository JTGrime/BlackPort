using Blackport.DataLayer.Repositories.API;
using Repository.Base.API;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Base
{
	public sealed class DbCtxBaseRepository<TType, TCtx> : BaseRepository<TType, TCtx>, IDbCtxBaseRepository<TType, TCtx>
		where TType : class, new()
		where TCtx : DbContext, new()
	{
		private readonly TCtx _dbCtx;
		public TCtx DataContext
		{
			get
			{
				return _dbCtx;
			}
		}

		public DbCtxBaseRepository()
		{
			_dbCtx = new TCtx();
		}

		public override bool Create(IEnumerable<TType> set)
		{
			IDbSet<TType> dbSet = _dbCtx.Set<TType>();
			IEnumerable<TType> tSet = set;
			bool result = true;

			foreach (TType entity in tSet)
			{
				if (!((dbSet.Add(entity)).Equals(entity)))
				{
					result = false;
				}
				AmmendEntityState(entity, System.Data.EntityState.Added);
			}
			return result;
		}

		public override IEnumerable<TType> Read(Func<TType, bool> predicate)
		{
			return _dbCtx.Set<TType>().Where<TType>(predicate) as IEnumerable<TType>;
		}

		public override bool Update(IEnumerable<TType> set)
		{
			IEnumerable<TType> tSet = set;
			bool result = true;

			foreach (TType entity in tSet)
			{
				if (!(_dbCtx.Set<TType>().Attach(entity).Equals(entity)))
				{
					result = false;
				}
				AmmendEntityState(entity, System.Data.EntityState.Modified);
			}
			return result;
		}

		public override bool Delete(Func<TType, bool> predicate)
		{
			IDbSet<TType> set = _dbCtx.Set<TType>();
			bool result = true;

			foreach (TType entity in set.Where<TType>(predicate))
			{
				if (!(set.Remove(entity).Equals(entity)))
				{
					result = false;
				}
				AmmendEntityState(entity, System.Data.EntityState.Deleted);
			}
			return result;
		}

		public override bool Save()
		{
			return _dbCtx.SaveChanges() > 0;
		}

		private void AmmendEntityState(TType entity, System.Data.EntityState entityState)
		{
			_dbCtx.Entry<TType>(entity).State = entityState;
		}
	}
}