// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Rbac.V1Beta1
{

    [OutputType]
    public sealed class PolicyRule
    {
        /// <summary>
        /// APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.
        /// </summary>
        public readonly ImmutableArray<string> ApiGroups;
        /// <summary>
        /// NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as "pods" or "secrets") or non-resource URL paths (such as "/api"),  but not both.
        /// </summary>
        public readonly ImmutableArray<string> NonResourceURLs;
        /// <summary>
        /// ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.
        /// </summary>
        public readonly ImmutableArray<string> ResourceNames;
        /// <summary>
        /// Resources is a list of resources this rule applies to.  '*' represents all resources in the specified apiGroups. '*/foo' represents the subresource 'foo' for all resources in the specified apiGroups.
        /// </summary>
        public readonly ImmutableArray<string> Resources;
        /// <summary>
        /// Verbs is a list of Verbs that apply to ALL the ResourceKinds and AttributeRestrictions contained in this rule. '*' represents all verbs.
        /// </summary>
        public readonly ImmutableArray<string> Verbs;

        [OutputConstructor]
        private PolicyRule(
            ImmutableArray<string> apiGroups,

            ImmutableArray<string> nonResourceURLs,

            ImmutableArray<string> resourceNames,

            ImmutableArray<string> resources,

            ImmutableArray<string> verbs)
        {
            ApiGroups = apiGroups;
            NonResourceURLs = nonResourceURLs;
            ResourceNames = resourceNames;
            Resources = resources;
            Verbs = verbs;
        }
    }
}
