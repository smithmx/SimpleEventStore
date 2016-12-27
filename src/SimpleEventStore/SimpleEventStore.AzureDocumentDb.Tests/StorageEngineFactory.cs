﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;

namespace SimpleEventStore.AzureDocumentDb.Tests
{
    internal static class StorageEngineFactory
    {
        internal static async Task<IStorageEngine> Create()
        {
            var documentDbUri = "https://mg-eventsourcing-simple.documents.azure.com:443/";
            var authKey = "9FbXSIuFp420lalYtSsUmA9TNscZqsvseuSESRDW5saqaQxUjiv5UNGgxz2ODxKvfKIv4dKrzCVfspg97JDBTQ==";
            var databaseName = "DocumentDbEventStoreTests";
            DocumentClient client = new DocumentClient(new Uri(documentDbUri), authKey);

            var storageEngine = new AzureDocumentDbStorageEngine(client, databaseName);
            await storageEngine.Initialise();

            return storageEngine;
        }
    }
}
