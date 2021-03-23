namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Properties of the operation</summary>
    public partial class OperationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IOperationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IOperationPropertiesInternal
    {

        /// <summary>Internal Acessors for ServiceSpecification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IServiceSpecification Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IOperationPropertiesInternal.ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.ServiceSpecification()); set { {_serviceSpecification = value;} } }

        /// <summary>Backing field for <see cref="ServiceSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IServiceSpecification _serviceSpecification;

        /// <summary>Service specification payload</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IServiceSpecification ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.ServiceSpecification()); set => this._serviceSpecification = value; }

        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.ILogSpecification[] ServiceSpecificationLogSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IServiceSpecificationInternal)ServiceSpecification).LogSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IServiceSpecificationInternal)ServiceSpecification).LogSpecification = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="OperationProperties" /> instance.</summary>
        public OperationProperties()
        {

        }
    }
    /// Properties of the operation
    public partial interface IOperationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifications of the Log for Azure Monitoring",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.ILogSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.ILogSpecification[] ServiceSpecificationLogSpecification { get; set; }

    }
    /// Properties of the operation
    internal partial interface IOperationPropertiesInternal

    {
        /// <summary>Service specification payload</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IServiceSpecification ServiceSpecification { get; set; }
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.ILogSpecification[] ServiceSpecificationLogSpecification { get; set; }

    }
}