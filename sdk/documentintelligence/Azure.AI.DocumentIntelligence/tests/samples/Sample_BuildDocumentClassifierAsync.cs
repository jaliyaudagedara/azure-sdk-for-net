﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;

namespace Azure.AI.DocumentIntelligence.Samples
{
    public partial class DocumentIntelligenceSamples
    {
        [RecordedTest]
        public async Task BuildDocumentClassifierAsync()
        {
            string endpoint = TestEnvironment.Endpoint;
            var client = new DocumentIntelligenceAdministrationClient(new Uri(endpoint), TestEnvironment.Credential);

            #region Snippet:DocumentIntelligenceSampleBuildClassifier
            // For this sample, you can use the training documents found in the `classifierTrainingFiles` folder.
            // Upload the documents to your storage container and then generate a container SAS URL. Note
            // that a container URI without SAS is accepted only when the container is public or has a
            // managed identity configured.

            // For instructions to set up documents for training in an Azure Blob Storage Container, please see:
            // https://aka.ms/azsdk/formrecognizer/buildclassifiermodel

#if SNIPPET
            string classifierId = "<classifierId>";
            Uri blobContainerUri = new Uri("<blobContainerUri>");
#else
            string classifierId = Guid.NewGuid().ToString();
            Uri blobContainerUri = new Uri(TestEnvironment.ClassifierTrainingSasUrl);
#endif
            var sourceA = new BlobContentSource(blobContainerUri) { Prefix = "IRS-1040-A/train" };
            var sourceB = new BlobContentSource(blobContainerUri) { Prefix = "IRS-1040-B/train" };
            var docTypeA = new ClassifierDocumentTypeDetails(sourceA);
            var docTypeB = new ClassifierDocumentTypeDetails(sourceB);
            var docTypes = new Dictionary<string, ClassifierDocumentTypeDetails>()
            {
                { "IRS-1040-A", docTypeA },
                { "IRS-1040-B", docTypeB }
            };

            var options = new BuildClassifierOptions(classifierId, docTypes);

            Operation<DocumentClassifierDetails> operation = await client.BuildClassifierAsync(WaitUntil.Completed, options);
            DocumentClassifierDetails classifier = operation.Value;

            Console.WriteLine($"Classifier ID: {classifier.ClassifierId}");
            Console.WriteLine($"Created on: {classifier.CreatedOn}");

            Console.WriteLine("Document types the classifier can recognize:");
            foreach (KeyValuePair<string, ClassifierDocumentTypeDetails> docType in classifier.DocumentTypes)
            {
                Console.WriteLine($"  {docType.Key}");
            }
            #endregion

            // Delete the classifier on completion to clean environment.
            await client.DeleteClassifierAsync(classifierId);
        }
    }
}
