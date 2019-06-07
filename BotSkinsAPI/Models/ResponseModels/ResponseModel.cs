using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models
{
	public enum ResponseStatus
	{
		Success,
		Error
	}
	public class ResponseModel
	{
		ResponseStatus Status { get; set; }
		object ResponseBody { get; set; }
	}
}
