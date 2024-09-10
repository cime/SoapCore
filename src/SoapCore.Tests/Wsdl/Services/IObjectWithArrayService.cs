using System;
using System.ServiceModel;

namespace SoapCore.Tests.Wsdl.Services
{
	[ServiceContract]
	public interface IObjectWithArrayService
	{
		[OperationContract]
		void Method(MyClassWithArray model);
	}

	public class ObjectWithArrayService : IObjectWithArrayService
	{
		public void Method(MyClassWithArray model)
		{
			throw new NotImplementedException();
		}
	}
}
