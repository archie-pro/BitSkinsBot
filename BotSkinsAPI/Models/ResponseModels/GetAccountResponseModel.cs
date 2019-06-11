using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.ResponseModels
{
	[JsonObject]
	public class GetAccountResponseModel : ResponseBodyModel
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
