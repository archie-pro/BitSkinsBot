using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using BotSkinsAPI.Attributes;
using BotSkinsAPI.Models.RequestModels;

namespace BotSkinsAPI.Helpers
{
	public class QueryBuilder : IQueryBuilder
	{

		public string BuildQuery(RequestQueryModel model)
		{
			if (model == null)
			{
				return string.Empty;
			}

			IEnumerable<Tuple<string, string>> nameValueList = this.GetNameValuesOfProperties(model); 
			return this.BuildQueryString(nameValueList);
		}

		private IEnumerable<Tuple<string, string>> GetNameValuesOfProperties(RequestQueryModel model)
		{
			return this.GetAroundParamsProperty(model.RequestAuthParams).Concat(this.GetAroundParamsProperty(model.RequestBodyParams));
		}

		private IEnumerable<Tuple<string,string>> GetAroundParamsProperty(object model)
		{
			if (model == null)
			{
				return Enumerable.Empty<Tuple<string, string>>();
			}

			List<Tuple<string, string>> nameValueList = new List<Tuple<string, string>>();

			foreach (var property in model.GetType().GetProperties())
			{
				IEnumerable<Attribute> propertyAttributes = property.GetCustomAttributes();
				ParameterNameAttribute nameAttribute = propertyAttributes.FirstOrDefault(p => p is ParameterNameAttribute) as ParameterNameAttribute;
				object propertyValue = property.GetValue(model);

				if (nameAttribute != null && propertyValue != null)
				{
					string stringValue = this.GetQueryValueOfProperty(property, propertyValue);
					if (!string.IsNullOrWhiteSpace(stringValue))
					{
						nameValueList.Add(new Tuple<string, string>(nameAttribute.Name, stringValue));
					}
				}
			}

			return nameValueList;
		}

		private string GetQueryValueOfProperty(PropertyInfo property, object propertyValue)
		{
			string stringValue;
			if (propertyValue is IEnumerable<object> listPropertyValue)
			{
				stringValue = this.BuildObjectArrayQueryParam(listPropertyValue);
			}
			else if (property.PropertyType.IsEnum)
			{
				stringValue = this.GetEnumPropertyValue(property, propertyValue);
			}
			else
			{
				stringValue = propertyValue.ToString();
			}

			return stringValue;
		}

		private string BuildObjectArrayQueryParam(IEnumerable<object> list)
		{
			return string.Join(',', list.Select(e => Uri.EscapeDataString(e.ToString())));
		}

		private string BuildQueryString(IEnumerable<Tuple<string, string>> nameValueList)
		{
			return nameValueList.Any()
				? string.Join("&", nameValueList.Select(e => $"{e.Item1}={e.Item2}"))
				: string.Empty;
		}

		private string GetEnumPropertyValue(PropertyInfo enumProperty, object propertyValue)
		{
			var memInfo = enumProperty.PropertyType.GetMember(propertyValue.ToString());
			var mem = memInfo.FirstOrDefault();
			if (mem != null)
			{
				var attribute = mem.GetCustomAttribute(typeof(ParameterValueAttribute), false);
				return (attribute as ParameterValueAttribute)?.Value?.ToString();
			}
			return propertyValue?.ToString();
		}
	}
}
