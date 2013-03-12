using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blackport.DataLayer.Repositories.API;
using Blackport.Infrastructure.EntityFramework.API;
using Blackport.Repository.Test.Base_Repository_Tests.Test_Helpers.API;
using System.Collections.Generic;
using Blackport.Repository.Test.Base_Repository_Tests.Test_Helpers;
using Blackport.Infrastructure.EntityFramework;

namespace Blackport.Repository.Test
{
    [TestClass]
    internal class BaseRepositoryTestSet
    {
        private IBaseRepositoryTStub _stub;
				private IBaseRepository<BaseRepositoryTStub, DbContextWrapper> _repository;
         
        [TestInitialize]
				public void Setup(IBaseRepository<BaseRepositoryTStub, DbContextWrapper> baseRepository,
                          IBaseRepositoryTStub stub)
        {
						_repository = baseRepository;
            _stub = stub;
        }

        #region Create
        [TestMethod]
        public void BaseRepository_Create_AssertCreateCommandPersistsCommandSet()
        {
						//var result = _repository.Create();
            //Assert.IsTrue(result);
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