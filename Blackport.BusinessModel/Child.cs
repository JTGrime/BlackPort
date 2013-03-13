using Blackport.BusinessModel.API;
using System.Collections.Generic;

namespace Blackport.BusinessModel
{
	public sealed class Child : Person, IChild
	{
		public IEnumerable<IParent>			Parents			{ get; set; }
		public IEnumerable<IChoreRequest>	ChoreRequests	{ get; set; }
		public IEnumerable<IChore>			Chores			{ get; set; }
	}
}
