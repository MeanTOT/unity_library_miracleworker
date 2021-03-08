using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inverter : Node
{
    protected Node Node;

    public Inverter(Node node)
    {
        this.Node = node;
    }

    public override EState Evaluate()
    {
        switch (Node.Evaluate())
        {            
            case EState.Running:
                State = EState.Running;
                break;
            case EState.Success:
                State = EState.Failure;
                break;
            case EState.Failure:
                State = EState.Success;
                break;
            default:
                break;
        }

        return State;
    }
}
