using System;
using System.ServiceModel;

namespace SoapCore.Tests.Wsdl.Services
{
	[ServiceContract]
	public interface IDataContractContainsItselfService
	{
		[OperationContract]
		PaymentResponse GetErrorDetail();
	}

	public class DataContractContainsItselfService : IDataContractContainsItselfService
	{
		public PaymentResponse GetErrorDetail()
		{
			throw new NotImplementedException();
		}
	}
}
