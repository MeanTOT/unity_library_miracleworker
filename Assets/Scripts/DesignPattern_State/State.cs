using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker
{
    public abstract class State
    {        
        protected StateMachine SM;

        protected State(Sample_GameActor sample_GameActor, StateMachine stateMachine)
        {            
            this.SM = stateMachine;
        }

        public abstract void Enter();
        public abstract void LogicUpdate();
        public abstract void PhysicsUpdate();
        public abstract void Exit();
    }
}
