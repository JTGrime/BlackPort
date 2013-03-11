using Blackport.Infrastructure.EntityFramework.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackport.Infrastructure.EntityFramework
{
    public class ObjectContextWrapper : System.Data.Objects.ObjectContext, IObjectContextWrapper
    {
        private int _objectContextWrapperInstanceCount;

        public ObjectContextWrapper() 
            : base(@"metadata=res://*/Blackport.csdl|res://*/Blackport.ssdl|res://*/Blackport.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=FAMILY-HUB\CENTRALSQL;initial catalog=Blackport;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;")
        {
            _objectContextWrapperInstanceCount++;

        }

        private void Get()
        {

        }

        private void Set()
        {

        }

    }
}