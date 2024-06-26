// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> Cert based security principal with Ledger RoleName. </summary>
    public partial class CertBasedSecurityPrincipal
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

        /// <summary> Initializes a new instance of <see cref="CertBasedSecurityPrincipal"/>. </summary>
        public CertBasedSecurityPrincipal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CertBasedSecurityPrincipal"/>. </summary>
        /// <param name="cert"> Public key of the user cert (.pem or .cer). </param>
        /// <param name="ledgerRoleName"> LedgerRole associated with the Security Principal of Ledger. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CertBasedSecurityPrincipal(string cert, ConfidentialLedgerRoleName? ledgerRoleName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Cert = cert;
            LedgerRoleName = ledgerRoleName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Public key of the user cert (.pem or .cer). </summary>
        public string Cert { get; set; }
        /// <summary> LedgerRole associated with the Security Principal of Ledger. </summary>
        public ConfidentialLedgerRoleName? LedgerRoleName { get; set; }
    }
}
