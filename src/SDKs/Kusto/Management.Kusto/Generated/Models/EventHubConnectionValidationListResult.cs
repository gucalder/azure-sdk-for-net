// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list Kusto event hub connection validation result.
    /// </summary>
    public partial class EventHubConnectionValidationListResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EventHubConnectionValidationListResult class.
        /// </summary>
        public EventHubConnectionValidationListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EventHubConnectionValidationListResult class.
        /// </summary>
        /// <param name="value">The list of Kusto event hub connection
        /// validation errors.</param>
        public EventHubConnectionValidationListResult(IList<EventHubConnectionValidationResult> value = default(IList<EventHubConnectionValidationResult>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of Kusto event hub connection validation
        /// errors.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<EventHubConnectionValidationResult> Value { get; set; }

    }
}
