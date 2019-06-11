using BotSkinsAPI.Attributes;

namespace BotSkinsAPI.Models.RequestModels
{
	public class CancelOrderByIdRequestModel : RequestBodyModel
	{
		[ParameterName(Name = "buy_order_ids")]
		[Required(Required = RequiredStatus.Required)]
		public string[] OrderIds;
	}
}
