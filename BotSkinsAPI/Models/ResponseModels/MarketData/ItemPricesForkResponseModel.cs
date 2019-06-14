using BotSkinsAPI.Models.ResponseModels;
using Newtonsoft.Json;
using System;

namespace BotSkinsAPI
{
	public class ItemPricesForkResponseModel: ResponseBodyModel
	{
		[JsonProperty("items")]
		public ItemPriceFork[] Items { get; set; }
	}

	public class ItemPriceFork
	{
		[JsonProperty("market_hash_name")]
		public string MarketHashName { get; set; }

		[JsonProperty("total_items")]
		public long TotalItems { get; set; }

		[JsonProperty("lowest_price")]
		public double LowestPrice { get; set; }

		[JsonProperty("highest_price")]
		public double HighestPrice { get; set; }

		[JsonProperty("cumulative_price")]
		public double CumulativePrice { get; set; }

		[JsonProperty("recent_sales_info")]
		public RecentSalesInfo RecentSalesInfo { get; set; }

		[JsonProperty("updated_at")]
		public DateTime UpdatedAt { get; set; }
	}

	public class RecentSalesInfo
	{
		[JsonProperty("hours")]
		public double Hours { get; set; }

		[JsonProperty("average_price")]
		public double AveragePrice { get; set; }
	}
}