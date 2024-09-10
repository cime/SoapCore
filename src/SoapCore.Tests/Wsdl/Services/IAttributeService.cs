using System;
using System.ServiceModel;

namespace SoapCore.Tests.Wsdl.Services
{
	[ServiceContract]
	public interface IAttributeService
	{
		[OperationContract]
		AttributeType Method();
	}

	public class AttributeService : IAttributeService
	{
		public AttributeType Method()
		{
			throw new NotImplementedException();
		}
	}
}
