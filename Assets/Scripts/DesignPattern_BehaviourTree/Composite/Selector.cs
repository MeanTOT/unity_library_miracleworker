using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Node
{
    protected List<Node> Nodes = new List<Node>();

    public Selector(List<Node> nodes)
    {
        this.Nodes = nodes;
    }

    public override EState Evaluate()
    {
        foreach (var node in Nodes)
        {
            switch(node.Evaluate())
            {
                case EState.Running:
                    State = EState.Running;
                    return State;
                case EState.Success:
                    State = EState.Success;
                    return State;
                case EState.Failure:
                default:
                    break;
            }
        }

        State = EState.Failure;
        return State;
    }
}
