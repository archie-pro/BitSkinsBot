using Newtonsoft.Json;
using System;

namespace BotSkinsAPI.Models.ResponseModels
{
	public class BitskinsItemSalesResponseModel : ResponseBodyModel
	{
		[JsonProperty("sales")]
		public BitSkinsSaleInfo[] Sales { get; set; }
	}

	public class BitSkinsSaleInfo
	{
		[JsonProperty("market_hash_name")]
		public string MarketHashName { get; set; }

		[JsonProperty("price")]
		public double Price { get; set; }

		[JsonProperty("wear_value")]
		public double WearValue { get; set; }

		[JsonProperty("sold_at")]
		public DateTime SoldAt { get; set; }
	}
}
