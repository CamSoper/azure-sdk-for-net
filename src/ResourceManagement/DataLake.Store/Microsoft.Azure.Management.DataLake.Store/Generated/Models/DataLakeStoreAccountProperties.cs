// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Data Lake Store account properties information
    /// </summary>
    public partial class DataLakeStoreAccountProperties
    {
        /// <summary>
        /// Initializes a new instance of the DataLakeStoreAccountProperties
        /// class.
        /// </summary>
        public DataLakeStoreAccountProperties() { }

        /// <summary>
        /// Initializes a new instance of the DataLakeStoreAccountProperties
        /// class.
        /// </summary>
        public DataLakeStoreAccountProperties(DataLakeStoreAccountStatus? provisioningState = default(DataLakeStoreAccountStatus?), DataLakeStoreAccountState? state = default(DataLakeStoreAccountState?), DateTime? creationTime = default(DateTime?), DateTime? lastModifiedTime = default(DateTime?), string endpoint = default(string), string defaultGroup = default(string))
        {
            ProvisioningState = provisioningState;
            State = state;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Endpoint = endpoint;
            DefaultGroup = defaultGroup;
        }

        /// <summary>
        /// Gets the status of the Data Lake Store account while being
        /// provisioned. Possible values include: 'Failed', 'Creating',
        /// 'Running', 'Succeeded', 'Patching', 'Suspending', 'Resuming',
        /// 'Deleting', 'Deleted'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public DataLakeStoreAccountStatus? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the status of the Data Lake Store account after provisioning
        /// has completed. Possible values include: 'active', 'suspended'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public DataLakeStoreAccountState? State { get; private set; }

        /// <summary>
        /// Gets the account creation time.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the account last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedTime")]
        public DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets or sets the gateway host.
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the default owner group for all new folders and files
        /// created in the Data Lake Store account.
        /// </summary>
        [JsonProperty(PropertyName = "defaultGroup")]
        public string DefaultGroup { get; set; }

    }
}
