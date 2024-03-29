﻿using BotSkinsAPI.Attributes;
using System;
using System.Linq;

namespace BotSkinsAPI.Models.RequestModels
{
	public class ItemsPricesRequestModel : RequestBodyModel
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
