using BotSkinsAPI.Attributes;

namespace BotSkinsAPI.Models.RequestModels
{
	public class CreateOrderRequestModel : RequestBodyModel
	{
		[ParameterName(Name = "name")]
		[Required(Required = RequiredStatus.Required)]
		public string Name { get; set; }

		[ParameterName(Name = "price")]
		[Required(Required = RequiredStatus.Required)]
		public string Price { get; set; }

		[ParameterName(Name = "quantity")]
		[Required(Required = RequiredStatus.Optional)]
		public string Quantity { get; set; }
	}
}
