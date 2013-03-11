using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blackport.DataLayer.Repositories.API;
using Blackport.Infrastructure.EntityFramework.API;
using Blackport.Repository.Test.Base_Repository_Tests.Test_Helpers.API;
using System.Collections.Generic;

namespace Blackport.Repository.Test
{
    [TestClass]
    public class BaseRepositoryTestSet
    {
        private IBaseRepositoryTStub _stub;
        private IEnumerable<IBaseRepositoryTStub> _commandSet;
        private IBaseRepository<IBaseRepositoryTStub, IObjectContextWrapper> _Repository;
         
        [TestInitialize]
        public void Setup(IBaseRepository<IBaseRepositoryTStub, IObjectContextWrapper> baseRepository,
                          IBaseRepositoryTStub stub)
        {
            _Repository = baseRepository;
            _stub = stub;

            _commandSet = new List<IBaseRepositoryTStub>()
            {
                _stub
            };
        }

        #region Create
        [TestMethod]
        public void BaseRepository_Create_AssertCreateCommandPersistsCommandSet()
        {
            var result = _Repository.Create(_commandSet);
            Assert.IsTrue(result);
        }
        #endregion

        #region Read
        [TestMethod]
        public void BaseRepository_Read_AssertReadQueryExecutes()
        {

        }
        #endregion

        #region Update

        #endregion

        #region Delete

        #endregion
    }
}