using System;
using System.Threading.Tasks;

namespace BotSkinsAPI.Proxies
{
	public interface IProxy
	{
		Task<string> CallGet(Uri requestUri);

		Task<string> CallPost(Uri requestUri, string requestBody);
	}
}
