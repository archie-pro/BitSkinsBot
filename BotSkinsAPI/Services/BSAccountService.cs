using BotSkinsAPI.Helpers;
using BotSkinsAPI.Models;
using BotSkinsAPI.Proxies;
using System;
using Unity;

namespace BotSkinsAPI.Services
{
	public class BSAccountService : IBSAccountService
	{
		[Dependency]
		public IProxy HttpProxy { get; set; }

		[Dependency]
		public IRequestBuilder RequestBuilder { get; set; }

		[Dependency]
		public ISecureCodeGenerator SecureCodeGenerator { get; set; }

		public void GetAccountBalance()
		{
			RequestUrlModel model = new RequestUrlModel();
			model.Host = BotConfigurator.Host;
			model.Method = CallMethod.Get;
			model.Path = BotConfigurator.GetAccountBalance;
			model.RequestParams = new RequestModel()
			{
				APIKey = BotConfigurator.ApiKey,
				Code = SecureCodeGenerator.Generate()
			};

			Uri uri = this.RequestBuilder.BuildGetRequest(model);

			string result = HttpProxy.CallGet(uri).Result;
		}
	}
}
