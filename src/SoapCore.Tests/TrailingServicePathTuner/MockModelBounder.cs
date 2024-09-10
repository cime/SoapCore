using System.Reflection;
using SoapCore.Extensibility;

namespace SoapCore.Tests
{
	internal class MockModelBounder : ISoapModelBounder
	{
		public void OnModelBound(MethodInfo methodInfo, object[] prms)
		{
			return;
		}
	}
}
