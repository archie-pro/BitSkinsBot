using BotSkinsAPI.Attributes;

namespace BotSkinsAPI.Models.RequestModels
{
	public class BuyItemsRequestModel : ItemsPricesRequestModel
	{
		[ParameterName(Name = "auto_trade")]
		[Required(Required = RequiredStatus.Optional)]
		public bool? AllowAutoTrade { get; set; }

		[ParameterName(Name = "allow_trade_delayed_purchases")]
		[Required(Required = RequiredStatus.Optional)]
		public bool? AllowTradeDelayedPurchases { get; set; }
	}
}
