using System.Runtime.Serialization;

namespace SoapCore.Tests.Serialization.Models.Xml
{
	[DataContract]
	public class DataContractWithoutNamespace
	{
		[DataMember]
		public int IntProperty { get; set; }

		[DataMember]
		public string StringProperty { get; set; }
	}
}
