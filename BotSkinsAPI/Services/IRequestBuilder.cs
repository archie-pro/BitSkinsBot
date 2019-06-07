using BotSkinsAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Services
{
	public interface IRequestBuilder
	{
		Uri BuildGetRequest(RequestUrlModel requestUrlModel);

		Tuple<Uri, string> BuildPostRequest(RequestUrlModel requestUrlModel);

	}
}
