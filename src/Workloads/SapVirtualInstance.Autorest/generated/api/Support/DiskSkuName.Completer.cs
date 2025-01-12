// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support
{

    /// <summary>Defines the disk sku name.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuNameTypeConverter))]
    public partial struct DiskSkuName :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_LRS".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_LRS'", "Standard_LRS", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_LRS");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Premium_LRS".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Premium_LRS'", "Premium_LRS", global::System.Management.Automation.CompletionResultType.ParameterValue, "Premium_LRS");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "StandardSSD_LRS".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'StandardSSD_LRS'", "StandardSSD_LRS", global::System.Management.Automation.CompletionResultType.ParameterValue, "StandardSSD_LRS");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UltraSSD_LRS".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UltraSSD_LRS'", "UltraSSD_LRS", global::System.Management.Automation.CompletionResultType.ParameterValue, "UltraSSD_LRS");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Premium_ZRS".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Premium_ZRS'", "Premium_ZRS", global::System.Management.Automation.CompletionResultType.ParameterValue, "Premium_ZRS");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "StandardSSD_ZRS".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'StandardSSD_ZRS'", "StandardSSD_ZRS", global::System.Management.Automation.CompletionResultType.ParameterValue, "StandardSSD_ZRS");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PremiumV2_LRS".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'PremiumV2_LRS'", "PremiumV2_LRS", global::System.Management.Automation.CompletionResultType.ParameterValue, "PremiumV2_LRS");
            }
        }
    }
}