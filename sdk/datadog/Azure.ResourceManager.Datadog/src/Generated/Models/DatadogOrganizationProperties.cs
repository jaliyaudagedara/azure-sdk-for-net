// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> Datadog organization properties. </summary>
    public partial class DatadogOrganizationProperties
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

        /// <summary> Initializes a new instance of <see cref="DatadogOrganizationProperties"/>. </summary>
        public DatadogOrganizationProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatadogOrganizationProperties"/>. </summary>
        /// <param name="name"> Name of the Datadog organization. </param>
        /// <param name="id"> Id of the Datadog organization. </param>
        /// <param name="linkingAuthCode"> The auth code used to linking to an existing datadog organization. </param>
        /// <param name="linkingClientId"> The client_id from an existing in exchange for an auth token to link organization. </param>
        /// <param name="redirectUri"> The redirect uri for linking. </param>
        /// <param name="apiKey"> Api key associated to the Datadog organization. </param>
        /// <param name="applicationKey"> Application key associated to the Datadog organization. </param>
        /// <param name="enterpriseAppId"> The Id of the Enterprise App used for Single sign on. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DatadogOrganizationProperties(string name, string id, string linkingAuthCode, string linkingClientId, Uri redirectUri, string apiKey, string applicationKey, string enterpriseAppId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Id = id;
            LinkingAuthCode = linkingAuthCode;
            LinkingClientId = linkingClientId;
            RedirectUri = redirectUri;
            ApiKey = apiKey;
            ApplicationKey = applicationKey;
            EnterpriseAppId = enterpriseAppId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the Datadog organization. </summary>
        public string Name { get; }
        /// <summary> Id of the Datadog organization. </summary>
        public string Id { get; }
        /// <summary> The auth code used to linking to an existing datadog organization. </summary>
        public string LinkingAuthCode { get; set; }
        /// <summary> The client_id from an existing in exchange for an auth token to link organization. </summary>
        public string LinkingClientId { get; set; }
        /// <summary> The redirect uri for linking. </summary>
        public Uri RedirectUri { get; set; }
        /// <summary> Api key associated to the Datadog organization. </summary>
        public string ApiKey { get; set; }
        /// <summary> Application key associated to the Datadog organization. </summary>
        public string ApplicationKey { get; set; }
        /// <summary> The Id of the Enterprise App used for Single sign on. </summary>
        public string EnterpriseAppId { get; set; }
    }
}
