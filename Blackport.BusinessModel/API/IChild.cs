using System.Collections.Generic;

namespace Blackport.BusinessModel.API
{
	public interface IChild
	{
		IEnumerable<IParent>		Parents			{ get; set; }
		IEnumerable<IChoreRequest>	ChoreRequests	{ get; set; }
		IEnumerable<IChore>			Chores			{ get; set; }
	}
}
