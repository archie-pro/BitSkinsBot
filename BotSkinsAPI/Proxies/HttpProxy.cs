using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BotSkinsAPI.Proxies
{
	public class HttpProxy : IProxy
	{
		private static readonly HttpClient client = new HttpClient();

		public async Task<string> CallGet(Uri requestUri)
		{
			HttpResponseMessage result = await client.GetAsync(requestUri);
			return result.Content.ReadAsStringAsync().Result;
		}

		public async Task<string> CallPost(Uri requestUri, string requestBody)
		{
			HttpContent content = new StringContent(requestBody, Encoding.Default);
			HttpResponseMessage result = await client.PostAsync(requestUri, content);
			return result.Content.ToString();
		}
	}
}
