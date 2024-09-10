using System.ServiceModel;

namespace SoapCore.Tests.Serialization.Models.Xml
{
	[MessageContract(IsWrapped = false)]
	public class NotWrappedPropertyComplexInputRequest
	{
		[MessageBodyMember(Namespace = "http://tempuri.org/NotWrappedPropertyComplexInput", Order = 0)]
		public NotWrappedPropertyComplexInput NotWrappedComplexInput { get; set; }
	}
}
