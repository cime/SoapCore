using System.Runtime.Serialization;

namespace SoapCore.Tests.Model
{
	[DataContract]
	public class ComplexTreeModelInput : IComplexTreeModelInput
	{
		[DataMember]
		public ComplexModelInput Item { get; set; }
	}
}
