// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using Bicep.Core.Syntax;

namespace Bicep.Core.Semantics
{
    public class LocalSymbol : DeclaredSymbol
    {
        public LocalSymbol(ISymbolContext context, string name, IdentifierSyntax declaringSyntax)
            : base(context, name, declaringSyntax, declaringSyntax)
        {
        }

        public override void Accept(SymbolVisitor visitor) => visitor.VisitLocalSymbol(this);

        public override SymbolKind Kind => SymbolKind.Local;
    }
}
