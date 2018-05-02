using IdentityServer4.AccessTokenValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdyGuy.Services.NetCore.Example
{
    public class TokenServiceConfig
    {
        public static IdentityServerAuthenticationOptions GetDefaultAuthenticationOptions(IdentityServerAuthenticationOptions options)
        {
            options.Authority = "http://localhost:5001";
            options.RequireHttpsMetadata = false;

            options.ApiName = "api1";

            return options;
        }
    }
}
