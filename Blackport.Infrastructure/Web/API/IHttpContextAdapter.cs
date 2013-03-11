using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace Blackport.Infrastructure.Web.API
{
    public interface IHttpContextAdapter
    {
        HttpContext Current { get; set; }
    }
}
