using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace SoapCore.Tests.XmlNodeInputOutput
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSoapCore();
			services.TryAddSingleton<IXmlNodeInputOutput, XmlNodeInputOutput>();
			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseRouting();

			app.UseEndpoints(x =>
			{
				x.UseSoapEndpoint<IXmlNodeInputOutput>("/Service.svc", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
				x.UseSoapEndpoint<IXmlNodeInputOutput>("/Service.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
			});
		}
	}
}
