using BotSkinsAPI.Models.RequestModels;
using BotSkinsAPI.Models.ResponseModels;
using BotSkinsAPI.Operations;
using Unity;

namespace BotSkinsAPI.Services
{
	public class MarketDataService : IMarketDataService
	{
		public ItemPricesResponseModel GetSuggestedItemPrices(string appId)
		{
			IOperation<RequestBodyModel, ItemPricesResponseModel> operation = BotConfigurator.Container.Resolve<Operation<RequestBodyModel, ItemPricesResponseModel>>();
			ItemPricesResponseModel response = operation.DoOperation(Constants.GetAccountBalance, new RequestBodyModel() { AppId = appId });
			return response;
		}

		public ItemPricesForkResponseModel GetSellItemsPriceFork(string appId)
		{
			IOperation<RequestBodyModel, ItemPricesForkResponseModel> operation = BotConfigurator.Container.Resolve<Operation<RequestBodyModel, ItemPricesForkResponseModel>>();
			ItemPricesForkResponseModel response = operation.DoOperation(Constants.GetAccountBalance, new RequestBodyModel() { AppId = appId });
			return response;
		}

		public ItemPricesResponseModel GetFilteredSellItems(string appId, double? minPrice = null, double? maxPrice = null, string marketHashName = "", int? page = 0, int? perPage = 30)
		{
			IOperation<InventoryOnSaleRequestModel, ItemPricesResponseModel> operation = BotConfigurator.Container.Resolve<Operation<InventoryOnSaleRequestModel, ItemPricesResponseModel>>();
			ItemPricesResponseModel response = operation.DoOperation(Constants.GetAccountBalance, new InventoryOnSaleRequestModel() { AppId = appId });
			return response;
		}

		public ItemsPricesByIdResponseModel GetSellItemsById(string[] itemIds, string appId)
		{
			IOperation<ItemsRequestModel, ItemsPricesByIdResponseModel> operation = BotConfigurator.Container.Resolve<Operation<ItemsRequestModel, ItemsPricesByIdResponseModel>>();
			ItemsPricesByIdResponseModel response = operation.DoOperation(Constants.GetAccountBalance, new ItemsRequestModel() { AppId = appId, ItemIds = itemIds });
			return response;
		}

		public ItemPricesResponseModel GetResetPriceItems(string appId, int? page = 0)
		{
			IOperation<PagedRequestModel, ItemPricesResponseModel> operation = BotConfigurator.Container.Resolve<Operation<PagedRequestModel, ItemPricesResponseModel>>();
			ItemPricesResponseModel response = operation.DoOperation(Constants.GetAccountBalance, new PagedRequestModel() { AppId = appId, Page = page });
			return response;
		}
	}
}
