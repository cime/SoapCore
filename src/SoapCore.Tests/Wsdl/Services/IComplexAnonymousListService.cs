using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace SoapCore.Tests.Wsdl.Services
{
	[ServiceContract]
	public interface IComplexAnonymousListService
	{
		[OperationContract]
		List<ComplexTypeAnonymous> Test();
	}

	public class ComplexAnonymousListService : IComplexAnonymousListService
	{
		public List<ComplexTypeAnonymous> Test() => throw new NotImplementedException();
	}
}
