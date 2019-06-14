using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public enum TripleChoice
	{
		[ParameterValue(Value = "0")]
		NeverMind = 0,
		[ParameterValue(Value = "-1")]
		No = 1,	
		[ParameterValue(Value = "1")]
		Yes = 2
	}

	public enum OrderByType
	{
		[ParameterValue(Value = "desc")]
		Desc = 0,

		[ParameterValue(Value = "asc")]
		Asc = 1
	}

	public enum SortByType
	{
		[ParameterValue(Value = "created_at")]
		CreatedAt = 0,

		[ParameterValue(Value = "price")]
		Price = 1,

		[ParameterValue(Value = "wear_value")]
		WearValue = 2
	}

	public class InventoryOnSaleRequestModel : PagedRequestModel
	{
		[ParameterName(Name = "sort_by")]
		[Required(Required =RequiredStatus.Optional)]
		public SortByType SortBy { get; set; }

		[ParameterName(Name = "order")]
		[Required(Required = RequiredStatus.Optional)]
		public OrderByType Order { get; set; }

		[ParameterName(Name="market_hash_name")]
		[Required(Required = RequiredStatus.Optional)]
		public string MarketHashName { get; set; }

		[ParameterName(Name = "min_price")]
		[Required(Required = RequiredStatus.Optional)]
		public double? MinPrice { get; set; }

		[ParameterName(Name = "max_price")]
		[Required(Required = RequiredStatus.Optional)]
		public double? MaxPrice { get; set; }

		[ParameterName(Name = "has_stickers")]
		[Required(Required = RequiredStatus.Optional)]
		public TripleChoice HasStickers { get; set; }

		[ParameterName(Name = "is_stattrak")]
		[Required(Required = RequiredStatus.Optional)]
		public TripleChoice IsStatTrak { get; set; }

		[ParameterName(Name = "is_souvenir")]
		[Required(Required = RequiredStatus.Optional)]
		public TripleChoice IsSouvenir { get; set; }

		[ParameterName(Name = "show_trade_delayed_items")]
		[Required(Required = RequiredStatus.Optional)]
		public TripleChoice ShowTradeDelayedItems { get; set; }
	}
}
