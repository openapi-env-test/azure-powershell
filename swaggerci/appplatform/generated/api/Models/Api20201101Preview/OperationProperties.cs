namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Extra Operation properties</summary>
    public partial class OperationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IOperationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IOperationPropertiesInternal
    {

        /// <summary>Internal Acessors for ServiceSpecification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceSpecification Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IOperationPropertiesInternal.ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ServiceSpecification()); set { {_serviceSpecification = value;} } }

        /// <summary>Backing field for <see cref="ServiceSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceSpecification _serviceSpecification;

        /// <summary>Service specifications of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceSpecification ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ServiceSpecification()); set => this._serviceSpecification = value; }

        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ILogSpecification[] ServiceSpecificationLogSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceSpecificationInternal)ServiceSpecification).LogSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceSpecificationInternal)ServiceSpecification).LogSpecification = value ?? null /* arrayOf */; }

        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMetricSpecification[] ServiceSpecificationMetricSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceSpecificationInternal)ServiceSpecification).MetricSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceSpecificationInternal)ServiceSpecification).MetricSpecification = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="OperationProperties" /> instance.</summary>
        public OperationProperties()
        {

        }
    }
    /// Extra Operation properties
    public partial interface IOperationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifications of the Log for Azure Monitoring",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ILogSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ILogSpecification[] ServiceSpecificationLogSpecification { get; set; }
        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifications of the Metrics for Azure Monitoring",
        SerializedName = @"metricSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMetricSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMetricSpecification[] ServiceSpecificationMetricSpecification { get; set; }

    }
    /// Extra Operation properties
    internal partial interface IOperationPropertiesInternal

    {
        /// <summary>Service specifications of the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceSpecification ServiceSpecification { get; set; }
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ILogSpecification[] ServiceSpecificationLogSpecification { get; set; }
        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMetricSpecification[] ServiceSpecificationMetricSpecification { get; set; }

    }
}