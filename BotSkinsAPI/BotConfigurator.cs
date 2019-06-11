using BotSkinsAPI.Helpers;
using BotSkinsAPI.Proxies;
using BotSkinsAPI.Services;
using Unity;

namespace BotSkinsAPI
{
	public static class BotConfigurator
	{
		public static string ApiKey { get; private set; }

		public static string SecureCode { get; private set; }

		public static UnityContainer Container { get; private set; }

		private static bool IsDependenciesResolved { get; set; }

		static BotConfigurator()
		{
			RegisterLibraryDependencies();
		}

		public static void Configure(string apiCode, string secureCode)
		{
			BotConfigurator.ApiKey = apiCode;
			BotConfigurator.SecureCode = secureCode;
		}

		private static void RegisterLibraryDependencies()
		{
			Container = new UnityContainer();
			Container.RegisterType<IRequestBuilder, RequestBuilder>();
			Container.RegisterType<IQueryBuilder, QueryBuilder>();
			Container.RegisterType<ISecureCodeGenerator, SecureCodeGenerator>();
			Container.RegisterType<IProxy, HttpProxy>();
			Container.RegisterType<IAccountService, AccountService>();
		}
	}
}
