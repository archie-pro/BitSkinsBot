using BotSkinsAPI.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BotSkinsAPI
{
	public static class Constants
	{
		public static readonly string Scheme = "https";
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

		public static readonly string CreateOrder = "api/v1/create_buy_order";
		public static readonly string GetExpectedQueuePlaceForOrder = "api/v1/get_expected_place_in_queue_for_new_buy_order";
		public static readonly string CancelOrdersByOrderId = "api/v1/cancel_buy_orders";
		public static readonly string CancelOrdersByName = "api/v1/cancel_all_buy_orders";
		public static readonly string GetOrdersHistory = "api/v1/get_buy_order_history";
		public static readonly string GetMarketOrders = "api/v1/get_market_buy_orders";
		public static readonly string SummarizeMarketOrders = "api/v1/summarize_buy_orders";

		public static readonly ReadOnlyCollection<KeyValuePair<string, CallMethod>> EndpointCallMethods;

		static Constants()
		{
			IEnumerable<string> getEndpoints = new string[]
			{
				GetAccountBalance, GetAccountInventory, GetAllItemPrices, GetOnSaleItemOriginalPrices,
				GetOnSaleItemPrices, GetSomeOnSaleItemPrices, GetResetPriceItems, GetRecentTradeOffers,
				GetTradeDetails ,GetItemSalesInfo, GetSteamPriceData, GetMoneyEvents,
				GetBuyHistory, GetSellHistory, GetItemHistory
			};
			IEnumerable<string> postEndpoints = new string[]
			{
				RequestWithdrawal, BuyItem, SetItemForSale, ModifySaleItem, RemoveSaleItem, RelistItem, WithdrawItem, BumpItem
			};

			var endpointList = getEndpoints.Select(e => new KeyValuePair<string, CallMethod>(e, CallMethod.Get)).
				Concat(postEndpoints.Select(e => new KeyValuePair<string, CallMethod>(e, CallMethod.Post)));

			EndpointCallMethods = new ReadOnlyCollection<KeyValuePair<string, CallMethod>>(endpointList.ToArray());
		}
	}
}
