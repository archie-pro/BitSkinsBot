using BotSkinsAPI.Attributes;

namespace BotSkinsAPI.Models.RequestModels
{
	public class PagedRequestModel : RequestModel
	{
		[ParameterName(Name = "page")]
		[Required(Required = RequiredStatus.Optional)]
		public int Page { get; set; }

		[ParameterName(Name = "per_page")]
		[Required(Required = RequiredStatus.Optional)]
		public int PerPage { get; set; }
	}
}
