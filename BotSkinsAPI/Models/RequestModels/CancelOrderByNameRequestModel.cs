using BotSkinsAPI.Attributes;

namespace BotSkinsAPI.Models.RequestModels
{
	public class CancelOrderByNameRequestModel : RequestBodyModel
	{
		[ParameterName(Name = "market_hash_name")]
		public string MarketHashName { get; set; }
	}
}
