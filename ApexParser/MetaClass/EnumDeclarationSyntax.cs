﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApexParser.Visitors;

namespace ApexParser.MetaClass
{
    public class EnumDeclarationSyntax : MemberDeclarationSyntax
    {
        public EnumDeclarationSyntax(MemberDeclarationSyntax heading = null)
            : base(heading)
        {
        }

        public override SyntaxType Kind => SyntaxType.Enum;

        public override void Accept(ApexSyntaxVisitor visitor) => visitor.VisitEnum(this);

        public string Identifier { get; set; }

        public List<EnumMemberDeclarationSyntax> Members { get; set; } = new List<EnumMemberDeclarationSyntax>();
    }
}