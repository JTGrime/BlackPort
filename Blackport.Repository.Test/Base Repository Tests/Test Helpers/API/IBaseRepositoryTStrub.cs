﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackport.Repository.Test.Base_Repository_Tests.Test_Helpers.API
{
    internal interface IBaseRepositoryTStub
    {
        BaseRepositoryTStub Instance { get; set; }
        int Calculate(Func<int, int, int> func = null, int x = 0, int y = 0);
    }
}
