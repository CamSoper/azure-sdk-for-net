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
    /// Describes main public ip address and any extra vips
    /// </summary>
    public partial class AddressResponse
    {
        /// <summary>
        /// Initializes a new instance of the AddressResponse class.
        /// </summary>
        public AddressResponse() { }

        /// <summary>
        /// Initializes a new instance of the AddressResponse class.
        /// </summary>
        public AddressResponse(string serviceIpAddress = default(string), string internalIpAddress = default(string), IList<string> outboundIpAddresses = default(IList<string>), IList<VirtualIPMapping> vipMappings = default(IList<VirtualIPMapping>))
        {
            ServiceIpAddress = serviceIpAddress;
            InternalIpAddress = internalIpAddress;
            OutboundIpAddresses = outboundIpAddresses;
            VipMappings = vipMappings;
        }

        /// <summary>
        /// Main public vip
        /// </summary>
        [JsonProperty(PropertyName = "serviceIpAddress")]
        public string ServiceIpAddress { get; set; }

        /// <summary>
        /// VNET internal ip address of the hostingEnvironment (App Service
        /// Environment) if it is in internal load-balancing mode
        /// </summary>
        [JsonProperty(PropertyName = "internalIpAddress")]
        public string InternalIpAddress { get; set; }

        /// <summary>
        /// IP addresses appearing on outbound connections
        /// </summary>
        [JsonProperty(PropertyName = "outboundIpAddresses")]
        public IList<string> OutboundIpAddresses { get; set; }

        /// <summary>
        /// Additional vips
        /// </summary>
        [JsonProperty(PropertyName = "vipMappings")]
        public IList<VirtualIPMapping> VipMappings { get; set; }

    }
}
