using System;
using System.Collections.Generic;
using System.Text;
using BotSkinsAPI.Models;
using System.Reflection;
using System.Linq;
using BotSkinsAPI.Attributes;

namespace BotSkinsAPI.Services
{
	public class QueryBuilder : IQueryBuilder
	{

		public string BuildQuery(RequestModel model)
		{
			PropertyInfo[] properties = model.GetType().GetProperties();

			return string.Empty;
		}
	}
}
