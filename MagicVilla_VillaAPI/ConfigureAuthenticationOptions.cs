using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MagicVilla_VillaAPI
{
    public static class ConfigureAuthenticationOptions
    {
        public static void AddCustomAuthentication(this IServiceCollection services, string key)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(bearerOptions =>
            {
                bearerOptions.RequireHttpsMetadata = false;
                bearerOptions.SaveToken = true;
                bearerOptions.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                    ValidateIssuer = true,
                    ValidIssuer = "https://magicvilla-api.com",
                    ValidAudience = "https://test-magic-api.com",
                    ValidateAudience = true,
                    ClockSkew = TimeSpan.Zero
                };
            });
        }
    }
