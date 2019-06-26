// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource Move Info.
    /// </summary>
    public partial class ResourcesMoveInfo
    {
        /// <summary>
        /// Initializes a new instance of the ResourcesMoveInfo class.
        /// </summary>
        public ResourcesMoveInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourcesMoveInfo class.
        /// </summary>
        /// <param name="targetResourceGroup">Target resource group.</param>
        /// <param name="resources">Collection of Resources.</param>
        public ResourcesMoveInfo(string targetResourceGroup = default(string), IList<string> resources = default(IList<string>))
        {
            TargetResourceGroup = targetResourceGroup;
            Resources = resources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets target resource group.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroup")]
        public string TargetResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets collection of Resources.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<string> Resources { get; set; }

    }
}
