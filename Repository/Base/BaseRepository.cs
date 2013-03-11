using Blackport.DataLayer.Repositories.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Base
{
    public abstract class BaseRepository<T,C> : IBaseRepository<T,C>
    where T : class, new()
    where C : class, new()
    {
        public abstract bool Create(IEnumerable<T> TSet)
        {
            return false;
        }

        public abstract IEnumerable<T> Read(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> _set = default(IEnumerable<T>);
            return _set;
        }

        public abstract bool Update(IEnumerable<T> TSet)
        {
            return false;
        }

        public abstract bool Delete(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return false;
        }

        public abstract bool Save()
        {
            return false;
        }
    }
}