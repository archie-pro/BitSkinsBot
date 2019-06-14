using BotSkinsAPI.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Services
{
	public interface IMarketDataService
	{
		ItemPricesResponseModel GetSuggestedItemPrices(string appId);

		ItemPricesForkResponseModel GetSellItemsPriceFork(string appId);

		ItemPricesResponseModel GetFilteredSellItems(string appId, double? minPrice = null, double? maxPrice = null, string marketHashName = "", int? page = 0, int? perPage = 30);

		ItemsPricesByIdResponseModel GetSellItemsById(string[] itemIds, string appId);

		ItemPricesResponseModel GetResetPriceItems(string appId, int? page = 0);

	}
}
