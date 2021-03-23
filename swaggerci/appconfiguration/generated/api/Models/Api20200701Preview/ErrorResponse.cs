namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>
    /// Error response indicates that the service is not able to process the incoming request. The reason is provided in the error
    /// message.
    /// </summary>
    public partial class ErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorResponse,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorResponseInternal
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorAdditionalInfo[] AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetailsInternal)Error).AdditionalInfo; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetailsInternal)Error).Code; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetails _error;

        /// <summary>The details of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetails Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ErrorDetails()); set => this._error = value; }

        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetailsInternal)Error).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorAdditionalInfo[] Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorResponseInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetailsInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetailsInternal)Error).AdditionalInfo = value; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorResponseInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetailsInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetailsInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetails Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorResponseInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ErrorDetails()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorResponseInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetailsInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetailsInternal)Error).Message = value; }

        /// <summary>Creates an new <see cref="ErrorResponse" /> instance.</summary>
        public ErrorResponse()
        {

        }
    }
    /// Error response indicates that the service is not able to process the incoming request. The reason is provided in the error
    /// message.
    public partial interface IErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorAdditionalInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorAdditionalInfo[] AdditionalInfo { get;  }
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error message indicating why the operation failed.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// Error response indicates that the service is not able to process the incoming request. The reason is provided in the error
    /// message.
    internal partial interface IErrorResponseInternal

    {
        /// <summary>The error additional info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorAdditionalInfo[] AdditionalInfo { get; set; }
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>The details of the error.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IErrorDetails Error { get; set; }
        /// <summary>Error message indicating why the operation failed.</summary>
        string Message { get; set; }

    }
}