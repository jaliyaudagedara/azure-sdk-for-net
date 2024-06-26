// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan A2A failover input. </summary>
    public partial class RecoveryPlanA2AFailoverContent : RecoveryPlanProviderSpecificFailoverContent
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanA2AFailoverContent"/>. </summary>
        /// <param name="recoveryPointType"> The recovery point type. </param>
        public RecoveryPlanA2AFailoverContent(A2ARpRecoveryPointType recoveryPointType)
        {
            RecoveryPointType = recoveryPointType;
            InstanceType = "A2A";
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanA2AFailoverContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryPointType"> The recovery point type. </param>
        /// <param name="cloudServiceCreationOption"> A value indicating whether to use recovery cloud service for TFO or not. </param>
        /// <param name="multiVmSyncPointOption"> A value indicating whether multi VM sync enabled VMs should use multi VM sync points for failover. </param>
        internal RecoveryPlanA2AFailoverContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, A2ARpRecoveryPointType recoveryPointType, string cloudServiceCreationOption, MultiVmSyncPointOption? multiVmSyncPointOption) : base(instanceType, serializedAdditionalRawData)
        {
            RecoveryPointType = recoveryPointType;
            CloudServiceCreationOption = cloudServiceCreationOption;
            MultiVmSyncPointOption = multiVmSyncPointOption;
            InstanceType = instanceType ?? "A2A";
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanA2AFailoverContent"/> for deserialization. </summary>
        internal RecoveryPlanA2AFailoverContent()
        {
        }

        /// <summary> The recovery point type. </summary>
        public A2ARpRecoveryPointType RecoveryPointType { get; }
        /// <summary> A value indicating whether to use recovery cloud service for TFO or not. </summary>
        public string CloudServiceCreationOption { get; set; }
        /// <summary> A value indicating whether multi VM sync enabled VMs should use multi VM sync points for failover. </summary>
        public MultiVmSyncPointOption? MultiVmSyncPointOption { get; set; }
    }
}
