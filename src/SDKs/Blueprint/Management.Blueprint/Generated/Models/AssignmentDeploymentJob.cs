// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents individual job in given assignment operation.
    /// </summary>
    public partial class AssignmentDeploymentJob
    {
        /// <summary>
        /// Initializes a new instance of the AssignmentDeploymentJob class.
        /// </summary>
        public AssignmentDeploymentJob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssignmentDeploymentJob class.
        /// </summary>
        /// <param name="kind">Kind of the job.</param>
        /// <param name="action">Name of the action performed in this
        /// job.</param>
        /// <param name="jobId">Id of this job.</param>
        /// <param name="jobState">State of this job.</param>
        /// <param name="result">Deployment job result.</param>
        /// <param name="history">Result of this deployment job for each
        /// retry.</param>
        /// <param name="requestUri">Reference to deployment job resource
        /// id.</param>
        public AssignmentDeploymentJob(string kind = default(string), string action = default(string), string jobId = default(string), string jobState = default(string), AssignmentDeploymentJobResult result = default(AssignmentDeploymentJobResult), IList<AssignmentDeploymentJobResult> history = default(IList<AssignmentDeploymentJobResult>), string requestUri = default(string))
        {
            Kind = kind;
            Action = action;
            JobId = jobId;
            JobState = jobState;
            Result = result;
            History = history;
            RequestUri = requestUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets kind of the job.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets name of the action performed in this job.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets id of this job.
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or sets state of this job.
        /// </summary>
        [JsonProperty(PropertyName = "jobState")]
        public string JobState { get; set; }

        /// <summary>
        /// Gets or sets deployment job result.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public AssignmentDeploymentJobResult Result { get; set; }

        /// <summary>
        /// Gets or sets result of this deployment job for each retry.
        /// </summary>
        [JsonProperty(PropertyName = "history")]
        public IList<AssignmentDeploymentJobResult> History { get; set; }

        /// <summary>
        /// Gets or sets reference to deployment job resource id.
        /// </summary>
        [JsonProperty(PropertyName = "requestUri")]
        public string RequestUri { get; set; }

    }
}
