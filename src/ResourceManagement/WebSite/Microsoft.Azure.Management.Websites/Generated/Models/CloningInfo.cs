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
    /// Represents information needed for cloning operation
    /// </summary>
    public partial class CloningInfo
    {
        /// <summary>
        /// Initializes a new instance of the CloningInfo class.
        /// </summary>
        public CloningInfo() { }

        /// <summary>
        /// Initializes a new instance of the CloningInfo class.
        /// </summary>
        public CloningInfo(string correlationId = default(string), bool? overwrite = default(bool?), bool? cloneCustomHostNames = default(bool?), bool? cloneSourceControl = default(bool?), string sourceWebAppId = default(string), string hostingEnvironment = default(string), IDictionary<string, string> appSettingsOverrides = default(IDictionary<string, string>), bool? configureLoadBalancing = default(bool?), string trafficManagerProfileId = default(string), string trafficManagerProfileName = default(string))
        {
            CorrelationId = correlationId;
            Overwrite = overwrite;
            CloneCustomHostNames = cloneCustomHostNames;
            CloneSourceControl = cloneSourceControl;
            SourceWebAppId = sourceWebAppId;
            HostingEnvironment = hostingEnvironment;
            AppSettingsOverrides = appSettingsOverrides;
            ConfigureLoadBalancing = configureLoadBalancing;
            TrafficManagerProfileId = trafficManagerProfileId;
            TrafficManagerProfileName = trafficManagerProfileName;
        }

        /// <summary>
        /// Correlation Id of cloning operation. This id ties multiple cloning
        /// operations
        /// together to use the same snapshot
        /// </summary>
        [JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Overwrite destination web app
        /// </summary>
        [JsonProperty(PropertyName = "overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// If true, clone custom hostnames from source web app
        /// </summary>
        [JsonProperty(PropertyName = "cloneCustomHostNames")]
        public bool? CloneCustomHostNames { get; set; }

        /// <summary>
        /// Clone source control from source web app
        /// </summary>
        [JsonProperty(PropertyName = "cloneSourceControl")]
        public bool? CloneSourceControl { get; set; }

        /// <summary>
        /// ARM resource id of the source web app. Web app resource id is of
        /// the form
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}
        /// for production slots and
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName}
        /// for other slots
        /// </summary>
        [JsonProperty(PropertyName = "sourceWebAppId")]
        public string SourceWebAppId { get; set; }

        /// <summary>
        /// Hosting environment
        /// </summary>
        [JsonProperty(PropertyName = "hostingEnvironment")]
        public string HostingEnvironment { get; set; }

        /// <summary>
        /// Application settings overrides for cloned web app. If specified
        /// these settings will override the settings cloned
        /// from source web app. If not specified, application
        /// settings from source web app are retained.
        /// </summary>
        [JsonProperty(PropertyName = "appSettingsOverrides")]
        public IDictionary<string, string> AppSettingsOverrides { get; set; }

        /// <summary>
        /// If specified configure load balancing for source and clone site
        /// </summary>
        [JsonProperty(PropertyName = "configureLoadBalancing")]
        public bool? ConfigureLoadBalancing { get; set; }

        /// <summary>
        /// ARM resource id of the traffic manager profile to use if it
        /// exists. Traffic manager resource id is of the form
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}
        /// </summary>
        [JsonProperty(PropertyName = "trafficManagerProfileId")]
        public string TrafficManagerProfileId { get; set; }

        /// <summary>
        /// Name of traffic manager profile to create. This is only needed if
        /// traffic manager profile does not already exist
        /// </summary>
        [JsonProperty(PropertyName = "trafficManagerProfileName")]
        public string TrafficManagerProfileName { get; set; }

    }
}
