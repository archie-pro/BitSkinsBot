using BotSkinsAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Services
{
	public interface IQueryBuilder
	{
		string BuildQuery(RequestModel model);
	}
}
