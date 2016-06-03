// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The instance view of a virtual machine extension handler.
    /// </summary>
    public partial class VirtualMachineExtensionHandlerInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionHandlerInstanceView class.
        /// </summary>
        public VirtualMachineExtensionHandlerInstanceView() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionHandlerInstanceView class.
        /// </summary>
        public VirtualMachineExtensionHandlerInstanceView(string type = default(string), string typeHandlerVersion = default(string), InstanceViewStatus status = default(InstanceViewStatus))
        {
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
            Status = status;
        }

        /// <summary>
        /// Gets or sets full type of the extension handler which includes
        /// both publisher and type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the type version of the extension handler.
        /// </summary>
        [JsonProperty(PropertyName = "typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets the extension handler status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public InstanceViewStatus Status { get; set; }

    }
}
