namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>The result of a request to list key-values.</summary>
    public partial class KeyValueListResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyValueListResult,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyValueListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URI that can be used to request the next set of paged results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyValue[] _value;

        /// <summary>The collection value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyValue[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="KeyValueListResult" /> instance.</summary>
        public KeyValueListResult()
        {

        }
    }
    /// The result of a request to list key-values.
    public partial interface IKeyValueListResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>The URI that can be used to request the next set of paged results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI that can be used to request the next set of paged results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The collection value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection value.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyValue) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyValue[] Value { get; set; }

    }
    /// The result of a request to list key-values.
    internal partial interface IKeyValueListResultInternal

    {
        /// <summary>The URI that can be used to request the next set of paged results.</summary>
        string NextLink { get; set; }
        /// <summary>The collection value.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyValue[] Value { get; set; }

    }
}