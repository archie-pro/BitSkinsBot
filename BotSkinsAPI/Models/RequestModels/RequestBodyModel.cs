using BotSkinsAPI.Attributes;

namespace BotSkinsAPI.Models.RequestModels
{
	public class RequestBodyModel
	{
		[ParameterName(Name = "app_id")]
		[Required(Required = RequiredStatus.Optional)]
		public string AppId { get; set; }
	}
}
