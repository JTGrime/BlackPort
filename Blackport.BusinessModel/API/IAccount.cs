using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackport.Infrastructure.EntityLayer;

namespace Blackport.BusinessModel.API
{
	public interface IAccount
	{
			string UserName { get; set; }
			byte[] Password { get; set; }
			IPerson Person	{ get; set; }
			AccountRole Role { get; set; }

			AccountModificationState ChangePassword(byte[] oldPassword, byte[] newPassword);
			
	}
}
