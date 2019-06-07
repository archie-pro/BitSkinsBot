using System;

namespace BotSkinsAPI.Attributes
{
	[System.AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ParameterNameAttribute : Attribute
	{
		public string Name { get; set; }
	}
}
