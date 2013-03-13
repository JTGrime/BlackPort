using Blackport.BusinessModel.API;
using System;

namespace Blackport.BusinessModel.EntityLayer
{
	public abstract class SuperType : ISuperType
	{
			public virtual int Id { get; set; }

			public virtual DateTime Created { get; set; }

			public virtual DateTime LastEdit { get; set; }
	}
}
