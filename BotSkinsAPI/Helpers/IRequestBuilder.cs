using BotSkinsAPI.Models;
using System;

namespace BotSkinsAPI.Helpers
{
	public interface IRequestBuilder
	{
		Uri BuildGetRequest(RequestUrlModel requestUrlModel);

		Tuple<Uri, string> BuildPostRequest(RequestUrlModel requestUrlModel);

	}
}
