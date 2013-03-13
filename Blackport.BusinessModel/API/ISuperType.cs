using System;

namespace Blackport.BusinessModel.API
{
	public interface ISuperType
	{
		int			Id			{ get; set; }
		DateTime	Created		{ get; set; }
		DateTime	LastEdit	{ get; set; }
	}
}