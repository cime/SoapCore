using System.ServiceModel;

namespace SoapCore.Tests.Serialization.Models.Xml
{
	[MessageContract(IsWrapped = false)]
	public class NotWrappedFieldComplexInputRequest
	{
		[MessageBodyMember(Namespace = "http://tempuri.org/NotWrappedFieldComplexInput", Order = 0)]
#pragma warning disable SA1401 // Fields must be private
		public NotWrappedFieldComplexInput NotWrappedComplexInput;
#pragma warning restore SA1401 // Fields must be private
	}
}
