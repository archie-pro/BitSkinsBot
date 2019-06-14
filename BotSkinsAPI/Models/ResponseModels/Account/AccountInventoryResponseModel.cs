using BotSkinsAPI.Models.Models;
using Newtonsoft.Json;

namespace BotSkinsAPI.Models.ResponseModels
{
	public class AccountInventoryResponseModel : ResponseBodyModel
	{
		[JsonProperty("steam_inventory")]
		public SteamInventory SteamInventory { get; set; }

		[JsonProperty("bitskins_inventory")]
		public BitSkinsInventory BitSkinsInventory { get; set; }

		[JsonProperty("pending_withdrawal_from_bitskins")]
		public BitSkinsInventory BitSkinsInventoryWithdrawal { get; set; }
	}

	public class BitSkinsInventory
	{
		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("total_items")]
		public long TotalItems { get; set; }

		[JsonProperty("total_price")]
		public string TotalPrice { get; set; }

		[JsonProperty("items")]
		public Item[] Items { get; set; }

		[JsonProperty("page")]
		public long Page { get; set; }

		[JsonProperty("items_per_page")]
		public long ItemsPerPage { get; set; }
	}

	public class SteamInventory
	{
		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("total_items")]
		public long TotalItems { get; set; }

		[JsonProperty("items")]
		public Item[] Items { get; set; }

		[JsonProperty("fresh_or_cached", NullValueHandling = NullValueHandling.Ignore)]
		public string FreshOrCached { get; set; }
	}
}