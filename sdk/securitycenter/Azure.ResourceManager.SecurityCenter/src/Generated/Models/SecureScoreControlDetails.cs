// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Details of the security control, its score, and the health status of the relevant resources. </summary>
    public partial class SecureScoreControlDetails : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SecureScoreControlDetails"/>. </summary>
        public SecureScoreControlDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecureScoreControlDetails"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> User friendly display name of the control. </param>
        /// <param name="healthyResourceCount"> Number of healthy resources in the control. </param>
        /// <param name="unhealthyResourceCount"> Number of unhealthy resources in the control. </param>
        /// <param name="notApplicableResourceCount"> Number of not applicable resources in the control. </param>
        /// <param name="weight"> The relative weight for this specific control in each of your subscriptions. Used when calculating an aggregated score for this control across all of your subscriptions. </param>
        /// <param name="definition"> Information about the security control. </param>
        /// <param name="max"> Maximum score available. </param>
        /// <param name="current"> Current score. </param>
        /// <param name="percentage"> Ratio of the current score divided by the maximum. Rounded to 4 digits after the decimal point. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecureScoreControlDetails(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, int? healthyResourceCount, int? unhealthyResourceCount, int? notApplicableResourceCount, long? weight, SecureScoreControlDefinitionItem definition, int? max, double? current, double? percentage, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            HealthyResourceCount = healthyResourceCount;
            UnhealthyResourceCount = unhealthyResourceCount;
            NotApplicableResourceCount = notApplicableResourceCount;
            Weight = weight;
            Definition = definition;
            Max = max;
            Current = current;
            Percentage = percentage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> User friendly display name of the control. </summary>
        public string DisplayName { get; }
        /// <summary> Number of healthy resources in the control. </summary>
        public int? HealthyResourceCount { get; }
        /// <summary> Number of unhealthy resources in the control. </summary>
        public int? UnhealthyResourceCount { get; }
        /// <summary> Number of not applicable resources in the control. </summary>
        public int? NotApplicableResourceCount { get; }
        /// <summary> The relative weight for this specific control in each of your subscriptions. Used when calculating an aggregated score for this control across all of your subscriptions. </summary>
        public long? Weight { get; }
        /// <summary> Information about the security control. </summary>
        public SecureScoreControlDefinitionItem Definition { get; set; }
        /// <summary> Maximum score available. </summary>
        public int? Max { get; }
        /// <summary> Current score. </summary>
        public double? Current { get; }
        /// <summary> Ratio of the current score divided by the maximum. Rounded to 4 digits after the decimal point. </summary>
        public double? Percentage { get; }
    }
}
