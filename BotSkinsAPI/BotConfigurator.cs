using BotSkinsAPI.Helpers;
using BotSkinsAPI.Proxies;
using Unity;

namespace BotSkinsAPI
{
	public class BotConfigurator
	{
		public static readonly string Host = "www.bitskins.com";

		public static readonly string GetAccountBalance = "api/v1/get_account_balance/";
		public static readonly string GetAccountInventory = "api/v1/get_my_inventory";
		public static readonly string RequestWithdrawal = "api/v1/request_withdrawal";

		public static readonly string GetAllItemPrices = "api/v1/get_all_item_prices";
		public static readonly string GetOnSaleItemOriginalPrices = "api/v1/get_price_data_for_items_on_sale";
		public static readonly string GetOnSaleItemPrices = "api/v1/get_inventory_on_sale";
		public static readonly string GetSomeOnSaleItemPrices = "api/v1/get_specific_items_on_sale";
		public static readonly string GetResetPriceItems = "api/v1/get_reset_price_items";
		public static readonly string GetRecentTradeOffers = "api/v1/get_recent_trade_offers";
		public static readonly string GetTradeDetails = "api/v1/get_trade_details";
		public static readonly string GetItemSalesInfo = "api/v1/get_sales_info";
		public static readonly string GetSteamPriceData = "get_steam_price_data";

		public static readonly string GetMoneyEvents = "api/v1/get_money_events";
		public static readonly string GetBuyHistory = "api/v1/get_buy_history";
		public static readonly string GetSellHistory = "api/v1/get_sell_history";
		public static readonly string GetItemHistory = "api/v1/get_item_history";

		public static readonly string BuyItem = "api/v1/buy_item";
		public static readonly string SetItemForSale = "api/v1/list_item_for_sale";
		public static readonly string ModifySaleItem = "api/v1/modify_sale_item";
		public static readonly string RemoveSaleItem = "api/v1/delist_item";
		public static readonly string RelistItem = "api/v1/relist_item";
		public static readonly string WithdrawItem = "api/v1/withdraw_item";
		public static readonly string BumpItem = "api/v1/bump_item";





		public static string ApiKey { get; private set; }
		public static string SecureCode { get; private set; }

		public static UnityContainer UnityContainer { get; private set; }

		public static void Configure(string apiCode, string secureCode)
		{
			BotConfigurator.ApiKey = apiCode;
			BotConfigurator.SecureCode = secureCode;
			BotConfigurator.RegisterLibraryDependencies();
		}

		private static void RegisterLibraryDependencies()
		{
			UnityContainer = new UnityContainer();
			UnityContainer.RegisterType<IRequestBuilder, RequestBuilder>();
			UnityContainer.RegisterType<IQueryBuilder, QueryBuilder>();
			UnityContainer.RegisterType<ISecureCodeGenerator, SecureCodeGenerator>();
			UnityContainer.RegisterType<IProxy, HttpProxy>();
		}
	}
}
