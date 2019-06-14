using BotSkinsAPI.Attributes;

namespace BotSkinsAPI.Models.RequestModels
{
	public enum OrderType
	{
		[ParameterValue(Value = null)]
		All,

		[ParameterValue(Value = "listed")]
		Listed,

		[ParameterValue(Value = "settled")]
		Settled,

		[ParameterValue(Value = "cancelled_by_user")]
		CancelledByUser,

		[ParameterValue(Value = "cancelled_by_system")]
		CancelledBySystem
	}

	public class GetOrdersRequestModel : RequestBodyModel
	{
		[ParameterName(Name = "type")]
		[Required(Required = RequiredStatus.Optional)]
		public OrderType? Type { get; set; }

		[ParameterName(Name = "market_hash_name")]
		[Required(Required = RequiredStatus.Optional)]
		public string MarketHashName { get; set; }

		[ParameterName(Name = "page")]
		public int? Page { get; set; }
	}
}
