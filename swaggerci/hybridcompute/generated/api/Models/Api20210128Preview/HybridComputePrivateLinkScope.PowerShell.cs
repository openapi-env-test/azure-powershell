namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.PowerShell;

    /// <summary>An Azure Arc PrivateLinkScope definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(HybridComputePrivateLinkScopeTypeConverter))]
    public partial class HybridComputePrivateLinkScope
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.HybridComputePrivateLinkScope"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScope"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScope DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HybridComputePrivateLinkScope(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.HybridComputePrivateLinkScope"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScope"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScope DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HybridComputePrivateLinkScope(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HybridComputePrivateLinkScope" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScope FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.HybridComputePrivateLinkScope"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HybridComputePrivateLinkScope(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.HybridComputePrivateLinkScopePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.PrivateLinkScopesResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).PrivateLinkScopeId = (string) content.GetValueForProperty("PrivateLinkScopeId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).PrivateLinkScopeId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.HybridComputePrivateLinkScope"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HybridComputePrivateLinkScope(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.HybridComputePrivateLinkScopePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopesResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.PrivateLinkScopesResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).PrivateLinkScopeId = (string) content.GetValueForProperty("PrivateLinkScopeId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).PrivateLinkScopeId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An Azure Arc PrivateLinkScope definition.
    [System.ComponentModel.TypeConverter(typeof(HybridComputePrivateLinkScopeTypeConverter))]
    public partial interface IHybridComputePrivateLinkScope

    {

    }
}