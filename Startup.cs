using System.Web.Configuration;
using System.Web.Http;
using EcoHostelAPI;
using Microsoft.Web;
using Owin;
using System.Configuration;
using Microsoft.Owin.Security.ActiveDirectory;
using Microsoft.IdentityModel.Tokens;

namespace EcoHostelAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var issuer = $"https://{ConfigurationManager.AppSettings["Auth0Domain"]}/";
            var audience = ConfigurationManager.AppSettings["Auth0ClientID"];

            // Api controllers with an [Authorize] attribute will be validated with JWT
            app.UseActiveDirectoryFederationServicesBearerAuthentication(
                new ActiveDirectoryFederationServicesBearerAuthenticationOptions
                {
                    TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidAudience = audience,
                        ValidIssuer = issuer,
                        IssuerSigningKeyResolver = (token, securityToken, identifier, parameters) => parameters.IssuerSigningTokens.FirstOrDefault()?.SecurityKeys?.FirstOrDefault()
                    },
            // Setting the MetadataEndpoint so the middleware can download the RS256 certificate
            MetadataEndpoint = $"{issuer.TrimEnd('/')}/wsfed/{audience}/FederationMetadata/2007-06/FederationMetadata.xml"
                });


            // Configure Web API
            WebApiConfig.Configure(app);
        }
    }
}