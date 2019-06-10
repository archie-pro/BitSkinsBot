using System;
using BotSkinsAPI.Models;
using Unity;

namespace BotSkinsAPI.Helpers
{
	public class RequestBuilder : IRequestBuilder
	{
		[Dependency]
		public IQueryBuilder QueryBuilder { get; set; }

		public Uri BuildGetRequest(RequestUrlModel requestUrlModel)
		{
			UriBuilder uriBuilder = new UriBuilder();
			uriBuilder.Scheme = "https";
			uriBuilder.Host = requestUrlModel.Host;
			uriBuilder.Path = requestUrlModel.Path;
			uriBuilder.Query = requestUrlModel.Method == CallMethod.Get
				? uriBuilder.Query = this.BuildQuery(requestUrlModel.RequestParams) 
				: string.Empty;

			return uriBuilder.Uri;
		}

		public Tuple<Uri, string> BuildPostRequest(RequestUrlModel requestUrlModel)
		{
			Uri uri = this.BuildGetRequest(requestUrlModel);
			string body = this.BuildQuery(requestUrlModel.RequestParams);
			return new Tuple<Uri, string>(uri, body);
		}

		private string BuildQuery(RequestModel requestModel)
		{
			return this.QueryBuilder.BuildQuery(requestModel);
		}
	}
}
