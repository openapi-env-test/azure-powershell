namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001
{
    using Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.PowerShell;

    /// <summary>Resource for OuContainer.</summary>
    [System.ComponentModel.TypeConverter(typeof(OuContainerTypeConverter))]
    public partial class OuContainer
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.OuContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OuContainer(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.OuContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OuContainer(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OuContainer" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.OuContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OuContainer(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.OuContainerPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Etag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).TenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DeploymentId = (string) content.GetValueForProperty("DeploymentId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DeploymentId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ContainerId = (string) content.GetValueForProperty("ContainerId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ContainerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).Account = (Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount[]) content.GetValueForProperty("Account",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).Account, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount>(__y, Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.ContainerAccountTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ServiceStatus = (string) content.GetValueForProperty("ServiceStatus",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ServiceStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DistinguishedName = (string) content.GetValueForProperty("DistinguishedName",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DistinguishedName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ProvisioningState, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.OuContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OuContainer(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.OuContainerPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)this).Etag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).TenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DeploymentId = (string) content.GetValueForProperty("DeploymentId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DeploymentId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ContainerId = (string) content.GetValueForProperty("ContainerId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ContainerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).Account = (Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount[]) content.GetValueForProperty("Account",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).Account, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount>(__y, Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.ContainerAccountTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ServiceStatus = (string) content.GetValueForProperty("ServiceStatus",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ServiceStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DistinguishedName = (string) content.GetValueForProperty("DistinguishedName",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).DistinguishedName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal)this).ProvisioningState, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Resource for OuContainer.
    [System.ComponentModel.TypeConverter(typeof(OuContainerTypeConverter))]
    public partial interface IOuContainer

    {

    }
}