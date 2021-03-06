﻿using System;

namespace SimpleEventStore.AzureDocumentDb
{
    public class DefaultSerializationTypeMap : ISerializationTypeMap
    {
        public string GetNameFromType(Type type)
        {
            return type.AssemblyQualifiedName;
        }

        public Type GetTypeFromName(string typeName)
        {
            return Type.GetType(typeName);
        }
    }
}
