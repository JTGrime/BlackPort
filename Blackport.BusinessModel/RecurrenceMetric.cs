using Blackport.BusinessModel.API;

namespace Blackport.BusinessModel
{
	public struct RecurrenceMetric : IRecurrenceMetric
	{
		public int					Id		{ get; set; }
		public RecurrenceMetricType Metric	{ get; set; }
		public int					Value	{ get; set; }
	}
}
