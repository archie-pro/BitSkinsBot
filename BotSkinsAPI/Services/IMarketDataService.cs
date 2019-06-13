using BotSkinsAPI.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Services
{
	public interface IMarketDataService
	{
		ItemPricesResponseModel GetSuggestedItemPrices();

		ItemPricesForkResponseModel GetSellItemsPriceFork();

		ItemPricesResponseModel GetFilteredSellItems();

		ItemsPricesByIdResponseModel GetSellItemsById();

		ItemPricesResponseModel GetResetPriceItems();

		TradeOffersResponseModel GetTradeOffers();

		TradeDetailsResponseModel GetTradeDetails();
	}
}
