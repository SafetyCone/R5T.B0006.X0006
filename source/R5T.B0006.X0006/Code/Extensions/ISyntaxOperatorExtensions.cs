using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using Instances = R5T.B0006.X0006.Instances; /// <see cref="R5T.B0006.X0006.Documentation"/>


namespace System
{
    public static class ISyntaxOperatorExtensions
    {
        public static CompilationUnitSyntax AddUsingDirective(this ISyntaxOperator _,
            CompilationUnitSyntax compilationUnit,
            UsingDirectiveSyntax usingDirective)
        {
            var output = Instances.SyntaxOperator_AddSimple.AddUsingDirective(
                compilationUnit,
                usingDirective);

            return output;
        }

        public static CompilationUnitSyntax AddNamespace(this ISyntaxOperator _,
            CompilationUnitSyntax compilationUnit,
            NamespaceDeclarationSyntax @namespace)
        {
            var output = Instances.SyntaxOperator_AddSimple.AddNamespace(
                compilationUnit,
                @namespace);

            return output;
        }
    }
}
