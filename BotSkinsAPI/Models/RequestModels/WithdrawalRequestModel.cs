using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public enum WithdrawalMethod
	{
		Bitcoin = 1,
		PayPal = 2,
		BankWire = 4
	}

	public class WithdrawalRequestModel : RequestModel
	{
		[ParameterName(Name = "amount")]
		[Required(Required = RequiredStatus.Required)]
		public string Amount { get; set; }

		[ParameterName(Name = "withdrawal_method")]
		[Required(Required = RequiredStatus.Required)]
		public WithdrawalMethod WithdrawalMethod { get; set; }
	}
}
