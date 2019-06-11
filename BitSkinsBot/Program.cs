using BotSkinsAPI;
using BotSkinsAPI.Services;
using System;
using Unity;

namespace BitSkinsBot
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			BotConfigurator.Configure("0b4997a8-00cb-428c-a245-7900dfdf872e", "27DBI2H24AYKNKEN");

			var service = BotConfigurator.Container.Resolve<AccountService>();

			Console.WriteLine(service.GetAccountBalance().AvailiableBalance);
		}
	}
}
