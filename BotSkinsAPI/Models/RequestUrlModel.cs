using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models
{
	public enum CallMethod
	{
		Get,
		Post
	}
	public class RequestUrlModel
	{
		public string Host { get; set; }
		public string Path { get; set; }
		public CallMethod Method { get; set; }
		public RequestModel RequestParams { get; set; }
	}
}
