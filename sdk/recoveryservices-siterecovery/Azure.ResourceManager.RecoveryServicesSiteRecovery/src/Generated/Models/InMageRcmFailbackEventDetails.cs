// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Event details for InMageRcmFailback provider. </summary>
    public partial class InMageRcmFailbackEventDetails : SiteRecoveryEventProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackEventDetails"/>. </summary>
        internal InMageRcmFailbackEventDetails()
        {
            InstanceType = "InMageRcmFailback";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackEventDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="protectedItemName"> The protected item name. </param>
        /// <param name="vmName"> The protected item name. </param>
        /// <param name="applianceName"> The appliance name. </param>
        /// <param name="serverType"> The server type. </param>
        /// <param name="componentDisplayName"> The component display name. </param>
        internal InMageRcmFailbackEventDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string protectedItemName, string vmName, string applianceName, string serverType, string componentDisplayName) : base(instanceType, serializedAdditionalRawData)
        {
            ProtectedItemName = protectedItemName;
            VmName = vmName;
            ApplianceName = applianceName;
            ServerType = serverType;
            ComponentDisplayName = componentDisplayName;
            InstanceType = instanceType ?? "InMageRcmFailback";
        }

        /// <summary> The protected item name. </summary>
        public string ProtectedItemName { get; }
        /// <summary> The protected item name. </summary>
        public string VmName { get; }
        /// <summary> The appliance name. </summary>
        public string ApplianceName { get; }
        /// <summary> The server type. </summary>
        public string ServerType { get; }
        /// <summary> The component display name. </summary>
        public string ComponentDisplayName { get; }
    }
}
