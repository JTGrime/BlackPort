using Blackport.DataLayer.Repositories.API;
using Repository.Base.API;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Base
{
    public sealed class DbCtxBaseRepository<T,C> : BaseRepository<T,C>, IDbCtxBaseRepository<T,C>
    where T : class, new()
    where C : DbContext, new()
    {
        private C _dbCtx;
        public C DataContext 
        {
            get
            {
                return _dbCtx;
            }
        }

        public DbCtxBaseRepository()
        {
            _dbCtx = new C();
        }

        public override sealed bool IBaseRepository<T, C>.Create(IEnumerable<T> TSet)
        {
            IDbSet<T>       _dbSet  = _dbCtx.Set<T>();
            IEnumerable<T>  _tSet   = TSet;
            bool            _result = true;

            foreach (T _TEntity in _tSet)
            {
                if (!((_dbSet.Add(_TEntity)).Equals(_TEntity)))
                {
                    _result = false;
                }
                AmmendEntityState(_TEntity, System.Data.EntityState.Added);
            }
            return _result;
        }

        public override sealed IEnumerable<T> IBaseRepository<T, C>.Read(Func<T, bool> predicate)
        {
            return _dbCtx.Set<T>().Where<T>(predicate) as IEnumerable<T>;
        }

        public override sealed bool IBaseRepository<T, C>.Update(IEnumerable<T> tSet)
        {
            IEnumerable<T>  _tSet   = tSet;
            bool            _result = true;

            foreach(T _TEntity in _tSet)
            {
                if (!(_dbCtx.Set<T>().Attach(_TEntity).Equals(_TEntity)))
                {
                    _result = false;
                }
                AmmendEntityState(_TEntity, System.Data.EntityState.Modified);
            }
            return _result;
        }

        public override sealed bool IBaseRepository<T, C>.Delete(Func<T, bool> predicate)
        {
            IDbSet<T>   _set    = _dbCtx.Set<T>();
            bool        _result = true;

            foreach(T _TEntity in _set.Where<T>(predicate))
            {
                if(!(_set.Remove(_TEntity).Equals(_TEntity)))
                {
                    _result = false;
                }
                AmmendEntityState(_TEntity, System.Data.EntityState.Deleted);
            }
            return _result;
        }

        public override sealed bool IBaseRepository<T, C>.Save()
        {
            return _dbCtx.SaveChanges() > 0;
        }

        private void AmmendEntityState(T entity, System.Data.EntityState entityState)
        {
            _dbCtx.Entry<T>(entity).State = entityState;
        }
    }
} 