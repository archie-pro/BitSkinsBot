using BotSkinsAPI.Models.ResponseModels;
using Newtonsoft.Json;

namespace BotSkinsAPI.Models
{
	public enum ResponseStatus
	{
		Success,
		Error
	}

	[JsonObject]
	public class ResponseModel
	{
		[JsonProperty(PropertyName = "status")]
		public ResponseStatus Status { get; set; }

		[JsonProperty(PropertyName = "data")]
		public ResponseBodyModel ResponseBody { get; set; }
	}
}
