using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : Node
{
    protected List<Node> Nodes = new List<Node>();

    public Sequence(List<Node> nodes)
    {
        this.Nodes = nodes;
    }

    public override EState Evaluate()
    {
        bool isAnyNodeRunning = false;
        foreach (var node in Nodes)
        {
            switch(node.Evaluate())
            {
                case EState.Running:
                    isAnyNodeRunning = true;
                    break;
                case EState.Success:
                    break;
                case EState.Failure:
                    {
                        this.State = EState.Failure;
                        return State;
                    }                    
                default:
                    break;
            }
        }

        State = isAnyNodeRunning ? EState.Running : EState.Success;
        return State;
    }
}
