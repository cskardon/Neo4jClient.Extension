﻿using Neo4jClient.Cypher;
using Newtonsoft.Json.Serialization;

namespace Neo4jClient.Extension.Cypher
{
    public interface ICypherExtensionContext
    {
        IContractResolver JsonContractResolver { get; set; }
    }

    public class CypherExtensionContext : ICypherExtensionContext
    {
        public static CypherExtensionContext Create(ICypherFluentQuery query)
        {
            return new CypherExtensionContext()
            {
                //TODO: Once other pull request is in for camel casing, pass whatever is set
                //JsonContractResolver = query.Query.JsonContractResolver
            };
        }

        public CypherExtensionContext()
        {
            JsonContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        public IContractResolver JsonContractResolver { get; set; }
    }
}
