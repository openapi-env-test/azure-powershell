namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.PowerShell;

    /// <summary>Service resource</summary>
    [System.ComponentModel.TypeConverter(typeof(ServiceResourceTypeConverter))]
    public partial class ServiceResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServiceResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServiceResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServiceResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServiceResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IClusterResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ClusterResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.NetworkProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuTier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Version = (int?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Version, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).ServiceId = (string) content.GetValueForProperty("ServiceId",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).ServiceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceCidr = (string) content.GetValueForProperty("NetworkProfileServiceCidr",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceCidr, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileRequiredTraffic = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IRequiredTraffic[]) content.GetValueForProperty("NetworkProfileRequiredTraffic",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileRequiredTraffic, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IRequiredTraffic>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.RequiredTrafficTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileOutboundIP = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.INetworkProfileOutboundIPs) content.GetValueForProperty("NetworkProfileOutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileOutboundIP, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.NetworkProfileOutboundIPsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceRuntimeSubnetId = (string) content.GetValueForProperty("NetworkProfileServiceRuntimeSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceRuntimeSubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileAppSubnetId = (string) content.GetValueForProperty("NetworkProfileAppSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileAppSubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceRuntimeNetworkResourceGroup = (string) content.GetValueForProperty("NetworkProfileServiceRuntimeNetworkResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceRuntimeNetworkResourceGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileAppNetworkResourceGroup = (string) content.GetValueForProperty("NetworkProfileAppNetworkResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileAppNetworkResourceGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).OutboundIPPublicIP = (string[]) content.GetValueForProperty("OutboundIPPublicIP",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).OutboundIPPublicIP, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServiceResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IClusterResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ClusterResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.NetworkProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuTier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Version = (int?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).Version, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).ServiceId = (string) content.GetValueForProperty("ServiceId",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).ServiceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceCidr = (string) content.GetValueForProperty("NetworkProfileServiceCidr",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceCidr, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileRequiredTraffic = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IRequiredTraffic[]) content.GetValueForProperty("NetworkProfileRequiredTraffic",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileRequiredTraffic, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IRequiredTraffic>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.RequiredTrafficTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileOutboundIP = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.INetworkProfileOutboundIPs) content.GetValueForProperty("NetworkProfileOutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileOutboundIP, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.NetworkProfileOutboundIPsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceRuntimeSubnetId = (string) content.GetValueForProperty("NetworkProfileServiceRuntimeSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceRuntimeSubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileAppSubnetId = (string) content.GetValueForProperty("NetworkProfileAppSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileAppSubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceRuntimeNetworkResourceGroup = (string) content.GetValueForProperty("NetworkProfileServiceRuntimeNetworkResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileServiceRuntimeNetworkResourceGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileAppNetworkResourceGroup = (string) content.GetValueForProperty("NetworkProfileAppNetworkResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).NetworkProfileAppNetworkResourceGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).OutboundIPPublicIP = (string[]) content.GetValueForProperty("OutboundIPPublicIP",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceResourceInternal)this).OutboundIPPublicIP, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Service resource
    [System.ComponentModel.TypeConverter(typeof(ServiceResourceTypeConverter))]
    public partial interface IServiceResource

    {

    }
}