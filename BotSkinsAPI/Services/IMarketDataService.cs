using BotSkinsAPI.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Services
{
	public interface IMarketDataService
	{
		ItemPricesResponseModel GetAllItemPrices();

		ItemPricesResponseModel GetOnSaleItemPrices();

		ItemPricesResponseModel GetSomeOnSaleItemPrices();

		ItemPricesResponseModel GetOnSaleItemOriginalPrices();

		ItemPricesResponseModel GetResetPriceItems();

		TradeOffersResponseModel GetTradeOffers();

		TradeDetailsResponseModel GetTradeDetails();

		ItemPricesResponseModel GetItemSalesInfo();

		ItemPricesResponseModel GetSteamPrices();
	}
}
