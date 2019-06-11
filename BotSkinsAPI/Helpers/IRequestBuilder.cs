using BotSkinsAPI.Models;
using System;

namespace BotSkinsAPI.Helpers
{
	public interface IRequestBuilder
	{
		Uri BuildGetRequest(RequestModel requestUrlModel);

		Tuple<Uri, string> BuildPostRequest(RequestModel requestUrlModel);

	}
}
