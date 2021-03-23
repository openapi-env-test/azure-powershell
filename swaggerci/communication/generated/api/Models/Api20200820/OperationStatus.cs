namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Extensions;

    /// <summary>The current status of an async operation</summary>
    public partial class OperationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatus,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorDetail[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>The end time of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponse _error;

        /// <summary>Operation Error message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponse Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ErrorResponse()); set => this._error = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Fully qualified ID for the operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorAdditionalInfo[] Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).AdditionalInfo = value; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorDetail[] Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Detail = value; }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.EndTime { get => this._endTime; set { {_endTime = value;} } }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponse Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ErrorResponse()); set { {_error = value;} } }

        /// <summary>Internal Acessors for ErrorDetailError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.ErrorDetailError { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Error = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Message = value; }

        /// <summary>Internal Acessors for PercentComplete</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.PercentComplete { get => this._percentComplete; set { {_percentComplete = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.Status? Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IOperationStatusInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Target = value; }

        /// <summary>Backing field for <see cref="PercentComplete" /> property.</summary>
        private float? _percentComplete;

        /// <summary>Percent of the operation that is complete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public float? PercentComplete { get => this._percentComplete; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>The start time of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.Status? _status;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.Status? Status { get => this._status; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponseInternal)Error).Target; }

        /// <summary>Creates an new <see cref="OperationStatus" /> instance.</summary>
        public OperationStatus()
        {

        }
    }
    /// The current status of an async operation
    public partial interface IOperationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorAdditionalInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorDetail[] Detail { get;  }
        /// <summary>The end time of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The end time of the operation",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get;  }
        /// <summary>Fully qualified ID for the operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully qualified ID for the operation status.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>Percent of the operation that is complete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Percent of the operation that is complete",
        SerializedName = @"percentComplete",
        PossibleTypes = new [] { typeof(float) })]
        float? PercentComplete { get;  }
        /// <summary>The start time of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The start time of the operation",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get;  }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.Status) })]
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.Status? Status { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// The current status of an async operation
    internal partial interface IOperationStatusInternal

    {
        /// <summary>The error additional info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorDetail[] Detail { get; set; }
        /// <summary>The end time of the operation</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>Operation Error message</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorResponse Error { get; set; }
        /// <summary>The error object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IErrorDetail ErrorDetailError { get; set; }
        /// <summary>Fully qualified ID for the operation status.</summary>
        string Id { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>Percent of the operation that is complete</summary>
        float? PercentComplete { get; set; }
        /// <summary>The start time of the operation</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.Status? Status { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }

    }
}