namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Monitoring Setting resource</summary>
    public partial class MonitoringSettingResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingResource,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.Resource();

        /// <summary>Indicates the version of application insight java agent</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string AppInsightAgentVersionJava { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).AppInsightAgentVersionJava; }

        /// <summary>
        /// Target application insight instrumentation key, null or whitespace include empty will disable monitoringSettings
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string AppInsightsInstrumentationKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).AppInsightsInstrumentationKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).AppInsightsInstrumentationKey = value ?? null; }

        /// <summary>
        /// Indicates the sampling rate of application insight agent, should be in range [0.0, 100.0]
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public double? AppInsightsSamplingRate { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).AppInsightsSamplingRate; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).AppInsightsSamplingRate = value ?? default(double); }

        /// <summary>The code of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).Code = value ?? null; }

        /// <summary>Fully qualified resource Id for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Id; }

        /// <summary>The message of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).Message = value ?? null; }

        /// <summary>Internal Acessors for AppInsightAgentVersionJava</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingResourceInternal.AppInsightAgentVersionJava { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).AppInsightAgentVersionJava; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).AppInsightAgentVersionJava = value; }

        /// <summary>Internal Acessors for AppInsightsAgentVersion</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IApplicationInsightsAgentVersions Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingResourceInternal.AppInsightsAgentVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).AppInsightsAgentVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).AppInsightsAgentVersion = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IError Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingResourceInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).Error = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingProperties Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.MonitoringSettingProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingProperties _property;

        /// <summary>Properties of the Monitoring Setting resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.MonitoringSettingProperties()); set => this._property = value; }

        /// <summary>State of the Monitoring Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// Indicates whether enable the trace functionality, which will be deprecated since api version 2020-11-01-preview. Please
        /// leverage appInsightsInstrumentationKey to indicate if monitoringSettings enabled or not
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public bool? TraceEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).TraceEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal)Property).TraceEnabled = value ?? default(bool); }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="MonitoringSettingResource" /> instance.</summary>
        public MonitoringSettingResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Monitoring Setting resource
    public partial interface IMonitoringSettingResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResource
    {
        /// <summary>Indicates the version of application insight java agent</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicates the version of application insight java agent",
        SerializedName = @"java",
        PossibleTypes = new [] { typeof(string) })]
        string AppInsightAgentVersionJava { get;  }
        /// <summary>
        /// Target application insight instrumentation key, null or whitespace include empty will disable monitoringSettings
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target application insight instrumentation key, null or whitespace include empty will disable monitoringSettings",
        SerializedName = @"appInsightsInstrumentationKey",
        PossibleTypes = new [] { typeof(string) })]
        string AppInsightsInstrumentationKey { get; set; }
        /// <summary>
        /// Indicates the sampling rate of application insight agent, should be in range [0.0, 100.0]
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the sampling rate of application insight agent, should be in range [0.0, 100.0]",
        SerializedName = @"appInsightsSamplingRate",
        PossibleTypes = new [] { typeof(double) })]
        double? AppInsightsSamplingRate { get; set; }
        /// <summary>The code of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The code of error.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>The message of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The message of error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>State of the Monitoring Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"State of the Monitoring Setting.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState? ProvisioningState { get;  }
        /// <summary>
        /// Indicates whether enable the trace functionality, which will be deprecated since api version 2020-11-01-preview. Please
        /// leverage appInsightsInstrumentationKey to indicate if monitoringSettings enabled or not
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether enable the trace functionality, which will be deprecated since api version 2020-11-01-preview. Please leverage appInsightsInstrumentationKey to indicate if monitoringSettings enabled or not",
        SerializedName = @"traceEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TraceEnabled { get; set; }

    }
    /// Monitoring Setting resource
    internal partial interface IMonitoringSettingResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal
    {
        /// <summary>Indicates the version of application insight java agent</summary>
        string AppInsightAgentVersionJava { get; set; }
        /// <summary>Indicates the versions of application insight agent</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IApplicationInsightsAgentVersions AppInsightsAgentVersion { get; set; }
        /// <summary>
        /// Target application insight instrumentation key, null or whitespace include empty will disable monitoringSettings
        /// </summary>
        string AppInsightsInstrumentationKey { get; set; }
        /// <summary>
        /// Indicates the sampling rate of application insight agent, should be in range [0.0, 100.0]
        /// </summary>
        double? AppInsightsSamplingRate { get; set; }
        /// <summary>The code of error.</summary>
        string Code { get; set; }
        /// <summary>Error when apply Monitoring Setting changes.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IError Error { get; set; }
        /// <summary>The message of error.</summary>
        string Message { get; set; }
        /// <summary>Properties of the Monitoring Setting resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingProperties Property { get; set; }
        /// <summary>State of the Monitoring Setting.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState? ProvisioningState { get; set; }
        /// <summary>
        /// Indicates whether enable the trace functionality, which will be deprecated since api version 2020-11-01-preview. Please
        /// leverage appInsightsInstrumentationKey to indicate if monitoringSettings enabled or not
        /// </summary>
        bool? TraceEnabled { get; set; }

    }
}