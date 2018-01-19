using System.Web;

namespace Agent.Util
{
    class SSOAgentRequestResolver
    {
        HttpRequest request;
        SSOAgentConfig ssoAgentConfig;

        public SSOAgentRequestResolver(HttpRequest request, SSOAgentConfig ssoAgentConfig)
        {
            this.request = request;
            this.ssoAgentConfig = ssoAgentConfig;
        }

        internal bool IsOIDCSSOURL()
        {
            return ssoAgentConfig.OIDCLoginEnabled && request.RawUrl.EndsWith("/oidcsso");
        }

        internal bool IsOIDCCodeResponse()
        {
            return ssoAgentConfig.OIDCLoginEnabled && (request.Url.AbsolutePath.EndsWith("callback")
                && request.Params["code"] != null);
        }

        internal bool IsSLOURL()
        {
            return ssoAgentConfig.OIDCLoginEnabled && (request.Url.AbsolutePath.EndsWith("oidclogout"));
        }

        internal bool IsSLOResponse()
        {
            return request.Url.AbsolutePath.EndsWith("callback");
        }
    }
}
