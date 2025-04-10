// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Ldap authentication method properties. This feature is in preview.
/// </summary>
public partial class AuthenticationMethodLdapProperties : ProvisionableConstruct
{
    /// <summary>
    /// Hostname of the LDAP server.
    /// </summary>
    public BicepValue<string> ServerHostname 
    {
        get { Initialize(); return _serverHostname!; }
        set { Initialize(); _serverHostname!.Assign(value); }
    }
    private BicepValue<string>? _serverHostname;

    /// <summary>
    /// Port of the LDAP server.
    /// </summary>
    public BicepValue<int> ServerPort 
    {
        get { Initialize(); return _serverPort!; }
        set { Initialize(); _serverPort!.Assign(value); }
    }
    private BicepValue<int>? _serverPort;

    /// <summary>
    /// Distinguished name of the look up user account, who can look up user
    /// details on authentication.
    /// </summary>
    public BicepValue<string> ServiceUserDistinguishedName 
    {
        get { Initialize(); return _serviceUserDistinguishedName!; }
        set { Initialize(); _serviceUserDistinguishedName!.Assign(value); }
    }
    private BicepValue<string>? _serviceUserDistinguishedName;

    /// <summary>
    /// Password of the look up user.
    /// </summary>
    public BicepValue<string> ServiceUserPassword 
    {
        get { Initialize(); return _serviceUserPassword!; }
        set { Initialize(); _serviceUserPassword!.Assign(value); }
    }
    private BicepValue<string>? _serviceUserPassword;

    /// <summary>
    /// Distinguished name of the object to start the recursive search of users
    /// from.
    /// </summary>
    public BicepValue<string> SearchBaseDistinguishedName 
    {
        get { Initialize(); return _searchBaseDistinguishedName!; }
        set { Initialize(); _searchBaseDistinguishedName!.Assign(value); }
    }
    private BicepValue<string>? _searchBaseDistinguishedName;

    /// <summary>
    /// Template to use for searching. Defaults to (cn=%s) where %s will be
    /// replaced by the username used to login.
    /// </summary>
    public BicepValue<string> SearchFilterTemplate 
    {
        get { Initialize(); return _searchFilterTemplate!; }
        set { Initialize(); _searchFilterTemplate!.Assign(value); }
    }
    private BicepValue<string>? _searchFilterTemplate;

    /// <summary>
    /// Gets the server certificates.
    /// </summary>
    public BicepList<CassandraCertificate> ServerCertificates 
    {
        get { Initialize(); return _serverCertificates!; }
        set { Initialize(); _serverCertificates!.Assign(value); }
    }
    private BicepList<CassandraCertificate>? _serverCertificates;

    /// <summary>
    /// Timeout for connecting to the LDAP server in miliseconds. The default
    /// is 5000 ms.
    /// </summary>
    public BicepValue<int> ConnectionTimeoutInMs 
    {
        get { Initialize(); return _connectionTimeoutInMs!; }
        set { Initialize(); _connectionTimeoutInMs!.Assign(value); }
    }
    private BicepValue<int>? _connectionTimeoutInMs;

    /// <summary>
    /// Creates a new AuthenticationMethodLdapProperties.
    /// </summary>
    public AuthenticationMethodLdapProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// AuthenticationMethodLdapProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _serverHostname = DefineProperty<string>("ServerHostname", ["serverHostname"]);
        _serverPort = DefineProperty<int>("ServerPort", ["serverPort"]);
        _serviceUserDistinguishedName = DefineProperty<string>("ServiceUserDistinguishedName", ["serviceUserDistinguishedName"]);
        _serviceUserPassword = DefineProperty<string>("ServiceUserPassword", ["serviceUserPassword"]);
        _searchBaseDistinguishedName = DefineProperty<string>("SearchBaseDistinguishedName", ["searchBaseDistinguishedName"]);
        _searchFilterTemplate = DefineProperty<string>("SearchFilterTemplate", ["searchFilterTemplate"]);
        _serverCertificates = DefineListProperty<CassandraCertificate>("ServerCertificates", ["serverCertificates"]);
        _connectionTimeoutInMs = DefineProperty<int>("ConnectionTimeoutInMs", ["connectionTimeoutInMs"]);
    }
}
