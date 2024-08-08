using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public abstract class CompositeNode : Node
{
    [HideInInspector]
    public List<Node> children = new List<Node>();

    public override eNodeType baseType
    {
        get { return eNodeType.Composite; }
    }

    public override Node Clone()
    {
        CompositeNode node = base.Clone() as CompositeNode;
        node.children = children.ConvertAll(c => c.Clone());
        return node;
    }
}
