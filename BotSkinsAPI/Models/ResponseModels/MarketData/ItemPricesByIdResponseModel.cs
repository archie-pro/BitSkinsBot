﻿using Newtonsoft.Json;

namespace BotSkinsAPI.Models.ResponseModels
{
	public class ItemsPricesByIdResponseModel : ResponseBodyModel
	{
		[JsonProperty("items_on_sale")]
		public Item[] ItemsOnSale { get; set; }

		[JsonProperty("items_not_on_sale")]
		public Item[] ItemsNotOnSale { get; set; }
	}
}
