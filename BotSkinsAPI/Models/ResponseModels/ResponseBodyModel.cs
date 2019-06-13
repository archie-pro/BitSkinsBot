using Newtonsoft.Json;

namespace BotSkinsAPI.Models.ResponseModels
{
	public class ResponseBodyModel
	{
		[JsonProperty("app_id")]
		public string AppId { get; set; }

		[JsonProperty("context_id")]
		public string ContextId { get; set; }
	}
}