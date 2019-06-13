using BotSkinsAPI.Models.Models;
using Newtonsoft.Json;
using System;

namespace BotSkinsAPI.Models.ResponseModels
{
	public class SalesHistoryResponseModel : ResponseBodyModel
	{
		[JsonProperty("items")]
		public Item[] Items { get; set; }

		[JsonProperty("page")]
		public long Page { get; set; }
	}
}