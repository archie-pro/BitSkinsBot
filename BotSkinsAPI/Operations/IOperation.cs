using System;
using System.Collections.Generic;
using System.Text;

namespace BotSkinsAPI.Operations
{
	public interface IOperation
	{
		void DoOperation();

		string BuildUrl();
	}
}
