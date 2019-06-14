using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public class ItemHistoryRequestModel : PagedRequestModel
	{
		[ParameterName(Name = "names")]
		[Required(Required = RequiredStatus.Optional)]
		public string[] Names { get; set; }

		[ParameterName(Name = "delimeter")]
		[Required(Required = RequiredStatus.Optional)]
		public string Delimiter { get; set; }
	}
}
