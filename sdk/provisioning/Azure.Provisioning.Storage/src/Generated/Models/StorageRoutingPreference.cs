// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// Routing preference defines the type of network, either microsoft or
/// internet routing to be used to deliver the user data, the default option
/// is microsoft routing.
/// </summary>
public partial class StorageRoutingPreference : ProvisionableConstruct
{
    /// <summary>
    /// Routing Choice defines the kind of network routing opted by the user.
    /// </summary>
    public BicepValue<StorageRoutingChoice> RoutingChoice 
    {
        get { Initialize(); return _routingChoice!; }
        set { Initialize(); _routingChoice!.Assign(value); }
    }
    private BicepValue<StorageRoutingChoice>? _routingChoice;

    /// <summary>
    /// A boolean flag which indicates whether microsoft routing storage
    /// endpoints are to be published.
    /// </summary>
    public BicepValue<bool> IsMicrosoftEndpointsPublished 
    {
        get { Initialize(); return _isMicrosoftEndpointsPublished!; }
        set { Initialize(); _isMicrosoftEndpointsPublished!.Assign(value); }
    }
    private BicepValue<bool>? _isMicrosoftEndpointsPublished;

    /// <summary>
    /// A boolean flag which indicates whether internet routing storage
    /// endpoints are to be published.
    /// </summary>
    public BicepValue<bool> IsInternetEndpointsPublished 
    {
        get { Initialize(); return _isInternetEndpointsPublished!; }
        set { Initialize(); _isInternetEndpointsPublished!.Assign(value); }
    }
    private BicepValue<bool>? _isInternetEndpointsPublished;

    /// <summary>
    /// Creates a new StorageRoutingPreference.
    /// </summary>
    public StorageRoutingPreference()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of StorageRoutingPreference.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _routingChoice = DefineProperty<StorageRoutingChoice>("RoutingChoice", ["routingChoice"]);
        _isMicrosoftEndpointsPublished = DefineProperty<bool>("IsMicrosoftEndpointsPublished", ["publishMicrosoftEndpoints"]);
        _isInternetEndpointsPublished = DefineProperty<bool>("IsInternetEndpointsPublished", ["publishInternetEndpoints"]);
    }
}
