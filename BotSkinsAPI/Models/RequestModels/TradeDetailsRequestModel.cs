using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public class TradeDetailsRequestModel
	{
		[ParameterName(Name = "trade_token")]
		[Required(Required = RequiredStatus.Required)]
		public string TradeToken { get; set; }

		[ParameterName(Name ="trade_id")]
		[Required(Required = RequiredStatus.Required)]
		public string TradeId { get; set; }
	}
}
