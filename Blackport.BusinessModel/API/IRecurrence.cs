using Blackport.BusinessModel.API.ServiceAPI;
using System;

namespace Blackport.BusinessModel.API
{
	public interface IRecurrence
	{
		DateTime			StartTime			{ get; set; }
		DateTime			EndTime				{ get; set; }
		IRecurrenceMetric	RecurrenceMetric	{ get; set; }
	}
}
