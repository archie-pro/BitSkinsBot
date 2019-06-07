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

			List<Tuple<string, string>> nameValueArray = new List<Tuple<string, string>>(properties.Length);

			foreach (var prop in properties)
			{
				IEnumerable<Attribute> propAttributes = prop.GetCustomAttributes();
				ParameterNameAttribute nameAttribute = propAttributes.FirstOrDefault(p => p is ParameterNameAttribute) as ParameterNameAttribute;
				if (nameAttribute != null)
				{
					object value = prop.PropertyType == typeof(Enum) ? this.GetEnumFieldAttribute(prop) : prop.GetValue(model);

					string stringValue;
					stringValue = value is IEnumerable<object>
						? string.Join(",", value as IEnumerable<object>)
						: value.ToString();
					nameValueArray.Add(new Tuple<string, string>(nameAttribute.Name, stringValue));
				}
			}

			return string.Empty;
		}

		private string GetEnumFieldAttribute(PropertyInfo enumProperty)
		{
			return string.Empty;
		}
	}
}
