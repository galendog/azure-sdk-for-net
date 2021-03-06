// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties related to auto storage account.
    /// </summary>
    public partial class AutoStorageBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the AutoStorageBaseProperties class.
        /// </summary>
        public AutoStorageBaseProperties() { }

        /// <summary>
        /// Initializes a new instance of the AutoStorageBaseProperties class.
        /// </summary>
        public AutoStorageBaseProperties(string storageAccountId)
        {
            StorageAccountId = storageAccountId;
        }

        /// <summary>
        /// Gets or sets the resource id of the storage account to be used for
        /// auto storage account.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (StorageAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountId");
            }
        }
    }
}
