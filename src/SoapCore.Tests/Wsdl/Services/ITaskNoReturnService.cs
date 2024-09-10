using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace SoapCore.Tests.Wsdl.Services
{
	[ServiceContract]
	public interface ITaskNoReturnService
	{
		[OperationContract]
		Task TaskNoResultMethod();
	}

	public class TaskNoReturnService : ITaskNoReturnService
	{
		public Task TaskNoResultMethod()
		{
			throw new NotImplementedException();
		}
	}
}
