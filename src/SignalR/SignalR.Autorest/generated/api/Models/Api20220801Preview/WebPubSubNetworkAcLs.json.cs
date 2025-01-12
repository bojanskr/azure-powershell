// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Extensions;

    /// <summary>Network ACLs for the resource</summary>
    public partial class WebPubSubNetworkAcLs
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubNetworkAcLs.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubNetworkAcLs.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubNetworkAcLs FromJson(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject json ? new WebPubSubNetworkAcLs(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="WebPubSubNetworkAcLs" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="WebPubSubNetworkAcLs" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._publicNetwork ? (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode) this._publicNetwork.ToJson(null,serializationMode) : null, "publicNetwork" ,container.Add );
            AddIf( null != (((object)this._defaultAction)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonString(this._defaultAction.ToString()) : null, "defaultAction" ,container.Add );
            if (null != this._privateEndpoint)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.XNodeArray();
                foreach( var __x in this._privateEndpoint )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("privateEndpoints",__w);
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject into a new instance of <see cref="WebPubSubNetworkAcLs" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal WebPubSubNetworkAcLs(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_publicNetwork = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonObject>("publicNetwork"), out var __jsonPublicNetwork) ? Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.NetworkAcl.FromJson(__jsonPublicNetwork) : PublicNetwork;}
            {_defaultAction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonString>("defaultAction"), out var __jsonDefaultAction) ? (string)__jsonDefaultAction : (string)DefaultAction;}
            {_privateEndpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonArray>("privateEndpoints"), out var __jsonPrivateEndpoints) ? If( __jsonPrivateEndpoints as Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IPrivateEndpointAcl[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IPrivateEndpointAcl) (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.PrivateEndpointAcl.FromJson(__u) )) ))() : null : PrivateEndpoint;}
            AfterFromJson(json);
        }
    }
}