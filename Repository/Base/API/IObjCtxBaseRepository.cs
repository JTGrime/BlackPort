using Blackport.DataLayer.Repositories.API;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Base.API
{
    public interface IObjCtxBaseRepository<in T, in C> : IBaseRepository<T,C>
    where T : class, new()
    where C : ObjectContext, new()
    {
    }
}
