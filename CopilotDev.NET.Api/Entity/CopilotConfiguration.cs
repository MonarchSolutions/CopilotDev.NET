﻿namespace CopilotDev.NET.Api.Entity
{
    public class CopilotConfiguration
    {
        /// <summary>
        /// The AppId identifying this application. Retrieved using reverse engineering techniques but it is not
        /// be considered a secret in OAuth application flows, so it is fine to put it here.
        /// </summary>
        public string GithubAppId { get; set; } = "Iv1.b507a08c87ecfe98";

        /// <summary>
        /// Github GrantType for the OAuth application flow.
        /// </summary>
        public string GithubGrantType { get; set; } = "urn:ietf:params:oauth:grant-type:device_code";

        /// <summary>
        /// User Agent identifier for the http client.
        /// </summary>
        public string UserAgent { get; set; } = "Mozilla/5.0 (Windows NT x.y; rv:10.0) Gecko/20100101 Firefox/10.0";
    }
}
