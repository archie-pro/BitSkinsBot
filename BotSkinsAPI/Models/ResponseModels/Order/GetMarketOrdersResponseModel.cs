using Newtonsoft.Json;
using System;

namespace BotSkinsAPI.Models.ResponseModels
{
	public class GetMarketOrdersResponseModel : ResponseBodyModel
	{
		[JsonProperty("total")]
		public long Total { get; set; }

		[JsonProperty("orders")]
		public MarketOrder[] Orders { get; set; }
	}

	public class MarketOrder
	{
		[JsonProperty("buy_order_id")]
		public string BuyOrderId { get; set; }

		[JsonProperty("market_hash_name")]
		public string MarketHashName { get; set; }

		[JsonProperty("price")]
		public double Price { get; set; }

		[JsonProperty("suggested_price")]
		public double SuggestedPrice { get; set; }

		[JsonProperty("is_mine")]
		public bool IsMine { get; set; }

		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }

		[JsonProperty("place_in_queue")]
		public long PlaceInQueue { get; set; }
	}
}
