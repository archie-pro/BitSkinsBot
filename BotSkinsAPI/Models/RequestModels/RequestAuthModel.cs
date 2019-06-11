using BotSkinsAPI.Attributes;

namespace BotSkinsAPI.Models.RequestModels
{
	public class RequestAuthModel
	{
		[ParameterName(Name = "api_key")]
		[Required(Required = RequiredStatus.Required)]
		public string APIKey { get; set; }

		[ParameterName(Name = "code")]
		[Required(Required = RequiredStatus.Required)]
		public string Code { get; set; }
	}
}
