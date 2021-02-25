using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker
{
    public class Sample_GameActorState : State
    {
        public Sample_Player _Sample_Player { get; private set; }        

        public Sample_GameActorState(Sample_GameActor sample_GameActor, StateMachine stateMachine) : base(sample_GameActor, stateMachine)
        {
            _Sample_Player = (Sample_Player)sample_GameActor;            
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
