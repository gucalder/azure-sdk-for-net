// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Shipment pick up request details.
    /// </summary>
    public partial class ShipmentPickUpRequest
    {
        /// <summary>
        /// Initializes a new instance of the ShipmentPickUpRequest class.
        /// </summary>
        public ShipmentPickUpRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ShipmentPickUpRequest class.
        /// </summary>
        /// <param name="startTime">Minimum date after which the pick up should
        /// commence, this must be in local time of pick up area.</param>
        /// <param name="endTime">Maximum date before which the pick up should
        /// commence, this must be in local time of pick up area.</param>
        /// <param name="shipmentLocation">Shipment Location in the pickup
        /// place. Eg.front desk</param>
        public ShipmentPickUpRequest(System.DateTime startTime, System.DateTime endTime, string shipmentLocation)
        {
            StartTime = startTime;
            EndTime = endTime;
            ShipmentLocation = shipmentLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets minimum date after which the pick up should commence,
        /// this must be in local time of pick up area.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets maximum date before which the pick up should commence,
        /// this must be in local time of pick up area.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets shipment Location in the pickup place. Eg.front desk
        /// </summary>
        [JsonProperty(PropertyName = "shipmentLocation")]
        public string ShipmentLocation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ShipmentLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ShipmentLocation");
            }
        }
    }
}
