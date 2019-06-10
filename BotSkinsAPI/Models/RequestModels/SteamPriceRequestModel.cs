using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public class SteamPriceRequestModel : RequestModel
	{
		[ParameterName(Name = "market_hash_name")]
		[Required(Required = RequiredStatus.Required)]
		public string MarketHashName { get; set; }
	}
}
