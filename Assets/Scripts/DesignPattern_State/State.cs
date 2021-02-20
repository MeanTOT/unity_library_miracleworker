using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker
{
    public abstract class State
    {
        protected Sample_GameActor Sample_GameActor;
        protected StateMachine StateMachine;

        protected State(Sample_GameActor sample_GameActor, StateMachine stateMachine)
        {
            this.Sample_GameActor = sample_GameActor;
            this.StateMachine = stateMachine;
        }

        public abstract void Enter();
        public abstract void LogicUpdate();
        public abstract void PhysicsUpdate();
        public abstract void Exit();
    }
}
