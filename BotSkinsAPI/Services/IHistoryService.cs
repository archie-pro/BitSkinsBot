using BotSkinsAPI.Models.ResponseModels;

namespace BotSkinsAPI.Services
{
	public interface IHistoryService
	{
		SalesHistoryResponseModel GetBuyHistory(int page = 1, string appId = "");

		SalesHistoryResponseModel GetSellHistory(int page = 1, string appId = "");

		SalesHistoryResponseModel GetItemHistory(string[] names = null, string delimeter = null, int page = 1, int perPage = 30, string appId = "");

		ItemSalesInfoResponseModel GetBitskinsItemSalesInfo(string marketHashName = "", int page = 1, string appId = "");

		ItemSalesInfoResponseModel GetSteamItemSalesInfo(string marketHashName = "", string appId = "");
	}
}
