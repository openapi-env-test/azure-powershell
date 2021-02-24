namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401
{
    using Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.PowerShell;

    /// <summary>The workspace properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(WorkspacePropertiesTypeConverter))]
    public partial class WorkspaceProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.WorkspaceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WorkspaceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.WorkspaceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WorkspaceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WorkspaceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.WorkspaceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WorkspaceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedBy = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ICreatedBy) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedBy, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.CreatedByTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedBy = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ICreatedBy) content.GetValueForProperty("UpdatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedBy, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.CreatedByTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IManagedIdentityConfiguration) content.GetValueForProperty("StorageAccountIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentity, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ManagedIdentityConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).ManagedResourceGroupId = (string) content.GetValueForProperty("ManagedResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).ManagedResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UiDefinitionUri = (string) content.GetValueForProperty("UiDefinitionUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UiDefinitionUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).Authorization = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProviderAuthorization[]) content.GetValueForProperty("Authorization",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).Authorization, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProviderAuthorization>(__y, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.WorkspaceProviderAuthorizationTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedDateTime = (global::System.DateTime?) content.GetValueForProperty("CreatedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).WorkspaceId = (string) content.GetValueForProperty("WorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).WorkspaceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).WorkspaceUrl = (string) content.GetValueForProperty("WorkspaceUrl",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).WorkspaceUrl, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceCustomParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.WorkspaceCustomParametersTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByOid = (string) content.GetValueForProperty("CreatedByOid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByOid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByPuid = (string) content.GetValueForProperty("CreatedByPuid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByPuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByApplicationId = (string) content.GetValueForProperty("CreatedByApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByApplicationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByOid = (string) content.GetValueForProperty("UpdatedByOid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByOid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByPuid = (string) content.GetValueForProperty("UpdatedByPuid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByPuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByApplicationId = (string) content.GetValueForProperty("UpdatedByApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByApplicationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityPrincipalId = (string) content.GetValueForProperty("StorageAccountIdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityTenantId = (string) content.GetValueForProperty("StorageAccountIdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityType = (string) content.GetValueForProperty("StorageAccountIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityType, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.WorkspaceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WorkspaceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedBy = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ICreatedBy) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedBy, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.CreatedByTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedBy = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ICreatedBy) content.GetValueForProperty("UpdatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedBy, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.CreatedByTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IManagedIdentityConfiguration) content.GetValueForProperty("StorageAccountIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentity, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ManagedIdentityConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).ManagedResourceGroupId = (string) content.GetValueForProperty("ManagedResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).ManagedResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UiDefinitionUri = (string) content.GetValueForProperty("UiDefinitionUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UiDefinitionUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).Authorization = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProviderAuthorization[]) content.GetValueForProperty("Authorization",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).Authorization, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProviderAuthorization>(__y, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.WorkspaceProviderAuthorizationTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedDateTime = (global::System.DateTime?) content.GetValueForProperty("CreatedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).WorkspaceId = (string) content.GetValueForProperty("WorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).WorkspaceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).WorkspaceUrl = (string) content.GetValueForProperty("WorkspaceUrl",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).WorkspaceUrl, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceCustomParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.WorkspaceCustomParametersTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByOid = (string) content.GetValueForProperty("CreatedByOid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByOid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByPuid = (string) content.GetValueForProperty("CreatedByPuid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByPuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByApplicationId = (string) content.GetValueForProperty("CreatedByApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).CreatedByApplicationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByOid = (string) content.GetValueForProperty("UpdatedByOid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByOid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByPuid = (string) content.GetValueForProperty("UpdatedByPuid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByPuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByApplicationId = (string) content.GetValueForProperty("UpdatedByApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).UpdatedByApplicationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityPrincipalId = (string) content.GetValueForProperty("StorageAccountIdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityTenantId = (string) content.GetValueForProperty("StorageAccountIdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityType = (string) content.GetValueForProperty("StorageAccountIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)this).StorageAccountIdentityType, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// The workspace properties.
    [System.ComponentModel.TypeConverter(typeof(WorkspacePropertiesTypeConverter))]
    public partial interface IWorkspaceProperties

    {

    }
}