using BotSkinsAPI.Models.ResponseModels;

namespace BotSkinsAPI.Services
{
	public interface IHistoryService
	{
		SalesHistoryResponseModel GetBuyHistory();

		SalesHistoryResponseModel GetSellHistory();

		SalesHistoryResponseModel GetItemHistory();
	}
}
