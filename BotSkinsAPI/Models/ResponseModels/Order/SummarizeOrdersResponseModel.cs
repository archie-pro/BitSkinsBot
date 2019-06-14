using Newtonsoft.Json;

namespace BotSkinsAPI.Models.ResponseModels.Order
{
	public class SummarizeOrdersResponseModel:ResponseBodyModel
	{
		[JsonProperty("items")]
		public OrderSummary[][] Items { get; set; }
	}

	public class OrderSummary
	{
		[JsonProperty("number_of_buy_orders")]
		public long NumberOfBuyOrders { get; set; }

		[JsonProperty("max_price")]
		public string MaxPrice { get; set; }

		[JsonProperty("min_price")]
		public string MinPrice { get; set; }

		[JsonProperty("my_buy_orders")]
		public object MyBuyOrders { get; set; }
	}
}
