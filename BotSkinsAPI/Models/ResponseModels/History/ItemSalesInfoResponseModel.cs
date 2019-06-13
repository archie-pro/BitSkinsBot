using System;
using System.Linq;
using BotSkinsAPI.Models.ResponseModels;

namespace BotSkinsAPI.Models.ResponseModels
{
	public class ItemSalesInfoResponseModel : ResponseBodyModel
	{
		public string MarketHashName { get; set; }

		public ItemSaleInfo[] Items { get; set; } 

		public static explicit operator ItemSalesInfoResponseModel(BitskinsItemSalesResponseModel v)
		{
			return new ItemSalesInfoResponseModel()
			{
				Items = v.Sales.Select(e => new ItemSaleInfo() { Price = e.Price, Count = 1, SoldAt = e.SoldAt }).ToArray(),
				MarketHashName = v.Sales.FirstOrDefault()?.MarketHashName
			};	
		}

		public static explicit operator ItemSalesInfoResponseModel(SteamItemSalesResponseModel v)
		{
			return new ItemSalesInfoResponseModel()
			{
				Items = v.Items.Select(e => new ItemSaleInfo() { Price = e.Price, SoldAt = e.Time, Count = e.Volume }).ToArray(),
				MarketHashName = v.MarketHashName
			};
		}
	}

	public class ItemSaleInfo
	{
		public DateTime SoldAt { get; set; }

		public double Price { get; set; }

		public long Count { get; set; }
	}
}