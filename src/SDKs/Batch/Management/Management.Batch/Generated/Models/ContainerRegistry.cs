// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A private container registry.
    /// </summary>
    public partial class ContainerRegistry
    {
        /// <summary>
        /// Initializes a new instance of the ContainerRegistry class.
        /// </summary>
        public ContainerRegistry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerRegistry class.
        /// </summary>
        /// <param name="userName">The user name to log into the registry
        /// server.</param>
        /// <param name="password">The password to log into the registry
        /// server.</param>
        /// <param name="registryServer">The registry URL.</param>
        public ContainerRegistry(string userName, string password, string registryServer = default(string))
        {
            RegistryServer = registryServer;
            UserName = userName;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the registry URL.
        /// </summary>
        /// <remarks>
        /// If omitted, the default is "docker.io".
        /// </remarks>
        [JsonProperty(PropertyName = "registryServer")]
        public string RegistryServer { get; set; }

        /// <summary>
        /// Gets or sets the user name to log into the registry server.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password to log into the registry server.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UserName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserName");
            }
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}
