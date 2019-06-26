// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Query.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MetricsResultsItem
    {
        /// <summary>
        /// Initializes a new instance of the MetricsResultsItem class.
        /// </summary>
        public MetricsResultsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricsResultsItem class.
        /// </summary>
        /// <param name="id">The specified ID for this metric.</param>
        /// <param name="status">The HTTP status code of this metric
        /// query.</param>
        /// <param name="body">The results of this metric query.</param>
        public MetricsResultsItem(string id, int status, MetricsResult body)
        {
            Id = id;
            Status = status;
            Body = body;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the specified ID for this metric.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status code of this metric query.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the results of this metric query.
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public MetricsResult Body { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Body == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Body");
            }
        }
    }
}
