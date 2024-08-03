using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SequencerNode : CompositeNode
{
    private int _current;

    public override string desciption
    {
        get { return "can comflex connection Node"; }
    }

    protected  override void OnEnter()
    {
        _current = 0;
    }

    protected override void OnExit()
    {
        
    }

    //�� �����ӿ� ��� �ڽ��� ��ȸ�ϴ� ���� �ƴ϶� �� �����ӿ� �� �ڽľ��� ��ȸ�ϴ� ����. �̰� �³�?
    protected override eState OnUpdate()
    {
        StateNode child = children[_current];

        switch (child.Update())
        {
            case eState.Running: return eState.Running;
            case eState.Failure: return eState.Failure;
            case eState.Success: _current++; break;
        }

        if (_current == children.Count)
        {
            return eState.Success;
        }
        else
        {
            return eState.Running;
        }
    }
}
