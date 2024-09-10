using System.ServiceModel.Channels;

namespace SoapCore.Meta
{
	public class SoapBindingInfo
	{
		public SoapBindingInfo(MessageVersion messageVersion, string bindingName, string portName)
		{
			MessageVersion = messageVersion;
			BindingName = bindingName;
			PortName = portName;
		}

		public MessageVersion MessageVersion { get; private set; }
		public string BindingName { get; private set; }
		public string PortName { get; private set; }
	}
}
