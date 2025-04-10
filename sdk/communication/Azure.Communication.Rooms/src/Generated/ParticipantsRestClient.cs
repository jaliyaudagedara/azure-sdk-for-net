// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Rooms
{
    internal partial class ParticipantsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ParticipantsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public ParticipantsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2025-03-13")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateListRequest(string roomId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendPath("/participants", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get participants in a room. </summary>
        /// <param name="roomId"> The id of the room to get participants from. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public async Task<Response<ParticipantsCollection>> ListAsync(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateListRequest(roomId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ParticipantsCollection.DeserializeParticipantsCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get participants in a room. </summary>
        /// <param name="roomId"> The id of the room to get participants from. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public Response<ParticipantsCollection> List(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateListRequest(roomId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ParticipantsCollection.DeserializeParticipantsCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string roomId, IDictionary<string, ParticipantProperties> participants)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendPath("/participants", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            UpdateParticipantsRequest updateParticipantsRequest = new UpdateParticipantsRequest();
            if (participants != null)
            {
                foreach (var value in participants)
                {
                    updateParticipantsRequest.Participants.Add(value);
                }
            }
            var model = updateParticipantsRequest;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Update participants in a room. </summary>
        /// <param name="roomId"> The id of the room to update the participants in. </param>
        /// <param name="participants"> Participants to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public async Task<Response<object>> UpdateAsync(string roomId, IDictionary<string, ParticipantProperties> participants = null, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateUpdateRequest(roomId, participants);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        object value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetObject();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update participants in a room. </summary>
        /// <param name="roomId"> The id of the room to update the participants in. </param>
        /// <param name="participants"> Participants to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public Response<object> Update(string roomId, IDictionary<string, ParticipantProperties> participants = null, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateUpdateRequest(roomId, participants);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        object value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = document.RootElement.GetObject();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string roomId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get participants in a room. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="roomId"> The id of the room to get participants from. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="roomId"/> is null. </exception>
        public async Task<Response<ParticipantsCollection>> ListNextPageAsync(string nextLink, string roomId, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateListNextPageRequest(nextLink, roomId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ParticipantsCollection.DeserializeParticipantsCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get participants in a room. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="roomId"> The id of the room to get participants from. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="roomId"/> is null. </exception>
        public Response<ParticipantsCollection> ListNextPage(string nextLink, string roomId, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateListNextPageRequest(nextLink, roomId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ParticipantsCollection.DeserializeParticipantsCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
