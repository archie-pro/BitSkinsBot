using BotSkinsAPI.Models;
using BotSkinsAPI.Models.RequestModels;
using BotSkinsAPI.Models.ResponseModels;
using BotSkinsAPI.Operations;
using Unity;

namespace BotSkinsAPI.Services
{
	public class AccountService : IAccountService
	{
		public GetAccountResponseModel GetAccountBalance()
		{
			IOperation<RequestBodyModel, GetAccountResponseModel> operation = BotConfigurator.Container.Resolve<Operation<RequestBodyModel, GetAccountResponseModel>>();
			GetAccountResponseModel response = operation.DoOperation(Constants.GetAccountBalance, new RequestBodyModel());
			return response;
		}
	}
}
