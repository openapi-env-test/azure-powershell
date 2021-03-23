namespace Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.Extensions;

    /// <summary>The resource model definition representing SKU</summary>
    public partial class Sku :
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ISku,
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ISkuInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.SkuName _name;

        /// <summary>The name of the HealthBot SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.SkuName Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="Sku" /> instance.</summary>
        public Sku()
        {

        }
    }
    /// The resource model definition representing SKU
    public partial interface ISku :
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.IJsonSerializable
    {
        /// <summary>The name of the HealthBot SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the HealthBot SKU",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.SkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.SkuName Name { get; set; }

    }
    /// The resource model definition representing SKU
    internal partial interface ISkuInternal

    {
        /// <summary>The name of the HealthBot SKU</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.SkuName Name { get; set; }

    }
}