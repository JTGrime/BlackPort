using Blackport.DataLayer.Repositories.API;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Base.API
{
	public interface IDbCtxBaseRepository<TType, TCtx> : IBaseRepository<TType, TCtx>
		where TType : class, new()
		where TCtx : DbContext, new()
    {
    }
}