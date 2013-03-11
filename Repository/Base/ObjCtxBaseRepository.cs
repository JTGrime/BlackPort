using Blackport.DataLayer.Repositories.Base.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace Blackport.DataLayer.Repositories.Base
{
    protected class ObjCtxBaseRepository<T, C> : IBaseRepository<T, C>
    where T : class, new()
    where C : ObjectContext, new()
    {

        private C _ObjCtx = new C();
        public ObjCtxBaseRepository()
        {
            C _ObjCtx = new C();
        }

        /// <summary>
        /// Gets or sets the DataContext of the repository,
        /// implementing lazy initialisation.
        /// </summary>
        protected virtual C ObjectContext
        {
            get { return _ObjCtx; }
            private set 
            {
                if (_ObjCtx != value){_ObjCtx = value;}
            }
        }

        public bool Create(IEnumerable<T> TSet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Read(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<T> TSet, Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}


//var set = _ObjCtx.CreateObjectSet<T>();
//return set.Where<T>(predicate);