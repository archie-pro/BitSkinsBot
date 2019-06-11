using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public enum WithdrawalMethod
	{
		[ParameterValue(Value = "bitcoin")]
		Bitcoin,
		[ParameterValue(Value = "paypal")]
		PayPal,
		[ParameterValue(Value = "bank_wire")]
		BankWire
	}

	public class WithdrawalRequestModel : RequestBodyModel
	{
		[ParameterName(Name = "amount")]
		[Required(Required = RequiredStatus.Required)]
		public string Amount { get; set; }

		[ParameterName(Name = "withdrawal_method")]
		[Required(Required = RequiredStatus.Required)]
		public WithdrawalMethod WithdrawalMethod { get; set; }
	}
}
