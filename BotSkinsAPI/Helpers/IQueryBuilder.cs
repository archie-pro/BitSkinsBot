using BotSkinsAPI.Models.RequestModels;

namespace BotSkinsAPI.Helpers
{
	public interface IQueryBuilder
	{
		string BuildQuery(RequestQueryModel model);
	}
}
