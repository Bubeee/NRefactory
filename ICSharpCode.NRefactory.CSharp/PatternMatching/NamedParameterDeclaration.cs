//
// NamedParameterDeclaration.cs
//
// Author:
//       Mike Krüger <mkrueger@xamarin.com>
//
// Copyright (c) 2013 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Collections.Generic;
using ICSharpCode.NRefactory.CSharp.Resolver;
using ICSharpCode.NRefactory.TypeSystem;
using ICSharpCode.NRefactory.CSharp;

namespace ICSharpCode.NRefactory.PatternMatching
{
	public class NamedParameterDeclaration : ParameterDeclaration
	{
		readonly string groupName;
		public string GroupName {
			get { return groupName; }
		}

		public NamedParameterDeclaration(string groupName = null)
		{
			this.groupName = groupName;
		}

		public NamedParameterDeclaration(string groupName, AstType type, string name, ParameterModifier modifier = ParameterModifier.None) : base (type, name, modifier)
		{
			this.groupName = groupName;
		}

		public NamedParameterDeclaration(AstType type, string name, ParameterModifier modifier = ParameterModifier.None) : base (type, name, modifier)
		{
		}

		protected internal override bool DoMatch(AstNode other, Match match)
		{
			match.Add(this.groupName, other);
			return base.DoMatch(other, match);
		}
	}
}

