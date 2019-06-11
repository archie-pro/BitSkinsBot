using BotSkinsAPI.Models.RequestModels;

namespace BotSkinsAPI.Models
{
	public enum CallMethod
	{
		Get = 0,
		Post = 1
	}
	public class RequestModel
	{
		public string Host { get; set; }
		public string Path { get; set; }
		public string Scheme { get; set; }
		public CallMethod Method { get; set; }
		public RequestQueryModel RequestParams { get; set; }
	}
}
