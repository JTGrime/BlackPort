using Blackport.Repository.Test.Base_Repository_Tests.Test_Helpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blackport.Repository.Test.Base_Repository_Tests.Test_Helpers
{
    internal sealed class BaseRepositoryTStub : IBaseRepositoryTStub
    {
        private int                 _id;
        private static int          _totalObjectCount;
        private BaseRepositoryTStub _instance;
        private Func<int, int, int> _calculate;
        
        private BaseRepositoryTStub()
        {
            _totalObjectCount++;
            this._id = ++_totalObjectCount;
        }

        public BaseRepositoryTStub Instance
        {
            get
            {
                if ((_instance == null) && (_totalObjectCount < 1))
                {
                    _instance = new BaseRepositoryTStub();
                }
                return _instance;
            }
            set
            {
                _instance = (_totalObjectCount == 0) ? value : _instance;
            }
        }

        public int Calculate(int x, int y, Func<int, int, int> func)
        {
            return func(x, y);
        }
    }
}