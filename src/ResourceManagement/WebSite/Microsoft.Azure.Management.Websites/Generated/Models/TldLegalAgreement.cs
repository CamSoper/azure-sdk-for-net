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
    /// Represents a legal agreement for top level domain
    /// </summary>
    public partial class TldLegalAgreement
    {
        /// <summary>
        /// Initializes a new instance of the TldLegalAgreement class.
        /// </summary>
        public TldLegalAgreement() { }

        /// <summary>
        /// Initializes a new instance of the TldLegalAgreement class.
        /// </summary>
        public TldLegalAgreement(string agreementKey = default(string), string title = default(string), string content = default(string), string url = default(string))
        {
            AgreementKey = agreementKey;
            Title = title;
            Content = content;
            Url = url;
        }

        /// <summary>
        /// Unique identifier for the agreement
        /// </summary>
        [JsonProperty(PropertyName = "agreementKey")]
        public string AgreementKey { get; set; }

        /// <summary>
        /// Agreement title
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Agreement details
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// Url where a copy of the agreement details is hosted
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}
