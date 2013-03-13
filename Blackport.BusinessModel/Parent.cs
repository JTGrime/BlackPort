using Blackport.BusinessModel.API;
using System.Collections.Generic;

namespace Blackport.BusinessModel
{
	public sealed class Parent : Person, IParent
	{
		public IEnumerable<IChild>			Children				{ get; set; }
		public IEnumerable<IChoreRequest>	PendingChoreRequests	{ get; set; }
		public IEnumerable<IChore>			PendingChores			{ get; set; }
	}
}
