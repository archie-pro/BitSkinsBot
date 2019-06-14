using BotSkinsAPI.Models.RequestModels;
using BotSkinsAPI.Models.ResponseModels;

namespace BotSkinsAPI.Services
{
	interface IAccountService
	{
		MoneyEventsResponseModel GetMoneyEvents();

		AccountBalanceResponseModel GetAccountBalance();

		AccountInventoryResponseModel GetAccountInventory();

		RequestWithdrawalResponseModel RequestWithdrawal(double amount, WithdrawalMethod withdrawalMethod);

		TradeOffersResponseModel GetTradeOffers();

		TradeDetailsResponseModel GetTradeDetails();
	}
}
