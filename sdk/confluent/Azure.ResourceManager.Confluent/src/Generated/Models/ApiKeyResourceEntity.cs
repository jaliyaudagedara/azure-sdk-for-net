// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> API Key Resource details which can be kafka cluster or schema registry cluster. </summary>
    public partial class ApiKeyResourceEntity
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiKeyResourceEntity"/>. </summary>
        internal ApiKeyResourceEntity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiKeyResourceEntity"/>. </summary>
        /// <param name="id"> Id of the resource. </param>
        /// <param name="environment"> The environment of the api key. </param>
        /// <param name="related"> API URL for accessing or modifying the api key resource object. </param>
        /// <param name="resourceName"> CRN reference to the referred resource. </param>
        /// <param name="kind"> Type of the owner which can be service or user account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiKeyResourceEntity(string id, string environment, string related, string resourceName, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Environment = environment;
            Related = related;
            ResourceName = resourceName;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Id of the resource. </summary>
        public string Id { get; }
        /// <summary> The environment of the api key. </summary>
        public string Environment { get; }
        /// <summary> API URL for accessing or modifying the api key resource object. </summary>
        public string Related { get; }
        /// <summary> CRN reference to the referred resource. </summary>
        public string ResourceName { get; }
        /// <summary> Type of the owner which can be service or user account. </summary>
        public string Kind { get; }
    }
}
