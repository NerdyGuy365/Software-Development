using IdentityServer4;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdyGuy.UserPresentation.MVC.Example
{
    public class TokenServiceConfig
    {
        public static AuthenticationOptions GetDefaultAuthenticationOptions(AuthenticationOptions options)
        {
            options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;

            return options;
        }

        public static CookieAuthenticationOptions GetCookieAuthenticationOptions(CookieAuthenticationOptions options)
        {
            options.LoginPath = new PathString("/login");

            return options;
        }

        public static OpenIdConnectOptions GetOpenIdOptionConfigurations(OpenIdConnectOptions options)
        {
            options.Authority = "http://localhost:5001";

            options.ClientId = "mvc";

            options.RequireHttpsMetadata = false;
            options.ResponseType = "id_token";

            options.Scope.Add(IdentityServerConstants.StandardScopes.OpenId);
            options.Scope.Add(IdentityServerConstants.StandardScopes.Profile);
            options.Scope.Add(IdentityServerConstants.StandardScopes.Email);

            options.SaveTokens = true;
            options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            
            return options;
        }
    }
}
