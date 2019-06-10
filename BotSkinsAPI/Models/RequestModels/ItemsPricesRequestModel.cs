using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public class ItemsPricesRequestModel : RequestModel
	{
		public Tuple<string, string>[] ItemPriceArray { get; set; } = new Tuple<string, string>[0];

		[ParameterName(Name = "item_ids")]
		[Required(Required = RequiredStatus.Required)]
		public string[] ItemIds
		{
			get
			{
				return this.ItemPriceArray?.Select(e => e.Item1).ToArray();
			}
		}

		[ParameterName(Name ="prices")]
		[Required(Required =RequiredStatus.Required)]
		public string[] Prices
		{
			get
			{
				return this.ItemPriceArray?.Select(e => e.Item2).ToArray();
			}
		}
	}
}
