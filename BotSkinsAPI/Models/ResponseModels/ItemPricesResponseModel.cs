using BotSkinsAPI.Models.Models;
using Newtonsoft.Json;

namespace BotSkinsAPI.Models.ResponseModels
{
	public class ItemPricesResponseModel : ResponseBodyModel
	{
		[JsonProperty("items")]
		public Item[] Items { get; set; }
	} 
}