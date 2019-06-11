using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public class CancelOrdersByIdRequestModel : RequestBodyModel
	{
		[ParameterName(Name = "buy_order_ids")]
		[Required(Required = RequiredStatus.Required)]
		public string[] OrderIds;
	}
}
