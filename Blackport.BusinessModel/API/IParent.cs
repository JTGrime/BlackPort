using System.Collections.Generic;

namespace Blackport.BusinessModel.API
{
	public interface IParent
	{
		IEnumerable<IChild>			Children				{ get; set; }
		IEnumerable<IChoreRequest>	PendingChoreRequests	{ get; set; }
		IEnumerable<IChore>			PendingChores			{ get; set; }
	}
}
