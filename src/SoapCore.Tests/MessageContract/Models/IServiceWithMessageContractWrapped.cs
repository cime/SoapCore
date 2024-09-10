using System.ServiceModel;

namespace SoapCore.Tests.MessageContract.Models
{
	[ServiceContract(Namespace = "http://tempuri.org")]
	public interface IServiceWithMessageContractWrapped
	{
		[OperationContract]
		[XmlSerializerFormat(SupportFaults = true)]
		Model.MessageContractResponse PullData(Model.MessageContractRequest req);
	}
}
