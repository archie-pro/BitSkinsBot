using BotSkinsAPI.Models.RequestModels;
using BotSkinsAPI.Models.ResponseModels;

namespace BotSkinsAPI.Services
{
	public interface IOrderService
	{
		ResponseBodyModel CreateOrder(string name, string price, string quantity);

		ResponseBodyModel CheckExpectedQueuePlaceForNewOrder(string name, string price);

		ResponseBodyModel CancelOrderById(string[] orderIds);

		ResponseBodyModel CancelOrderByName(string marketHashName);

		ResponseBodyModel GetOrderHistory(string marketHashName = null, int? page = null, OrderType type = OrderType.All);

		ResponseBodyModel GetMarketOrders(string marketHashName, int? page);

		ResponseBodyModel SummarizeOrders();
	}
}
