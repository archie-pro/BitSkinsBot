using Newtonsoft.Json;

namespace BotSkinsAPI.Models.ResponseModels
{
	[JsonObject]
	public class AccountBalanceResponseModel : ResponseBodyModel
	{
		[JsonProperty(PropertyName = "available_balance")]
		public double AvailiableBalance { get; set; }

		[JsonProperty(PropertyName = "pending_withdrawals")]
		public double PendingWithdrawals { get; set; }

		[JsonProperty(PropertyName = "withdrawable_balance")]
		public double WithdrawalBalance { get; set; }

		[JsonProperty(PropertyName = "couponable_balance")]
		public double CouponableBalance { get; set; }
	}
}
