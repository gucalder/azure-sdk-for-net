// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data used for requesting a SAS.
    /// </summary>
    public partial class GrantAccessData
    {
        /// <summary>
        /// Initializes a new instance of the GrantAccessData class.
        /// </summary>
        public GrantAccessData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GrantAccessData class.
        /// </summary>
        /// <param name="access">Possible values include: 'None',
        /// 'Read'</param>
        /// <param name="durationInSeconds">Time duration in seconds until the
        /// SAS access expires.</param>
        public GrantAccessData(string access, int durationInSeconds)
        {
            Access = access;
            DurationInSeconds = durationInSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Read'
        /// </summary>
        [JsonProperty(PropertyName = "access")]
        public string Access { get; set; }

        /// <summary>
        /// Gets or sets time duration in seconds until the SAS access expires.
        /// </summary>
        [JsonProperty(PropertyName = "durationInSeconds")]
        public int DurationInSeconds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Access == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Access");
            }
        }
    }
}
