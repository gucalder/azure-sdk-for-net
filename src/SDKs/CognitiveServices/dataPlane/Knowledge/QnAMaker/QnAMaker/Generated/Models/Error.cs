// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The error object. As per Microsoft One API guidelines -
    /// https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.
    /// </summary>
    public partial class Error
    {
        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        public Error()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        /// <param name="code">One of a server-defined set of error codes.
        /// Possible values include: 'BadArgument', 'Forbidden', 'NotFound',
        /// 'KbNotFound', 'Unauthorized', 'Unspecified', 'EndpointKeysError',
        /// 'QuotaExceeded', 'QnaRuntimeError', 'SKULimitExceeded',
        /// 'OperationNotFound', 'ServiceError', 'ValidationFailure',
        /// 'ExtractionFailure'</param>
        /// <param name="message">A human-readable representation of the
        /// error.</param>
        /// <param name="target">The target of the error.</param>
        /// <param name="details">An array of details about specific errors
        /// that led to this reported error.</param>
        /// <param name="innerError">An object containing more specific
        /// information than the current object about the error.</param>
        public Error(string code, string message = default(string), string target = default(string), IList<Error> details = default(IList<Error>), InnerErrorModel innerError = default(InnerErrorModel))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            InnerError = innerError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets one of a server-defined set of error codes. Possible
        /// values include: 'BadArgument', 'Forbidden', 'NotFound',
        /// 'KbNotFound', 'Unauthorized', 'Unspecified', 'EndpointKeysError',
        /// 'QuotaExceeded', 'QnaRuntimeError', 'SKULimitExceeded',
        /// 'OperationNotFound', 'ServiceError', 'ValidationFailure',
        /// 'ExtractionFailure'
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a human-readable representation of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the target of the error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets an array of details about specific errors that led to
        /// this reported error.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<Error> Details { get; set; }

        /// <summary>
        /// Gets or sets an object containing more specific information than
        /// the current object about the error.
        /// </summary>
        [JsonProperty(PropertyName = "innerError")]
        public InnerErrorModel InnerError { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Details != null)
            {
                foreach (var element in Details)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
