// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> DataflowProfile Diagnostics properties. </summary>
    public partial class DataflowProfileDiagnostics
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

        /// <summary> Initializes a new instance of <see cref="DataflowProfileDiagnostics"/>. </summary>
        public DataflowProfileDiagnostics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataflowProfileDiagnostics"/>. </summary>
        /// <param name="logs"> Diagnostic log settings for the resource. </param>
        /// <param name="metrics"> The metrics settings for the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataflowProfileDiagnostics(DiagnosticsLogs logs, IotOperationsMetrics metrics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Logs = logs;
            Metrics = metrics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Diagnostic log settings for the resource. </summary>
        internal DiagnosticsLogs Logs { get; set; }
        /// <summary> The log level. Examples - 'debug', 'info', 'warn', 'error', 'trace'. </summary>
        public string LogsLevel
        {
            get => Logs is null ? default : Logs.Level;
            set
            {
                if (Logs is null)
                    Logs = new DiagnosticsLogs();
                Logs.Level = value;
            }
        }

        /// <summary> The metrics settings for the resource. </summary>
        internal IotOperationsMetrics Metrics { get; set; }
        /// <summary> The prometheus port to expose the metrics. </summary>
        public int? MetricsPrometheusPort
        {
            get => Metrics is null ? default : Metrics.PrometheusPort;
            set
            {
                if (Metrics is null)
                    Metrics = new IotOperationsMetrics();
                Metrics.PrometheusPort = value;
            }
        }
    }
}
