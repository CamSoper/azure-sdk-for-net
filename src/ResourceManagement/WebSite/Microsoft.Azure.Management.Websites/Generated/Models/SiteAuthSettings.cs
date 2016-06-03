// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Configuration settings for the Azure App Service Authentication /
    /// Authorization feature.
    /// </summary>
    public partial class SiteAuthSettings
    {
        /// <summary>
        /// Initializes a new instance of the SiteAuthSettings class.
        /// </summary>
        public SiteAuthSettings() { }

        /// <summary>
        /// Initializes a new instance of the SiteAuthSettings class.
        /// </summary>
        public SiteAuthSettings(bool? enabled = default(bool?), string httpApiPrefixPath = default(string), UnauthenticatedClientAction? unauthenticatedClientAction = default(UnauthenticatedClientAction?), bool? tokenStoreEnabled = default(bool?), IList<string> allowedExternalRedirectUrls = default(IList<string>), BuiltInAuthenticationProvider? defaultProvider = default(BuiltInAuthenticationProvider?), string clientId = default(string), string clientSecret = default(string), string issuer = default(string), IList<string> allowedAudiences = default(IList<string>), IList<string> additionalLoginParams = default(IList<string>), string aadClientId = default(string), string openIdIssuer = default(string), string googleClientId = default(string), string googleClientSecret = default(string), IList<string> googleOAuthScopes = default(IList<string>), string facebookAppId = default(string), string facebookAppSecret = default(string), IList<string> facebookOAuthScopes = default(IList<string>), string twitterConsumerKey = default(string), string twitterConsumerSecret = default(string), string microsoftAccountClientId = default(string), string microsoftAccountClientSecret = default(string), IList<string> microsoftAccountOAuthScopes = default(IList<string>))
        {
            Enabled = enabled;
            HttpApiPrefixPath = httpApiPrefixPath;
            UnauthenticatedClientAction = unauthenticatedClientAction;
            TokenStoreEnabled = tokenStoreEnabled;
            AllowedExternalRedirectUrls = allowedExternalRedirectUrls;
            DefaultProvider = defaultProvider;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Issuer = issuer;
            AllowedAudiences = allowedAudiences;
            AdditionalLoginParams = additionalLoginParams;
            AadClientId = aadClientId;
            OpenIdIssuer = openIdIssuer;
            GoogleClientId = googleClientId;
            GoogleClientSecret = googleClientSecret;
            GoogleOAuthScopes = googleOAuthScopes;
            FacebookAppId = facebookAppId;
            FacebookAppSecret = facebookAppSecret;
            FacebookOAuthScopes = facebookOAuthScopes;
            TwitterConsumerKey = twitterConsumerKey;
            TwitterConsumerSecret = twitterConsumerSecret;
            MicrosoftAccountClientId = microsoftAccountClientId;
            MicrosoftAccountClientSecret = microsoftAccountClientSecret;
            MicrosoftAccountOAuthScopes = microsoftAccountOAuthScopes;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the Authentication /
        /// Authorization feature is enabled for the current app.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the relative path prefix used by platform HTTP APIs.
        /// Changing this value is not recommended except for
        /// compatibility reasons.
        /// </summary>
        [JsonProperty(PropertyName = "httpApiPrefixPath")]
        public string HttpApiPrefixPath { get; set; }

        /// <summary>
        /// Gets or sets the action to take when an unauthenticated client
        /// attempts to access the app. Possible values for this property
        /// include: 'RedirectToLoginPage', 'AllowAnonymous'.
        /// </summary>
        [JsonProperty(PropertyName = "unauthenticatedClientAction")]
        public UnauthenticatedClientAction? UnauthenticatedClientAction { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to durably store
        /// platform-specific security tokens
        /// obtained during login flows. This capability is
        /// disabled by default.
        /// </summary>
        [JsonProperty(PropertyName = "tokenStoreEnabled")]
        public bool? TokenStoreEnabled { get; set; }

        /// <summary>
        /// Gets or sets a collection of external URLs that can be redirected
        /// to as part of logging in
        /// or logging out of the web app. Note that the query
        /// string part of the URL is ignored.
        /// This is an advanced setting typically only needed by
        /// Windows Store application backends.
        /// Note that URLs within the current domain are always
        /// implicitly allowed.
        /// </summary>
        [JsonProperty(PropertyName = "allowedExternalRedirectUrls")]
        public IList<string> AllowedExternalRedirectUrls { get; set; }

        /// <summary>
        /// Gets or sets the default authentication provider to use when
        /// multiple providers are configured.
        /// This setting is only needed if multiple providers are
        /// configured and the unauthenticated client
        /// action is set to "RedirectToLoginPage". Possible
        /// values for this property include: 'AzureActiveDirectory',
        /// 'Facebook', 'Google', 'MicrosoftAccount', 'Twitter'.
        /// </summary>
        [JsonProperty(PropertyName = "defaultProvider")]
        public BuiltInAuthenticationProvider? DefaultProvider { get; set; }

        /// <summary>
        /// Gets or sets the Client ID of this relying party application,
        /// known as the client_id.
        /// This setting is required for enabling OpenID
        /// Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect:
        /// http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the Client Secret of this relying party application
        /// (in Azure Active Directory, this is also referred to as the Key).
        /// This setting is optional. If no client secret is
        /// configured, the OpenID Connect implicit auth flow is used to
        /// authenticate end users.
        /// Otherwise, the OpenID Connect Authorization Code Flow
        /// is used to authenticate end users.
        /// More information on OpenID Connect:
        /// http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the OpenID Connect Issuer URI that represents the
        /// entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the
        /// URI of the directory tenant, e.g.
        /// https://sts.windows.net/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token
        /// issuer.
        /// More information on OpenID Connect Discovery:
        /// http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets a list of allowed audience values to consider when
        /// validating JWTs issued by
        /// Azure Active Directory. Note that the
        /// {Microsoft.Web.Hosting.Administration.SiteAuthSettings.ClientId}
        /// value is always considered an
        /// allowed audience, regardless of this setting.
        /// </summary>
        [JsonProperty(PropertyName = "allowedAudiences")]
        public IList<string> AllowedAudiences { get; set; }

        /// <summary>
        /// Gets or sets a list of login parameters to send to the OpenID
        /// Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form
        /// "key=value".
        /// </summary>
        [JsonProperty(PropertyName = "additionalLoginParams")]
        public IList<string> AdditionalLoginParams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aadClientId")]
        public string AadClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "openIdIssuer")]
        public string OpenIdIssuer { get; set; }

        /// <summary>
        /// Gets or sets the OpenID Connect Client ID for the Google web
        /// application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation:
        /// https://developers.google.com/identity/sign-in/web/
        /// </summary>
        [JsonProperty(PropertyName = "googleClientId")]
        public string GoogleClientId { get; set; }

        /// <summary>
        /// Gets or sets the client secret associated with the Google web
        /// application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation:
        /// https://developers.google.com/identity/sign-in/web/
        /// </summary>
        [JsonProperty(PropertyName = "googleClientSecret")]
        public string GoogleClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 scopes that will be requested as part
        /// of Google Sign-In authentication.
        /// This setting is optional. If not specified, "openid",
        /// "profile", and "email" are used as default scopes.
        /// Google Sign-In documentation:
        /// https://developers.google.com/identity/sign-in/web/
        /// </summary>
        [JsonProperty(PropertyName = "googleOAuthScopes")]
        public IList<string> GoogleOAuthScopes { get; set; }

        /// <summary>
        /// Gets or sets the App ID of the Facebook app used for login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation:
        /// https://developers.facebook.com/docs/facebook-login
        /// </summary>
        [JsonProperty(PropertyName = "facebookAppId")]
        public string FacebookAppId { get; set; }

        /// <summary>
        /// Gets or sets the App Secret of the Facebook app used for Facebook
        /// Login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation:
        /// https://developers.facebook.com/docs/facebook-login
        /// </summary>
        [JsonProperty(PropertyName = "facebookAppSecret")]
        public string FacebookAppSecret { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 scopes that will be requested as part
        /// of Facebook Login authentication.
        /// This setting is optional.
        /// Facebook Login documentation:
        /// https://developers.facebook.com/docs/facebook-login
        /// </summary>
        [JsonProperty(PropertyName = "facebookOAuthScopes")]
        public IList<string> FacebookOAuthScopes { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 1.0a consumer key of the Twitter
        /// application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation:
        /// https://dev.twitter.com/web/sign-in
        /// </summary>
        [JsonProperty(PropertyName = "twitterConsumerKey")]
        public string TwitterConsumerKey { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 1.0a consumer secret of the Twitter
        /// application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation:
        /// https://dev.twitter.com/web/sign-in
        /// </summary>
        [JsonProperty(PropertyName = "twitterConsumerSecret")]
        public string TwitterConsumerSecret { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 client ID that was created for the app
        /// used for authentication.
        /// This setting is required for enabling Microsoft
        /// Account authentication.
        /// Microsoft Account OAuth documentation:
        /// https://dev.onedrive.com/auth/msa_oauth.htm
        /// </summary>
        [JsonProperty(PropertyName = "microsoftAccountClientId")]
        public string MicrosoftAccountClientId { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 client secret that was created for the
        /// app used for authentication.
        /// This setting is required for enabling Microsoft
        /// Account authentication.
        /// Microsoft Account OAuth documentation:
        /// https://dev.onedrive.com/auth/msa_oauth.htm
        /// </summary>
        [JsonProperty(PropertyName = "microsoftAccountClientSecret")]
        public string MicrosoftAccountClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 scopes that will be requested as part
        /// of Microsoft Account authentication.
        /// This setting is optional. If not specified, "wl.basic"
        /// is used as the default scope.
        /// Microsoft Account Scopes and permissions
        /// documentation: https://msdn.microsoft.com/en-us/library/dn631845.aspx
        /// </summary>
        [JsonProperty(PropertyName = "microsoftAccountOAuthScopes")]
        public IList<string> MicrosoftAccountOAuthScopes { get; set; }

    }
}
