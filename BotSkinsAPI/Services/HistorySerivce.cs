using System;
using BotSkinsAPI.Models.RequestModels;
using BotSkinsAPI.Models.ResponseModels;
using BotSkinsAPI.Operations;
using Unity;

namespace BotSkinsAPI.Services
{
	public class HistorySerivce : IHistoryService
	{
		public SalesHistoryResponseModel GetBuyHistory(int page = 1, string appId = "")
		{
			IOperation<PagedRequestModel, SalesHistoryResponseModel> operation = BotConfigurator.Container.Resolve<Operation<PagedRequestModel, SalesHistoryResponseModel>>();
			SalesHistoryResponseModel response = operation.DoOperation(Constants.GetBuyHistory, new PagedRequestModel() { Page = page, AppId = appId});
			return response;
		}

		public SalesHistoryResponseModel GetSellHistory(int page = 1, string appId = "")
		{
			IOperation<PagedRequestModel, SalesHistoryResponseModel> operation = BotConfigurator.Container.Resolve<Operation<PagedRequestModel, SalesHistoryResponseModel>>();
			SalesHistoryResponseModel response = operation.DoOperation(Constants.GetSellHistory, new PagedRequestModel() { Page = page, AppId = appId });
			return response;
		}

		public SalesHistoryResponseModel GetItemHistory(string[] names = null, string delimeter = null, int page = 1, int perPage = 30, string appId = "")
		{
			IOperation<ItemHistoryRequestModel, SalesHistoryResponseModel> operation = BotConfigurator.Container.Resolve<Operation<ItemHistoryRequestModel, SalesHistoryResponseModel>>();
			SalesHistoryResponseModel response = operation.DoOperation(Constants.GetItemHistory, new ItemHistoryRequestModel() { Names = names, Delimiter = delimeter, Page = page, PerPage = perPage, AppId = appId });
			return response;
		}

		public ItemSalesInfoResponseModel GetSteamItemSalesInfo(string marketHashName = "", string appId = "")
		{
			IOperation<ItemSalesInfoRequestModel, SteamItemSalesResponseModel> operation = BotConfigurator.Container.Resolve<Operation<ItemSalesInfoRequestModel, SteamItemSalesResponseModel>>();
			SteamItemSalesResponseModel response = operation.DoOperation(Constants.GetItemHistory, new ItemSalesInfoRequestModel() { MarketHashName = marketHashName, AppId = appId });
			return (ItemSalesInfoResponseModel)response;
		}

		public ItemSalesInfoResponseModel GetBitskinsItemSalesInfo(string marketHashName = "", int page = 1, string appId = "")
		{
			IOperation<ItemSalesInfoRequestModel, BitskinsItemSalesResponseModel> operation = BotConfigurator.Container.Resolve<Operation<ItemSalesInfoRequestModel, BitskinsItemSalesResponseModel>>();
			BitskinsItemSalesResponseModel response = operation.DoOperation(Constants.GetItemHistory, new ItemSalesInfoRequestModel() { MarketHashName = marketHashName, AppId = appId });
			return (ItemSalesInfoResponseModel)response;
		}
	}
}
