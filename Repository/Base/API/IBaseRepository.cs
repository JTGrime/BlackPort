using System;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Blackport.DataLayer.Repositories.API
{
    /// <summary>
    ///     IBaseRepository&lt;in T, in C&gt; provides abstraction from the generic concrete implementation.
    ///     The class' sole responsibility is to media simple CRUD commands to the ORM mapped Object Model.  
    /// </summary>
    /// <typeparam name="T">Represents domain model (POCO) or IQueryable&lt;T&gt;</typeparam>
    /// <typeparam name="C">Represents EntityFramework Model ObjectContext for data retrieval</typeparam>
    public abstract interface IBaseRepository<in T, in C>
    where T : class, new()
    where C : ObjectContext, new()
    {
        //Create
        /// <summary>
        ///     Creates a set of database entities, which map to the domain model equivalent of IEnumerable&lt;T&gt;
        /// </summary>
        /// <param name="TSet">IEnumerable&lt;T&gt;</param>
        /// <returns></returns>
        abstract bool Create(IEnumerable<T> TSet);

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
        abstract IEnumerable<T> Read(Expression<Func<T, bool>> predicate);

        //Update
        /// <summary>
        ///     Update n entities base on the predicate condition based in
        /// </summary>
        /// <param name="predicate">
        ///     IEnumerable&lt;T&gt; sequence of mutated entities,
        ///     to be updated within the persisted store. 
        /// </param>
        /// <param name="predicate">
        ///     Lambda expression used i.e.
        ///     <code>
        ///       (x) => { 
        ///                   //Do Something...
        ///                   Return True | False
        ///              }
        ///     </code>
        /// </param>
        abstract bool Update(IEnumerable<T> TSet);

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
        abstract bool Delete(Expression<Func<T, bool>> predicate);

        //Save
        /// <summary>
        ///     Persists current change set to the database engine from volatile memory.
        /// </summary>
        /// <returns>
        /// Boolean value to determine weather the operation was sucessful or not.
        /// </returns>
        abstract bool Save();
    }
}
/// <copyright>
///     <copyright-notice>
///         Copyright 2013 JTGrime, All rights reserved.
///     </copyright-notice>
///     <objext-type type="generic-interface" namespac="Blackport.Repository.Base.API" access="public" />
///     <object-summary>
///         IBaseRepository&lt;in T, in C&gt; provides abstraction from the generic concrete implementation.
///         The class' sole responsibility is to media simple CRUD commands to the ORM mapped Object Model.  
///     </object-summary>
///     <author first-name="James" initial="T" Surname="Grime" handle="JTGrime" email="jtgrime@gmail.com" />
/// </copyright>