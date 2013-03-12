using System;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Blackport.DataLayer.Repositories.API
{
    /// <summary>
    ///     IBaseRepository&lt;in T, in C&gt; provides abstraction from the generic concrete implementation.
    ///     The class' sole responsibility is to media simple CRUD commands to the ORM mapped Object Model.  
    /// </summary>
    /// <typeparam name="TType">Represents domain model (POCO) or IQueryable&lt;T&gt;</typeparam>
		/// <typeparam name="TCtx">Represents EntityFramework Model ObjectContext for data retrieval</typeparam>
    public interface IBaseRepository<TType, TCtx>
    where TType : class, new()
		where TCtx : DbContext, new()
    {
        //Create
        /// <summary>
        ///     Creates a set of database entities, which map to the domain model equivalent of IEnumerable&lt;T&gt;
        /// </summary>
				/// <param name="set">IEnumerable&lt;T&gt;</param>
        /// <returns></returns>
        bool Create(IEnumerable<TType> set);

        //Read
        /// <summary>
        ///     Read Operation performed on the main ObjectContext
        /// </summary>
        /// <param name="predicate">
        ///     Lambda expression used i.e.
        ///     <code>
        ///       (x) => { 
        ///                   //Do Something...
        ///                   Return True | False
        ///              }
        ///     </code>
        /// </param>
        /// <returns>
        ///     IEnumerable&lt;T&gt; populated by entities that match the predicate passed in.
        /// </returns>
        IEnumerable<TType> Read(Func<TType, bool> predicate);

        //Update
        /// <summary>
        ///     Update n entities base on the predicate condition based in
        /// </summary>
				/// <param name="set">
        ///     IEnumerable&lt;T&gt; sequence of mutated entities,
        ///     to be updated within the persisted store. 
        /// </param>
        bool Update(IEnumerable<TType> set);

        //Delete
        /// <summary>
        /// Deletes entities within the store based off 
        /// the predatory condition passed to the repository.
        /// </summary>
        /// <param name="predicate">
        ///     Lambda expression used i.e.
        ///     <code>
        ///       (x) => { 
        ///                   //Do Something...
        ///                   Return True | False
        ///              }
        ///     </code>
        /// </param>
        bool Delete(Func<TType, bool> predicate);

        //Save
        /// <summary>
        ///     Persists current change set to the database engine from volatile memory.
        /// </summary>
        /// <returns>
        /// Boolean value to determine weather the operation was successful or not.
        /// </returns>
        bool Save();
    }
}