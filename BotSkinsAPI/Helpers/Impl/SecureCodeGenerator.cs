using OtpSharp;
using Wiry.Base32;

namespace BotSkinsAPI.Helpers
{
	public class SecureCodeGenerator : ISecureCodeGenerator
	{
		public string Generate()
		{
			var secret = BotConfigurator.SecureCode;

			var totpgen = new Totp(Base32Encoding.Standard.ToBytes(secret), timeCorrection: new TimeCorrection(System.DateTime.UtcNow));

			return totpgen.ComputeTotp();
		}
	}
}
