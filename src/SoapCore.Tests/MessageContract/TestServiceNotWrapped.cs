using SoapCore.Tests.MessageContract.Models;
using SoapCore.Tests.Model;

namespace SoapCore.Tests.MessageContract
{
	public class TestServiceNotWrapped : IServiceWithMessageContractNotWrapped
	{
		public MessageContractResponseNotWrapped PullData(MessageContractRequestNotWrapped req)
		{
			MessageContractResponseNotWrapped ret = new MessageContractResponseNotWrapped();
			ret.ReferenceNumber = req.ReferenceNumber;
			return ret;
		}
	}
}
