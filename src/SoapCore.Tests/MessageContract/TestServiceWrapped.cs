using SoapCore.Tests.MessageContract.Models;
using SoapCore.Tests.Model;

namespace SoapCore.Tests.MessageContract
{
	public class TestServiceWrapped : IServiceWithMessageContractWrapped
	{
		public MessageContractResponse PullData(MessageContractRequest req)
		{
			MessageContractResponse ret = new MessageContractResponse();
			ret.ReferenceNumber = req.ReferenceNumber;
			return ret;
		}
	}
}
