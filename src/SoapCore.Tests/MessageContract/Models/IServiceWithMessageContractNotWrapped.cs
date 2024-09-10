using System.ServiceModel;

namespace SoapCore.Tests.MessageContract.Models
{
	[ServiceContract(Namespace = "http://tempuri.org")]
	public interface IServiceWithMessageContractNotWrapped
	{
		[OperationContract]
		[XmlSerializerFormat(SupportFaults = true)]
		Model.MessageContractResponseNotWrapped PullData(Model.MessageContractRequestNotWrapped req);
	}
}
