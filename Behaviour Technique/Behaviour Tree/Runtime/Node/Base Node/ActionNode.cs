using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public abstract class ActionNode : StateNode
{
    public override eNodeType nodeType
    {
        get { return eNodeType.Action; }
    }
}
