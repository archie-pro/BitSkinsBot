using BotSkinsAPI.Helpers;
using BotSkinsAPI.Models;
using BotSkinsAPI.Models.RequestModels;
using BotSkinsAPI.Models.ResponseModels;
using BotSkinsAPI.Proxies;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using Unity;

namespace BotSkinsAPI.Operations
{
	public class Operation<RequestType, ResponseType> : IOperation<RequestType, ResponseType> 
		where RequestType : RequestBodyModel, new()
		where ResponseType : ResponseBodyModel, new()
	{
		[Dependency]
		public IProxy HttpProxy { get; set; }

		[Dependency]
		public IRequestBuilder RequestBuilder { get; set; }

		[Dependency]
		public ISecureCodeGenerator SecureCodeGenerator { get; set; }

		public ResponseType DoOperation(string endpoint, RequestType requestBody)
		{
			RequestModel request = this.BuildRequestModel(endpoint, requestBody);
			Uri uri = this.RequestBuilder.BuildGetRequest(request);

			string result = HttpProxy.CallGet(uri).Result;

			return JObject.Parse(result)["data"].ToObject<ResponseType>();
		}

		private CallMethod ResolveCallMethod(string endpoint)
		{
			return Constants.EndpointCallMethods.FirstOrDefault(e => e.Key == endpoint).Value;
		}

		private RequestModel BuildRequestModel(string endpoint, RequestType requestBody)
		{
			requestBody = requestBody ?? new RequestType();
			RequestModel model = new RequestModel()
			{
				Host = Constants.Host,
				Method = this.ResolveCallMethod(endpoint),
				Path = endpoint,
				RequestParams = new RequestQueryModel()
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = BotConfigurator.ApiKey,
						Code = this.SecureCodeGenerator.Generate()
					},
					RequestBodyParams = requestBody
				}
			};

			return model;
		}
	}
}
