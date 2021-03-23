namespace Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Runtime.PowerShell;

    /// <summary>
    /// The route definition for a resource implemented by the custom resource provider.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(CustomRpResourceTypeRouteDefinitionTypeConverter))]
    public partial class CustomRpResourceTypeRouteDefinition
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.CustomRpResourceTypeRouteDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CustomRpResourceTypeRouteDefinition(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpResourceTypeRouteDefinitionInternal)this).RoutingType = (Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Support.ResourceTypeRouting?) content.GetValueForProperty("RoutingType",((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpResourceTypeRouteDefinitionInternal)this).RoutingType, Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Support.ResourceTypeRouting.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpRouteDefinitionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpRouteDefinitionInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpRouteDefinitionInternal)this).Endpoint = (string) content.GetValueForProperty("Endpoint",((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpRouteDefinitionInternal)this).Endpoint, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.CustomRpResourceTypeRouteDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CustomRpResourceTypeRouteDefinition(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpResourceTypeRouteDefinitionInternal)this).RoutingType = (Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Support.ResourceTypeRouting?) content.GetValueForProperty("RoutingType",((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpResourceTypeRouteDefinitionInternal)this).RoutingType, Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Support.ResourceTypeRouting.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpRouteDefinitionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpRouteDefinitionInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpRouteDefinitionInternal)this).Endpoint = (string) content.GetValueForProperty("Endpoint",((Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpRouteDefinitionInternal)this).Endpoint, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.CustomRpResourceTypeRouteDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpResourceTypeRouteDefinition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpResourceTypeRouteDefinition DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CustomRpResourceTypeRouteDefinition(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.CustomRpResourceTypeRouteDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpResourceTypeRouteDefinition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpResourceTypeRouteDefinition DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CustomRpResourceTypeRouteDefinition(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CustomRpResourceTypeRouteDefinition" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpResourceTypeRouteDefinition FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The route definition for a resource implemented by the custom resource provider.
    [System.ComponentModel.TypeConverter(typeof(CustomRpResourceTypeRouteDefinitionTypeConverter))]
    public partial interface ICustomRpResourceTypeRouteDefinition

    {

    }
}