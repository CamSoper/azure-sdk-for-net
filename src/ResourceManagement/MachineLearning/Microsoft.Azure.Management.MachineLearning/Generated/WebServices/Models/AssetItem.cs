// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Information about an asset associated with the web service.
    /// </summary>
    public partial class AssetItem
    {
        /// <summary>
        /// Initializes a new instance of the AssetItem class.
        /// </summary>
        public AssetItem() { }

        /// <summary>
        /// Initializes a new instance of the AssetItem class.
        /// </summary>
        public AssetItem(string name, string type, AssetLocation locationInfo, IDictionary<string, InputPort> inputPorts = default(IDictionary<string, InputPort>), IDictionary<string, OutputPort> outputPorts = default(IDictionary<string, OutputPort>), IDictionary<string, string> metadata = default(IDictionary<string, string>), IList<ModuleAssetParameter> parameters = default(IList<ModuleAssetParameter>))
        {
            Name = name;
            Type = type;
            LocationInfo = locationInfo;
            InputPorts = inputPorts;
            OutputPorts = outputPorts;
            Metadata = metadata;
            Parameters = parameters;
        }

        /// <summary>
        /// Asset's friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Asset's type. Possible values include: 'Module', 'Resource'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Access information for the asset.
        /// </summary>
        [JsonProperty(PropertyName = "locationInfo")]
        public AssetLocation LocationInfo { get; set; }

        /// <summary>
        /// Information about the asset's input ports.
        /// </summary>
        [JsonProperty(PropertyName = "inputPorts")]
        public IDictionary<string, InputPort> InputPorts { get; set; }

        /// <summary>
        /// Information about the asset's output ports.
        /// </summary>
        [JsonProperty(PropertyName = "outputPorts")]
        public IDictionary<string, OutputPort> OutputPorts { get; set; }

        /// <summary>
        /// If the asset is a custom module, this holds the module's metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If the asset is a custom module, this holds the module's
        /// parameters.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<ModuleAssetParameter> Parameters { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (LocationInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LocationInfo");
            }
            if (this.LocationInfo != null)
            {
                this.LocationInfo.Validate();
            }
        }
    }
}
