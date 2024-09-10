using System.Runtime.Serialization;

namespace SoapCore.Tests.FaultExceptionTransformer
{
	[DataContract]
	public class TestFault
	{
		public TestFault()
		{
		}

		[DataMember]
		public string Message { get; set; }

		[DataMember]
		public string AdditionalProperty { get; set; }
	}
}
