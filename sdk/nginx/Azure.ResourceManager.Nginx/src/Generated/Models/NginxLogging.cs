// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxLogging. </summary>
    internal partial class NginxLogging
    {
        /// <summary> Initializes a new instance of NginxLogging. </summary>
        public NginxLogging()
        {
        }

        /// <summary> Initializes a new instance of NginxLogging. </summary>
        /// <param name="storageAccount"></param>
        internal NginxLogging(NginxStorageAccount storageAccount)
        {
            StorageAccount = storageAccount;
        }

        /// <summary> Gets or sets the storage account. </summary>
        public NginxStorageAccount StorageAccount { get; set; }
    }
}
