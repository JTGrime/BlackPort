using Blackport.BusinessModel.API;
using Blackport.BusinessModel.EntityLayer;
using Blackport.Infrastructure.EntityLayer;
using System;

namespace Blackport.BusinessModel
{
	public sealed class Account : SuperType, IAccount
	{
			public string		UserName		{ get; set; }

			public byte[]		Password		{ get; set; }

			public IPerson		Person			{ get; set; }

			public AccountRole	Role			{ get; set; }

			public Decimal		CurrentBalance	{ get; set; }	

			public AccountModificationState ChangePassword(byte[] oldPassword, byte[] newPassword)
			{
					// TODO : Implement Method - JTG 13/03/2012
					return default(AccountModificationState);
			}
	}
}
