// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Extensions;

    /// <summary>Describes a DNS resolver policy for PATCH operation.</summary>
    public partial class DnsResolverPolicyPatch :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsResolverPolicyPatch,
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsResolverPolicyPatchInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsResolverPolicyPatchTags _tag;

        /// <summary>Tags for DNS resolver policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsResolverPolicyPatchTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.DnsResolverPolicyPatchTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="DnsResolverPolicyPatch" /> instance.</summary>
        public DnsResolverPolicyPatch()
        {

        }
    }
    /// Describes a DNS resolver policy for PATCH operation.
    public partial interface IDnsResolverPolicyPatch :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.IJsonSerializable
    {
        /// <summary>Tags for DNS resolver policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tags for DNS resolver policy.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsResolverPolicyPatchTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsResolverPolicyPatchTags Tag { get; set; }

    }
    /// Describes a DNS resolver policy for PATCH operation.
    internal partial interface IDnsResolverPolicyPatchInternal

    {
        /// <summary>Tags for DNS resolver policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsResolverPolicyPatchTags Tag { get; set; }

    }
}