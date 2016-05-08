//===========================================================================
// Title: Compiladores - Imperative.
// Description: Contains the implementation of the Expressions language 
// Copyright © 2008 G.K.M Oliveira.
// Dept. of Computing Science, Federal University of Pernambuco, Brazil
// All Rights Reserved
//===========================================================================
// This software is provided free for educational use only. It may
// not be used for commercial purposes without the prior written permission
// of the authors.
//===========================================================================

using System;
using System.Collections.Generic;
using System.Text;

using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Haskell.CoreParser.AbstractSyntaxTree
{
    public abstract class Node : CommonTree
    {
        private Dictionary<string, object> _fasesObject;

        public Node()
            : base()
        {

        }

        public Node(IToken payload) 
            : base(payload)
        {

        }

        public override string ToString()
        {
            return GetType().Name;
        }

        public abstract object Accept(ICoreVisitor visitor, object o);

        public override bool Equals(object obj)
        {
            Node other = obj as Node;
            if (other == null)
            {
                return false;
            }

            return this.Text == other.Text;
        }

        public override int GetHashCode()
        {
            return this.Text.GetHashCode();
        }

        public void SetObject(string fase, object obj)
        {
            _fasesObject[fase] = obj;
        }

        public T GetObject<T>(string fase)
        {
            return (T)_fasesObject[fase];
        }
    }
}
