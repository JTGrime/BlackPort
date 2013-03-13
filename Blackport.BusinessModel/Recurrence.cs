using Blackport.BusinessModel.API;
using Blackport.BusinessModel.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackport.BusinessModel
{
	public class Recurrence : SuperType, IRecurrence
	{
		public DateTime				StartTime			{ get; set; }
		public DateTime				EndTime				{ get; set; }
		public IRecurrenceMetric	RecurrenceMetric	{ get; set; }
	}
}
