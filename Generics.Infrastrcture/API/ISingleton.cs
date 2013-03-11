using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Infrastrcture.API
{
    public interface ISingleton<in T>
    where T : new()
    {
        T Instance {get;}
    }
}
