using Blackport.DataLayer.Repositories.API;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Base.API
{
    public interface IDbCtxBaseRepository<in T, in C> : IBaseRepository<T, C>
    where T : class, new()
    where C : DbContext, new()
    {
    }
}