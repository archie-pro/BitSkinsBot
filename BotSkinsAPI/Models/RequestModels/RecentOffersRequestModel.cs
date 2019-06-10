using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public class RecentOffersRequestModel : RequestModel
	{
		[ParameterName(Name = ("active_only"))]
		[Required(Required = RequiredStatus.Optional)]
		public string ActiveOnly { get; set; }
	}
}
