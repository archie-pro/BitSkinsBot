using BotSkinsAPI.Models.RequestModels;
using BotSkinsAPI.Models.ResponseModels;
using BotSkinsAPI.Operations;
using Unity;

namespace BotSkinsAPI.Services
{
	public class OrderService : IOrderService
	{
		public ResponseBodyModel CancelOrderById(string[] orderIds)
		{
			IOperation<CancelOrderByIdRequestModel, ResponseBodyModel> operation = BotConfigurator.Container.Resolve<Operation<CancelOrderByIdRequestModel, ResponseBodyModel>>();
			ResponseBodyModel response = operation.DoOperation(Constants.CancelOrdersByOrderId, new CancelOrderByIdRequestModel() { OrderIds = orderIds });
			return response;
		}

		public ResponseBodyModel CancelOrderByName(string marketHashName)
		{
			IOperation<CancelOrderByNameRequestModel, ResponseBodyModel> operation = BotConfigurator.Container.Resolve<Operation<CancelOrderByNameRequestModel, ResponseBodyModel>>();
			ResponseBodyModel response = operation.DoOperation(Constants.CancelOrdersByName, new CancelOrderByNameRequestModel() { MarketHashName = marketHashName });
			return response;
		}

		public ResponseBodyModel CheckExpectedQueuePlaceForNewOrder(string name, string price)
		{
			IOperation<CreateOrderRequestModel, ResponseBodyModel> operation = BotConfigurator.Container.Resolve<Operation<CreateOrderRequestModel, ResponseBodyModel>>();
			ResponseBodyModel response = operation.DoOperation(Constants.GetExpectedQueuePlaceForOrder, new CreateOrderRequestModel() { Name = name, Price = price });
			return response;
		}

		public ResponseBodyModel CreateOrder(string name, string price, string quantity)
		{
			IOperation<CreateOrderRequestModel, ResponseBodyModel> operation = BotConfigurator.Container.Resolve<Operation<CreateOrderRequestModel, ResponseBodyModel>>();
			ResponseBodyModel response = operation.DoOperation(Constants.CreateOrder, new CreateOrderRequestModel() { Name = name, Price = price, Quantity = quantity });
			return response;
		}

		public GetMarketOrdersResponseModel GetMarketOrders(string marketHashName, int? page)
		{
			IOperation<GetOrdersRequestModel, GetMarketOrdersResponseModel> operation = BotConfigurator.Container.Resolve<Operation<GetOrdersRequestModel, GetMarketOrdersResponseModel>>();
			GetMarketOrdersResponseModel response = operation.DoOperation(Constants.GetMarketOrders, new GetOrdersRequestModel() { MarketHashName = marketHashName, Page = page});
			return response;
		}

		public ResponseBodyModel GetOrderHistory(string marketHashName = null, int? page = null, OrderType type = OrderType.All)
		{
			IOperation<GetOrdersRequestModel, ResponseBodyModel> operation = BotConfigurator.Container.Resolve<Operation<GetOrdersRequestModel, ResponseBodyModel>>();
			ResponseBodyModel response = operation.DoOperation(Constants.GetAccountOrders, new GetOrdersRequestModel() { MarketHashName = marketHashName, Page = page, Type = type });
			return response;
		}

		public ResponseBodyModel SummarizeOrders()
		{
			IOperation<RequestBodyModel, ResponseBodyModel> operation = BotConfigurator.Container.Resolve<Operation<RequestBodyModel, ResponseBodyModel>>();
			ResponseBodyModel response = operation.DoOperation(Constants.SummarizeMarketOrders, new RequestBodyModel());
			return response;
		}
	}
}
