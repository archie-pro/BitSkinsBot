﻿using BotSkinsAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Models.RequestModels
{
	public class ItemsRequestModel : RequestBodyModel
	{
		[ParameterName(Name = "item_ids")]
		[Required(Required = RequiredStatus.Required)]
		public string[] ItemIds { get; set; }
	}
}
