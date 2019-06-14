using BotSkinsAPI.Models.RequestModels;
using BotSkinsAPI.Models.ResponseModels;
using BotSkinsAPI.Operations;
using Unity;

namespace BotSkinsAPI.Services
{
	public class AccountService : IAccountService
	{
		public AccountBalanceResponseModel GetAccountBalance()
		{
			IOperation<RequestBodyModel, AccountBalanceResponseModel> operation = BotConfigurator.Container.Resolve<Operation<RequestBodyModel, AccountBalanceResponseModel>>();
			AccountBalanceResponseModel response = operation.DoOperation(Constants.GetAccountBalance, new RequestBodyModel());
			return response;
		}

		public AccountInventoryResponseModel GetAccountInventory()
		{
			IOperation<RequestBodyModel, AccountInventoryResponseModel> operation = BotConfigurator.Container.Resolve<Operation<RequestBodyModel, AccountInventoryResponseModel>>();
			AccountInventoryResponseModel response = operation.DoOperation(Constants.GetAccountInventory, new RequestBodyModel());
			return response;
		}

		public MoneyEventsResponseModel GetMoneyEvents()
		{
			IOperation<RequestBodyModel, MoneyEventsResponseModel> operation = BotConfigurator.Container.Resolve<Operation<RequestBodyModel, MoneyEventsResponseModel>>();
			MoneyEventsResponseModel response = operation.DoOperation(Constants.GetMoneyEvents, new RequestBodyModel());
			return response;
		}

		public TradeDetailsResponseModel GetTradeDetails()
		{
			throw new System.NotImplementedException();
		}

		public TradeOffersResponseModel GetTradeOffers()
		{
			throw new System.NotImplementedException();
		}

		public RequestWithdrawalResponseModel RequestWithdrawal(double amount, WithdrawalMethod withdrawalMethod)
		{
			IOperation<WithdrawalRequestModel, RequestWithdrawalResponseModel> operation = BotConfigurator.Container.Resolve<Operation<WithdrawalRequestModel, RequestWithdrawalResponseModel>>();
			RequestWithdrawalResponseModel response = operation.DoOperation(Constants.RequestWithdrawal, new WithdrawalRequestModel() {Amount = amount, WithdrawalMethod = withdrawalMethod });
			return response;
		}
	}
}
