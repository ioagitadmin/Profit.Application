using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Profit.WebApi
{
    public class VersionHelper
    {
        public static OpenApiInfo CreateApiVersionInfo(ApiVersionDescription description)
        {
            var info = new OpenApiInfo()
            {
                Title = "Message API",
                Version = description.ApiVersion.ToString()
            };

            return info;
        }

        public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
        {
            readonly IApiVersionDescriptionProvider provider;

            public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => this.provider = provider;

            public void Configure(SwaggerGenOptions options)
            {
                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerDoc(description.GroupName, CreateApiVersionInfo(description));
                }
            }          
        }
    }
}
