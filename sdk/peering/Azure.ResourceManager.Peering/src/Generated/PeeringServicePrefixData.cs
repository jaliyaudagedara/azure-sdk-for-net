// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A class representing the PeeringServicePrefix data model.
    /// The peering service prefix class.
    /// </summary>
    public partial class PeeringServicePrefixData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="PeeringServicePrefixData"/>. </summary>
        public PeeringServicePrefixData()
        {
            Events = new ChangeTrackingList<PeeringServicePrefixEvent>();
        }

        /// <summary> Initializes a new instance of <see cref="PeeringServicePrefixData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="prefix"> The prefix from which your traffic originates. </param>
        /// <param name="prefixValidationState"> The prefix validation state. </param>
        /// <param name="learnedType"> The prefix learned type. </param>
        /// <param name="errorMessage"> The error message for validation state. </param>
        /// <param name="events"> The list of events for peering service prefix. </param>
        /// <param name="peeringServicePrefixKey"> The peering service prefix key. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeeringServicePrefixData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string prefix, PeeringPrefixValidationState? prefixValidationState, PeeringLearnedType? learnedType, string errorMessage, IReadOnlyList<PeeringServicePrefixEvent> events, string peeringServicePrefixKey, PeeringProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Prefix = prefix;
            PrefixValidationState = prefixValidationState;
            LearnedType = learnedType;
            ErrorMessage = errorMessage;
            Events = events;
            PeeringServicePrefixKey = peeringServicePrefixKey;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The prefix from which your traffic originates. </summary>
        public string Prefix { get; set; }
        /// <summary> The prefix validation state. </summary>
        public PeeringPrefixValidationState? PrefixValidationState { get; }
        /// <summary> The prefix learned type. </summary>
        public PeeringLearnedType? LearnedType { get; }
        /// <summary> The error message for validation state. </summary>
        public string ErrorMessage { get; }
        /// <summary> The list of events for peering service prefix. </summary>
        public IReadOnlyList<PeeringServicePrefixEvent> Events { get; }
        /// <summary> The peering service prefix key. </summary>
        public string PeeringServicePrefixKey { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public PeeringProvisioningState? ProvisioningState { get; }
    }
}
