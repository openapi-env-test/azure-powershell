// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Extensions;

    public partial class BlockchainIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentityInternal
    {

        /// <summary>Backing field for <see cref="BlockchainMemberName" /> property.</summary>
        private string _blockchainMemberName;

        /// <summary>Blockchain member name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Origin(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.PropertyOrigin.Owned)]
        public string BlockchainMemberName { get => this._blockchainMemberName; set => this._blockchainMemberName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Origin(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LocationName" /> property.</summary>
        private string _locationName;

        /// <summary>Location name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Origin(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.PropertyOrigin.Owned)]
        public string LocationName { get => this._locationName; set => this._locationName = value; }

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private string _operationId;

        /// <summary>Operation Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Origin(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.PropertyOrigin.Owned)]
        public string OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API
        /// or the portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Origin(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>
        /// Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the
        /// URI for every service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Origin(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="TransactionNodeName" /> property.</summary>
        private string _transactionNodeName;

        /// <summary>Transaction node name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Origin(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.PropertyOrigin.Owned)]
        public string TransactionNodeName { get => this._transactionNodeName; set => this._transactionNodeName = value; }

        /// <summary>Creates an new <see cref="BlockchainIdentity" /> instance.</summary>
        public BlockchainIdentity()
        {

        }
    }
    public partial interface IBlockchainIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.IJsonSerializable
    {
        /// <summary>Blockchain member name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Blockchain member name.",
        SerializedName = @"blockchainMemberName",
        PossibleTypes = new [] { typeof(string) })]
        string BlockchainMemberName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Location name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location name.",
        SerializedName = @"locationName",
        PossibleTypes = new [] { typeof(string) })]
        string LocationName { get; set; }
        /// <summary>Operation Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation Id.",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationId { get; set; }
        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API
        /// or the portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>
        /// Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the
        /// URI for every service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the URI for every service call.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>Transaction node name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Transaction node name.",
        SerializedName = @"transactionNodeName",
        PossibleTypes = new [] { typeof(string) })]
        string TransactionNodeName { get; set; }

    }
    internal partial interface IBlockchainIdentityInternal

    {
        /// <summary>Blockchain member name.</summary>
        string BlockchainMemberName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>Location name.</summary>
        string LocationName { get; set; }
        /// <summary>Operation Id.</summary>
        string OperationId { get; set; }
        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API
        /// or the portal.
        /// </summary>
        string ResourceGroupName { get; set; }
        /// <summary>
        /// Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the
        /// URI for every service call.
        /// </summary>
        string SubscriptionId { get; set; }
        /// <summary>Transaction node name.</summary>
        string TransactionNodeName { get; set; }

    }
}