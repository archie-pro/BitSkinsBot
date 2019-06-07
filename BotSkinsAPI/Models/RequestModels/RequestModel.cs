using System;
using System.Collections.Generic;
using System.Text;
using BotSkinsAPI.Attributes;
using Newtonsoft.Json;

namespace BotSkinsAPI.Models
{

	public class RequestModel
	{
		[ParameterName(Name = "api_key")]
		[Required(Required = RequiredStatus.Required)]
		public string APIKey { get; set; }

		[ParameterName(Name ="code")]
		[Required(Required = RequiredStatus.Required)]
		public string Code { get; set; }

		[ParameterName(Name ="app_id")]
		[Required(Required = RequiredStatus.Optional)]
		public string AppId { get; set; }
	}
}
