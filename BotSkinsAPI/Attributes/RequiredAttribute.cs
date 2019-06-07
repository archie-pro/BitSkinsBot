using System;

namespace BotSkinsAPI.Attributes
{
	public enum RequiredStatus
	{
		Required = 1,
		Optional = 2
	}

	[System.AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class RequiredAttribute : Attribute
	{
		public RequiredStatus Required { get; set; }
	}
}
