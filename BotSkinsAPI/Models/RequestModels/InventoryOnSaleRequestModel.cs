using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public enum TripleChoice 
	{
		No = -1,
		NeverMind = 0,
		Yes = 1
	}

	public class InventoryOnSaleRequestModel : PagedRequestModel
	{
		[ParameterName(Name = "sort_by")]
		[Required(Required =RequiredStatus.Optional)]
		public string SortBy { get; set; }

		[ParameterName(Name = "order")]
		[Required(Required = RequiredStatus.Optional)]
		public string Order { get; set; }

		[ParameterName(Name="market_hash_name")]
		[Required(Required = RequiredStatus.Optional)]
		public string MarketHashName { get; set; }

		[ParameterName(Name = "min_price")]
		[Required(Required = RequiredStatus.Optional)]
		public string MinPrice { get; set; }

		[ParameterName(Name = "max_price")]
		[Required(Required = RequiredStatus.Optional)]
		public string MaxPrice { get; set; }

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
