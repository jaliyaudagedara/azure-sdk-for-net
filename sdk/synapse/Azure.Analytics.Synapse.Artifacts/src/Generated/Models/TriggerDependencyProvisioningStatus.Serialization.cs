// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(TriggerDependencyProvisioningStatusConverter))]
    public partial class TriggerDependencyProvisioningStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("triggerName"u8);
            writer.WriteStringValue(TriggerName);
            writer.WritePropertyName("provisioningStatus"u8);
            writer.WriteStringValue(ProvisioningStatus);
            writer.WriteEndObject();
        }

        internal static TriggerDependencyProvisioningStatus DeserializeTriggerDependencyProvisioningStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string triggerName = default;
            string provisioningStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("triggerName"u8))
                {
                    triggerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    provisioningStatus = property.Value.GetString();
                    continue;
                }
            }
            return new TriggerDependencyProvisioningStatus(triggerName, provisioningStatus);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TriggerDependencyProvisioningStatus FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTriggerDependencyProvisioningStatus(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class TriggerDependencyProvisioningStatusConverter : JsonConverter<TriggerDependencyProvisioningStatus>
        {
            public override void Write(Utf8JsonWriter writer, TriggerDependencyProvisioningStatus model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override TriggerDependencyProvisioningStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTriggerDependencyProvisioningStatus(document.RootElement);
            }
        }
    }
}
