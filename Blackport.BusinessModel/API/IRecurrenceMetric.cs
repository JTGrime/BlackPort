
namespace Blackport.BusinessModel.API
{
	public interface IRecurrenceMetric
	{
		int						Id		{ get; set; }
		RecurrenceMetricType	Metric	{ get; set; }
		int						Value	{ get; set; }
	}
}
