using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public class CancelOrderByNameRequestModel : RequestBodyModel
	{
		[ParameterName(Name = "market_hash_name")]
		public string MarketHashName { get; set; }
	}
}
