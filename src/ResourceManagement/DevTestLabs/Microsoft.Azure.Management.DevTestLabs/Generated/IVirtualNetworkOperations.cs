// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// VirtualNetworkOperations operations.
    /// </summary>
    public partial interface IVirtualNetworkOperations
    {
        /// <summary>
        /// List virtual networks in a given lab.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<VirtualNetwork>>> ListWithHttpMessagesAsync(string resourceGroupName, string labName, ODataQuery<VirtualNetwork> odataQuery = default(ODataQuery<VirtualNetwork>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get virtual network.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualNetwork>> GetResourceWithHttpMessagesAsync(string resourceGroupName, string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or replace an existing virtual network. This operation can
        /// take a while to complete.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='virtualNetwork'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualNetwork>> CreateOrUpdateResourceWithHttpMessagesAsync(string resourceGroupName, string labName, string name, VirtualNetwork virtualNetwork, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or replace an existing virtual network. This operation can
        /// take a while to complete.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='virtualNetwork'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualNetwork>> BeginCreateOrUpdateResourceWithHttpMessagesAsync(string resourceGroupName, string labName, string name, VirtualNetwork virtualNetwork, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete virtual network. This operation can take a while to
        /// complete.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteResourceWithHttpMessagesAsync(string resourceGroupName, string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete virtual network. This operation can take a while to
        /// complete.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteResourceWithHttpMessagesAsync(string resourceGroupName, string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modify properties of virtual networks.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='virtualNetwork'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualNetwork>> PatchResourceWithHttpMessagesAsync(string resourceGroupName, string labName, string name, VirtualNetwork virtualNetwork, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List virtual networks in a given lab.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<VirtualNetwork>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
