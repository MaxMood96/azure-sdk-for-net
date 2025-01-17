// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    internal partial class CatalogsResult
    {
        internal static CatalogsResult DeserializeCatalogsResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ReservationCatalog>> value = default;
            Optional<string> nextLink = default;
            Optional<long> totalItems = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ReservationCatalog> array = new List<ReservationCatalog>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationCatalog.DeserializeReservationCatalog(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalItems"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalItems = property.Value.GetInt64();
                    continue;
                }
            }
            return new CatalogsResult(Optional.ToList(value), nextLink.Value, Optional.ToNullable(totalItems));
        }
    }
}
