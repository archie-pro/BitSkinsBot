using BotSkinsAPI.Models.ResponseModels;

namespace BotSkinsAPI.Services
{
	interface IAccountService
	{
		MoneyEventsResponseModel GetMoneyEvents();

		AccountBalanceResponseModel GetAccountBalance();

		AccountInventoryResponseModel GetAccountInventory();

		RequestWithdrawalResponseModel RequestWithdrawal();
	}
}
