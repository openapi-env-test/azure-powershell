namespace Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.Extensions;

    /// <summary>The response returned from validation process</summary>
    public partial class ValidationResult :
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IValidationResult,
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IValidationResultInternal
    {

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status code of the response validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="ValidationResult" /> instance.</summary>
        public ValidationResult()
        {

        }
    }
    /// The response returned from validation process
    public partial interface IValidationResult :
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.IJsonSerializable
    {
        /// <summary>The status code of the response validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status code of the response validation.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// The response returned from validation process
    internal partial interface IValidationResultInternal

    {
        /// <summary>The status code of the response validation.</summary>
        string Status { get; set; }

    }
}