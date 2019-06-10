using BotSkinsAPI.Models;

namespace BotSkinsAPI.Helpers
{
	public interface IQueryBuilder
	{
		string BuildQuery(RequestModel model);
	}
}
