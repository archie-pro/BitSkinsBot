using Newtonsoft.Json;
using System;

namespace BotSkinsAPI.Models.ResponseModels
{
	public class SteamItemSalesResponseModel : ResponseBodyModel
	{
		[JsonProperty("market_hash_name")]
		public string MarketHashName { get; set; }

		[JsonProperty("raw_data")]
		public SteamSaleInfo[] Items { get; set; }

		[JsonProperty("updated_at")]
		public DateTime UpdatedAt { get; set; }
	}

	public class SteamSaleInfo
	{
		[JsonProperty("time")]
		public DateTime Time { get; set; }

		[JsonProperty("price")]
		public double Price { get; set; }

		[JsonProperty("volume")]
		public long Volume { get; set; }
	}
}
