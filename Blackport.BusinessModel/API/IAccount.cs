using System;
using Blackport.Infrastructure.EntityLayer;

namespace Blackport.BusinessModel.API
{
	public interface IAccount
	{
			string		UserName		{ get; set; }
			byte[]		Password		{ get; set; }
			IPerson		Person			{ get; set; }
			AccountRole Role			{ get; set; }
			Decimal		CurrentBalance	{ get; set; }

			AccountModificationState ChangePassword(byte[] oldPassword, byte[] newPassword);
			
	}
}
