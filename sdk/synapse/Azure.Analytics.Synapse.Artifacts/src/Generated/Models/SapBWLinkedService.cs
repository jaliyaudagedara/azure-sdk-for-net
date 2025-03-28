// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SAP Business Warehouse Linked Service. </summary>
    public partial class SapBWLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="SapBWLinkedService"/>. </summary>
        /// <param name="server"> Host name of the SAP BW instance. Type: string (or Expression with resultType string). </param>
        /// <param name="systemNumber"> System number of the BW system. (Usually a two-digit decimal number represented as a string.) Type: string (or Expression with resultType string). </param>
        /// <param name="clientId"> Client ID of the client on the BW system. (Usually a three-digit decimal number represented as a string) Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/>, <paramref name="systemNumber"/> or <paramref name="clientId"/> is null. </exception>
        public SapBWLinkedService(object server, object systemNumber, object clientId)
        {
            Argument.AssertNotNull(server, nameof(server));
            Argument.AssertNotNull(systemNumber, nameof(systemNumber));
            Argument.AssertNotNull(clientId, nameof(clientId));

            Server = server;
            SystemNumber = systemNumber;
            ClientId = clientId;
            Type = "SapBW";
        }

        /// <summary> Initializes a new instance of <see cref="SapBWLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> Host name of the SAP BW instance. Type: string (or Expression with resultType string). </param>
        /// <param name="systemNumber"> System number of the BW system. (Usually a two-digit decimal number represented as a string.) Type: string (or Expression with resultType string). </param>
        /// <param name="clientId"> Client ID of the client on the BW system. (Usually a three-digit decimal number represented as a string) Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> Username to access the SAP BW server. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password to access the SAP BW server.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal SapBWLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object server, object systemNumber, object clientId, object userName, SecretBase password, object encryptedCredential) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            SystemNumber = systemNumber;
            ClientId = clientId;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "SapBW";
        }

        /// <summary> Host name of the SAP BW instance. Type: string (or Expression with resultType string). </summary>
        public object Server { get; set; }
        /// <summary> System number of the BW system. (Usually a two-digit decimal number represented as a string.) Type: string (or Expression with resultType string). </summary>
        public object SystemNumber { get; set; }
        /// <summary> Client ID of the client on the BW system. (Usually a three-digit decimal number represented as a string) Type: string (or Expression with resultType string). </summary>
        public object ClientId { get; set; }
        /// <summary> Username to access the SAP BW server. Type: string (or Expression with resultType string). </summary>
        public object UserName { get; set; }
        /// <summary>
        /// Password to access the SAP BW server.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
