using Agent.Util;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Agent
{
    class SSOAgentPropertyInitializer
    {
        public void InitializePropertySet()
        {
            Dictionary<string, string> ssoProperties = new Dictionary<string, string>();

            //assign default values for properties
            LoadDefaultValuesForProperties(ssoProperties);

            //load values from Settings.settings file
            LoadSettingsFileValuesForProperties(ssoProperties);

            SSOAgentConfig ssoAgentConfig = new SSOAgentConfig(ssoProperties);

            HttpContext.Current.Application[SSOAgentConstants.CONFIG_BEAN_NAME] = ssoAgentConfig;
        }

        private void LoadDefaultValuesForProperties(Dictionary<string, string> ssoProperties)
        {
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.ENABLE_OIDC_SSO_LOGIN, "false");
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC_SSO_URL, "oidcsso");
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.SERVICE_PROVIDER_NAME, null);
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.CLIENT_ID, null);
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.CLIENT_SECRET, null);
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.CALL_BACK_URL, null);
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.OIDC_LOGOUT_ENDPOINT, "https://localhost:9443/oidc/logout");
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.OIDC_SESSION_IFRAME_ENDPOINT, null);
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.POST_LOGOUT_REDIRECT_URI, null);
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.OAUTH2_AUTHZ_ENDPOINT, "https://localhost:9443/oauth2/authorize");
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.OAUTH2_TOKEN_ENDPOINT, "https://localhost:9443/oauth2/token");
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.OAUTH2_USER_INFO_ENDPOINT, "https://localhost:9443/oauth2/userinfo?schema=openid");
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.OAUTH2_GRANT_TYPE, "code");
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.ENABLE_ID_TOKEN_VALIDATION, "false");
            ssoProperties.Add(SSOAgentConstants.SSOAgentConfig.OIDC.SCOPE, "openid");
        }

        private void LoadSettingsFileValuesForProperties(Dictionary<string, string> ssoProperties)
        {
            // Overriding default values with properties defined under appSettings in web.config file.
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            for (int i = 0; i < appSettings.Count; i++)
            {
                if (ssoProperties.Keys.Contains(appSettings.GetKey(i)))
                {
                    ssoProperties[appSettings.GetKey(i)] = appSettings.Get(i);
                }
            }
        }
    }
}
