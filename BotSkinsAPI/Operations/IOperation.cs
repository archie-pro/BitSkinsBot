using BotSkinsAPI.Models;
using BotSkinsAPI.Models.RequestModels;
using BotSkinsAPI.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Operations
{
	public interface IOperation<RequestType, ResponseType> 
		where RequestType : RequestBodyModel, new()
		where ResponseType : ResponseBodyModel, new()
	{
		ResponseType DoOperation(string endpoint, RequestType model);
	}
}
