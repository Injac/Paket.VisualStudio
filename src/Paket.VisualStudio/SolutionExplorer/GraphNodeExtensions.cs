﻿using System;
using Microsoft.VisualStudio.GraphModel;
using Microsoft.VisualStudio.GraphModel.Schemas;

namespace Paket.VisualStudio.SolutionExplorer
{
    internal static class GraphNodeExtensions
    {
        internal static bool IsPaketReferencesNode(this GraphNode node)
        {
            return node.HasCategory(CodeNodeCategories.ProjectItem) && node.Label == "paket.references";
        }

        internal static bool IsPaketDependenciesNode(this GraphNode node)
        {
            return node.HasCategory(CodeNodeCategories.ProjectItem) && node.Label == "paket.dependencies";
        }

        internal static string GetFileName(this GraphNodeId nodeId)
        {
            Uri fileName = nodeId.GetNestedValueByName<Uri>(CodeGraphNodeIdName.File);

            return (fileName != null) ? fileName.LocalPath : null;
        }
    }
}