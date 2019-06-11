using BotSkinsAPI.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Services
{
	interface IAccountService
	{
		GetAccountResponseModel GetAccountBalance();
	}
}
