using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node
{
    public enum EState
    {
        Running,
        Success,
        Failure,
    }

    protected EState State { get; set; }
    public abstract EState Evaluate();

}
