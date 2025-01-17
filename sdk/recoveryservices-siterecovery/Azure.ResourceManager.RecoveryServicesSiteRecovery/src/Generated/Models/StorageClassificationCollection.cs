// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Collection of storage details. </summary>
    internal partial class StorageClassificationCollection
    {
        /// <summary> Initializes a new instance of StorageClassificationCollection. </summary>
        internal StorageClassificationCollection()
        {
            Value = new ChangeTrackingList<StorageClassificationData>();
        }

        /// <summary> Initializes a new instance of StorageClassificationCollection. </summary>
        /// <param name="value"> The storage details. </param>
        /// <param name="nextLink"> The value of next link. </param>
        internal StorageClassificationCollection(IReadOnlyList<StorageClassificationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The storage details. </summary>
        public IReadOnlyList<StorageClassificationData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
