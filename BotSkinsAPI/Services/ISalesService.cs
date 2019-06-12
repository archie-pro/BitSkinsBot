using BotSkinsAPI.Models.ResponseModels;

namespace BotSkinsAPI.Services
{
	public interface ISalesService
	{
		BuyItemResponseModel BuyItem();

		SaleItemsResponseModel SetItemsForSale();

		SaleItemsResponseModel ModifySaleItems();

		SaleItemsResponseModel RemoveSaleItem();

		SaleItemsResponseModel RelistSaleItems();

		WithdrawItemResponseModel WithdrawItem();

		SaleItemsResponseModel BumpSaleItems();
	}
}
