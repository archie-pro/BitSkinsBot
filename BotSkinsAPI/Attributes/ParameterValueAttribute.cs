using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Attributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ParameterValueAttribute : Attribute
	{
		public object Value { get; set; }
	}
}
