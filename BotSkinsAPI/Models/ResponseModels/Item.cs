using Newtonsoft.Json;
using System;

namespace BotSkinsAPI.Models.ResponseModels
{
	public class Item
	{
		[JsonProperty("app_id")]
		public string AppId { get; set; }

		[JsonProperty("context_id")]
		public string ContextId { get; set; }

		[JsonProperty("item_id")]
		public string ItemId { get; set; }

		[JsonProperty("asset_id")]
		public string AssetId { get; set; }

		[JsonProperty("class_id")]
		public string ClassId { get; set; }

		[JsonProperty("instance_id")]
		public string InstanceId { get; set; }

		[JsonProperty("market_hash_name")]
		public string MarketHashName { get; set; }

		[JsonProperty("item_type")]
		public string ItemType { get; set; }

		[JsonProperty("item_class")]
		public object ItemClass { get; set; }

		[JsonProperty("item_rarity")]
		public string ItemRarity { get; set; }

		[JsonProperty("item_weapon")]
		public string ItemWeapon { get; set; }

		[JsonProperty("item_quality")]
		public string ItemQuality { get; set; }

		[JsonProperty("image")]
		public Uri Image { get; set; }

		[JsonProperty("inspectable")]
		public bool Inspectable { get; set; }

		[JsonProperty("inspect_link")]
		public string InspectLink { get; set; }

		[JsonProperty("price")]
		public double Price { get; set; }

		[JsonProperty("suggested_price")]
		public double SuggestedPrice { get; set; }

		[JsonProperty("is_featured")]
		public bool IsFeatured { get; set; }

		[JsonProperty("float_value")]
		public double FloatValue { get; set; }

		[JsonProperty("pattern_info")]
		public PatternInfo PatternInfo { get; set; }

		[JsonProperty("phase")]
		public object Phase { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("is_mine")]
		public bool IsMine { get; set; }

		[JsonProperty("tags")]
		public Tags Tags { get; set; }

		[JsonProperty("fraud_warnings")]
		public string[] FraudWarnings { get; set; }

		[JsonProperty("stickers")]
		public Sticker[] Stickers { get; set; }

		[JsonProperty("updated_at")]
		public DateTime? UpdatedAt { get; set; }

		[JsonProperty("withdrawable_at")]
		public DateTime? WithdrawableAt { get; set; }

		[JsonProperty("bot_uid")]
		public string BotUid { get; set; }
	}

	public class PatternInfo
	{
		[JsonProperty("paintindex")]
		public long PaintIndex { get; set; }

		[JsonProperty("paintseed")]
		public long PaintSeed { get; set; }

		[JsonProperty("rarity")]
		public long Rarity { get; set; }

		[JsonProperty("quality")]
		public long Quality { get; set; }

		[JsonProperty("paintwear")]
		public long PaintWear { get; set; }

		[JsonProperty("patternname")]
		public string PatternName { get; set; }
	}

	public class Sticker
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }

		[JsonProperty("wear_value")]
		public double WearValue { get; set; }
	}

	public class Tags
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("weapon")]
		public string Weapon { get; set; }

		[JsonProperty("itemset")]
		public string Itemset { get; set; }

		[JsonProperty("quality")]
		public string Quality { get; set; }

		[JsonProperty("rarity")]
		public string Rarity { get; set; }

		[JsonProperty("exterior")]
		public string Exterior { get; set; }

		[JsonProperty("tournament")]
		public string Tournament { get; set; }

		[JsonProperty("tournamentteam")]
		public string TournamentTeam { get; set; }
	}
}
