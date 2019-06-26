// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Backup OData filter class
    /// </summary>
    public partial class BackupFilter
    {
        /// <summary>
        /// Initializes a new instance of the BackupFilter class.
        /// </summary>
        public BackupFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupFilter class.
        /// </summary>
        /// <param name="initiatedBy">Gets or sets InitiatedBy. Possible values
        /// include: 'Manual', 'Scheduled'</param>
        /// <param name="createdTime">Gets or sets CreatedTime</param>
        public BackupFilter(InitiatedBy? initiatedBy = default(InitiatedBy?), System.DateTime? createdTime = default(System.DateTime?))
        {
            InitiatedBy = initiatedBy;
            CreatedTime = createdTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets InitiatedBy. Possible values include: 'Manual',
        /// 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "initiatedBy")]
        public InitiatedBy? InitiatedBy { get; set; }

        /// <summary>
        /// Gets or sets CreatedTime
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime { get; set; }

    }
}
