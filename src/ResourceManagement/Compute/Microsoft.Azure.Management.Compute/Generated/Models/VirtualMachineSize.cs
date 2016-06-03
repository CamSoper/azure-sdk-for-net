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
    /// Describes the properties of a VM size.
    /// </summary>
    public partial class VirtualMachineSize
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineSize class.
        /// </summary>
        public VirtualMachineSize() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineSize class.
        /// </summary>
        public VirtualMachineSize(string name = default(string), int? numberOfCores = default(int?), int? osDiskSizeInMB = default(int?), int? resourceDiskSizeInMB = default(int?), int? memoryInMB = default(int?), int? maxDataDiskCount = default(int?))
        {
            Name = name;
            NumberOfCores = numberOfCores;
            OsDiskSizeInMB = osDiskSizeInMB;
            ResourceDiskSizeInMB = resourceDiskSizeInMB;
            MemoryInMB = memoryInMB;
            MaxDataDiskCount = maxDataDiskCount;
        }

        /// <summary>
        /// Gets or sets the VM size name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Number of cores supported by a VM size.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfCores")]
        public int? NumberOfCores { get; set; }

        /// <summary>
        /// Gets or sets the OS disk size allowed by a VM size.
        /// </summary>
        [JsonProperty(PropertyName = "osDiskSizeInMB")]
        public int? OsDiskSizeInMB { get; set; }

        /// <summary>
        /// Gets or sets the Resource disk size allowed by a VM size.
        /// </summary>
        [JsonProperty(PropertyName = "resourceDiskSizeInMB")]
        public int? ResourceDiskSizeInMB { get; set; }

        /// <summary>
        /// Gets or sets the Memory size supported by a VM size.
        /// </summary>
        [JsonProperty(PropertyName = "memoryInMB")]
        public int? MemoryInMB { get; set; }

        /// <summary>
        /// Gets or sets the Maximum number of data disks allowed by a VM size.
        /// </summary>
        [JsonProperty(PropertyName = "maxDataDiskCount")]
        public int? MaxDataDiskCount { get; set; }

    }
}
