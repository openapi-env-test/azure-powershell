namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Log file URL payload</summary>
    public partial class LogFileUrlResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ILogFileUrlResponse,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ILogFileUrlResponseInternal
    {

        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        /// <summary>URL of the log file</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Url { get => this._url; set => this._url = value; }

        /// <summary>Creates an new <see cref="LogFileUrlResponse" /> instance.</summary>
        public LogFileUrlResponse()
        {

        }
    }
    /// Log file URL payload
    public partial interface ILogFileUrlResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>URL of the log file</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"URL of the log file",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get; set; }

    }
    /// Log file URL payload
    internal partial interface ILogFileUrlResponseInternal

    {
        /// <summary>URL of the log file</summary>
        string Url { get; set; }

    }
}