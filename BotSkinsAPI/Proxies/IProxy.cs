using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Proxies
{
	public interface IProxy
	{
		string CallGet();

		string CallPost();
	}
}
