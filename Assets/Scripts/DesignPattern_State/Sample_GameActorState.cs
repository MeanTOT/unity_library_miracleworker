using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker
{
    public class Sample_GameActorState : State
    {
        public Sample_GameActor Sample_GameActor { get; private set; }
        public StateMachine SM;

        public Sample_GameActorState(Sample_GameActor sample_GameActor, StateMachine stateMachine) : base(sample_GameActor, stateMachine)
        {
            Sample_GameActor = sample_GameActor;
            SM = stateMachine;
        }

        public override void Enter()
        {
            
        }

        public override void Exit()
        {
            
        }

        public override void LogicUpdate()
        {
            
        }

        public override void PhysicsUpdate()
        {
            
        }
    }
}
