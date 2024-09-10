using System;
using System.IO;
using System.ServiceModel;

namespace SoapCore.Tests.Wsdl.Services
{
	[ServiceContract]
	public interface IStreamService
	{
		[OperationContract]
		Stream GetStream();
	}

	public class StreamService : IStreamService
	{
		public Stream GetStream()
		{
			throw new NotImplementedException();
		}
	}
}
